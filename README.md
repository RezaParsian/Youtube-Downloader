# Youtube-Downloader

دانلود از یوتیوب با C# + source code
سلام
بی شک یوتیوب یکی از بهترین منابع برای آموزش و خوشگذرونی هست که هرکسی تا به حال به چشم دیده.
مشکل اصلی این شبکه این هست که به سادگی نمیتونید فیلم ها رو روی سیستم خودتون ذخیره کنید و مجبورید بار ها و بارها به این سایت مراجعه کنید تا به هدفتون برسید.
هر شخصی نیاز داره که بتونه از این سایت به صورت خیلی ساده دانلود کنه اما هر برنامه نویسی دوست داره از برنامه های خودش برای رسید به اهدافش استفاده کنه.
در این پست هم میخوام به شما دوستان کمک کنیم که برنامه یوتیوب دانلود خودتون رو بنویسید یا سورس من رو ارتقاع بدید.
برای دریافت اطلاعات ویدیو مورد نظر میتونید از آدرس زیر استفاده کنید

https://www.youtube.com/get_video_info?video_id=

فقط کافیه ID ویدیو خودتون رو به اخر این ادرس اضاف کنید بعد از فراخوانی این ادرس متاسفانه به چیزی نخواید رسید چون قابل درک نیست بذارید اول یک درخواست به این ادرس ارسال کنید تا دقیقا متوجه بشید.

string result;
using (WebClient wb = new WebClient()){
          result = wb.DownloadString(url);
}

خب مقدار برگشتی رو توی result ذخیره کردیم ولی این قابل درک نیست.خب باید چیکار کنیم؟
من بررسی کردم و متوجه شدم این رشته کد شده هست.اگر اشتباه نکنم base 64 یا url هست نحوه کدگذاری.

result = HttpUtility.UrlDecode(result);

بعد از این مرحله این رشته قابل درک هست و باید بیایم اون قسمت که نیاز داریم رو پیدا کنیم و به json تبدیلش کنیم برای استفاده.
برای این کار من یک تابع نوشتم که زیاد به توضیح نیاز نداره.

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

برای این که بعدا بتونم راحت تر به این لینک ها و کیفیت اون ها دسترسی پیدا کنم یک کلاس تعریف کردم به اسم  youtube_movies که از اون یک لیست درست کردم

 class youtube_movies

    {

        public string url { get; set; }

        public string quality { get; set; }

    }

برای این که لیستم خالی نباشه خروجی تابع بالا رو در کد زیر قرار دادم

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

حالا لیست ما امادس و میتونید به هر طریقی که دوست دارید ازش استفاده کنید
این کد فقط یک مشکل داره که موزیک ویدیو های منتشر شده در سایت یوتیوب رو پیدا نمیکنه که احتمال میدم برای بحث کپی رایت باشه
امیدوارم خوشتون امده باشه
RezaParsian/Youtube-Downloader
RezaParsian/Youtube-Downloader
Contribute to RezaParsian/Youtube-Downloader development by creating an account on GitHub.
github.com
رضا پارسیان - برنامه نویس کوچک
رضا پارسیان - برنامه نویس کوچک
🤘🏻im Not Perfect But I'm Limited Edition🤘
rp76.ir

