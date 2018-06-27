using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace FastFoodRandomizerApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(connectionString: @"Server =.\sqlexpress; Initial Catalog = Fast Food Randomizer DB; Database= Fast Food Randomizer DB; integrated security = SSPI; user = nthorn; password = Test;");

        readonly string queryString = "SELECT Top 1 FastFoodChains FROM FastFoodChains ORDER BY NEWID()";

        private void FastFoodRandomizer_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand(queryString, Conn);

                using (SqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Result.Text = Reader.GetString(0);
                    }
                }
            }
            finally
            {
                Conn.Close();
            }
        }
        public async void Result_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FastFoodDeatailPage fastFoodDeatailPage = new FastFoodDeatailPage();

            fastFoodDeatailPage.Show();

            fastFoodDeatailPage.RestaurantName.Text = Result.Text;

            HttpClient client = new HttpClient();

            string UrlText = Result.Text;

            string ApiKey = "898db76e861ae522544ff1886638650b";

            string url = "https://api.flickr.com/services/rest/" +
            "?method=flickr.photos.search" +
            "&api_key={0}" +
            "&tags=Restaurant" +
            "&text={1}" +
            "&sort=relevance" +
            "&safe_search=1" +
            "&per_page=1" +
            "&page=1" +
            "&format=json" +
            "&nojsoncallback=1";

            var baseurl = string.Format(url,
                ApiKey,
                UrlText);

            var flickrResult = await client.GetStringAsync(baseurl);

            FlickrData apiData = JsonConvert.DeserializeObject<FlickrData>(flickrResult);

            //HttpResponseMessage response = client.GetAsync(url).Result;          
            //MessageBox.Show(await response.Content.ReadAsStringAsync());

            if (apiData.stat == "ok")
            {
                foreach (Photo data in apiData.photos.photo)
                {
                    string photoUrl = "http://farm{0}.staticflickr.com/{1}/{2}_{3}_n.jpg";

                    string baseFlickrUrl = string.Format(photoUrl, data.farm, data.server, data.id, data.secret);

                    fastFoodDeatailPage.FlickrImage.Load(baseFlickrUrl);

                    break;
                }
            }
            else
            {
                MessageBox.Show("Error Loading Image");
            }
        }
        private void AddLocation_Click(object sender, EventArgs e)
        {
            AddLocationPage addLocationPage = new AddLocationPage();
            addLocationPage.Show();
        }
    }
    public class Photo
    {
        public string id { get; set; }
        public string owner { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public string title { get; set; }
        public int ispublic { get; set; }
        public int isfriend { get; set; }
        public int isfamily { get; set; }
    }

    public class Photos
    {
        public int page { get; set; }
        public int pages { get; set; }
        public int perpage { get; set; }
        public string total { get; set; }
        public List<Photo> photo { get; set; }
    }

    public class FlickrData
    {
        public Photos photos { get; set; }
        public string stat { get; set; }
    }
}
