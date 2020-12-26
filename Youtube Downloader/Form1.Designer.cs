namespace Youtube_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txturl = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.qualitycb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndl = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(18, 15);
            this.txturl.Margin = new System.Windows.Forms.Padding(4);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(398, 25);
            this.txturl.TabIndex = 0;
            this.txturl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txturl.TextChanged += new System.EventHandler(this.txturl_TextChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(328, 47);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(88, 24);
            this.btnsubmit.TabIndex = 1;
            this.btnsubmit.Text = "Fetch";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // qualitycb
            // 
            this.qualitycb.FormattingEnabled = true;
            this.qualitycb.Location = new System.Drawing.Point(83, 47);
            this.qualitycb.Name = "qualitycb";
            this.qualitycb.Size = new System.Drawing.Size(69, 24);
            this.qualitycb.Sorted = true;
            this.qualitycb.TabIndex = 3;
            this.qualitycb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quality :";
            // 
            // btndl
            // 
            this.btndl.Enabled = false;
            this.btndl.Location = new System.Drawing.Point(222, 47);
            this.btndl.Margin = new System.Windows.Forms.Padding(4);
            this.btndl.Name = "btndl";
            this.btndl.Size = new System.Drawing.Size(99, 24);
            this.btndl.TabIndex = 1;
            this.btndl.Text = "Download";
            this.btndl.UseVisualStyleBackColor = true;
            this.btndl.Click += new System.EventHandler(this.btndl_Click);
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(20, 74);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(394, 16);
            this.lblname.TabIndex = 4;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 104);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qualitycb);
            this.Controls.Add(this.btndl);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txturl);
            this.Font = new System.Drawing.Font("Neon 80s", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ComboBox qualitycb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndl;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

