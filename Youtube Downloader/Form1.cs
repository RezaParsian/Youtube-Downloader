using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Youtube_Downloader
{
    public partial class Form1 : Form
    {
        List<youtube_movies> yml = new List<youtube_movies>();
        JObject videoinfo;
        string info_url = "https://www.youtube.com/get_video_info?video_id=";
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txturl.Text == "" || txturl.Text == "")
            {
                errorProvider1.SetError(txturl, "Paste your url first.");
                return;
            }

            try
            {
                string v_param = txturl.Text.Split(new string[] { "v=" }, StringSplitOptions.None)[1];

                string info;
                info = await Task.Run(() => { return GetVideoInfo(info_url + v_param); });
                info = DecodeVideoInfo(info);

                videoinfo = FindJsonFromVideoInfo(info);

                JArray quality = JArray.Parse(videoinfo["streamingData"]["adaptiveFormats"].ToString());

                FillArray(quality);

                FillDropDown();

                lblname.Text = videoinfo["videoDetails"]["title"].ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Object reference not set to an instance of an object.")
                {
                    MessageBox.Show("Sorry we cant find any Quality", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("We got some error \n " + ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }

        private void FillDropDown()
        {
            qualitycb.Items.Clear();

            foreach (var item in yml)
            {
                qualitycb.Items.Add(item.quality);
            }

            errorProvider2.SetError(qualitycb, "Please choose one quality.");
        }

        void FillArray(JArray quality)
        {
            foreach (var item in quality)
            {
                if (item["mimeType"].ToString().Contains("audio"))
                {
                    continue;
                }
                youtube_movies ym = new youtube_movies()
                {
                    url = item["url"].ToString(),
                    quality = item["qualityLabel"].ToString().ToUpper()
                };

                yml.Add(ym);
            }
        }

        string GetVideoInfo(string url)
        {
            string result;
            using (WebClient wb = new WebClient())
            {
                result = wb.DownloadString(url);
            }
            return result;
        }

        string DecodeVideoInfo(string info)
        {
            string result;

            result = HttpUtility.UrlDecode(info);

            return result;
        }

        JObject FindJsonFromVideoInfo(string info)
        {
            JObject result;
            string temp;
            string[] infos;

            infos = info.Split('&');

            temp = Array.Find(infos, x => x.StartsWith("player_response"));
            temp = temp.Split(new string[] { "player_response=" }, StringSplitOptions.None)[1];

            result = JObject.Parse(temp);

            return result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btndl.Enabled = true;
        }

        private void btndl_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(yml[qualitycb.SelectedIndex].url);
            }
            catch (Exception)
            {
                MessageBox.Show("Choose a quality then try");
            }
        }

        private void txturl_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txturl, "");
        }
    }
}
