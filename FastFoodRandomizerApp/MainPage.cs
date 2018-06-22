using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using FlickrNet;
using System.Net.Http;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

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

            HttpClient client = new HttpClient();
            string url = " https://api.flickr.com/services/rest/" +
                "?method=flickr.photos.search" +
                "&api_key=fb5dc380eb015efece04a1eb44bd425e" +
                "&text=form1.Result.text" +
                "&sort=Popular&per_page=1" +
                "&page=1&format=json&nojsoncallback=1" +
                "&api_sig=c3ccddeaa369d04d75dfff5e7b110b24";
            string license = "4, 5, 6, 7";
            license.Replace(",", "%2C");
            string ApiText = Result.Text;
            string flickrApiKey = "898db76e861ae522544ff18866386h50b";
            var baseurl = string.Format(url, license, flickrApiKey, ApiText);
            string flickrResult = await client.GetStringAsync(baseurl);
            FlickrData apiData = JsonConvert.DeserializeObject<FlickrData>(flickrResult);
            if (apiData.Stat == "ok")
            {
                foreach (Photo data in apiData.Photos.Photo)
                {
                    string photoUrl = "http://farm{0}.staticflickr.com/{1}/{2}_{3}_n.jpg";
                    string baseFlickrUrl = string.Format(photoUrl, data.Farm, data.Server, data.Id, data.Secret);
                    Flickr f = new Flickr(flickrApiKey);
                    PhotoSearchOptions options = new PhotoSearchOptions
                    {
                        Page = 1,
                        PerPage = 1,
                        Text = Result.Text
                    };
                    PhotoCollection searchResults = f.PhotosSearch(options);
                    

                    //fastFoodDeatailPage.pictureBox1.Image = searchResults;
                    break;
                }
            }
            fastFoodDeatailPage.Show();
            fastFoodDeatailPage.RestaurantName.Text = Result.Text;
        }
        private void AddLocation_Click(object sender, EventArgs e)
        {
            AddLocationPage addLocationPage = new AddLocationPage();
            addLocationPage.Show();
        }
    }
    public class Photo
    {
        public string Id { get; set; }
        public string Owner { get; set; }
        public string Secret { get; set; }
        public string Server { get; set; }
        public int Farm { get; set; }
        public string Title { get; set; }
        public int Ispublic { get; set; }
        public int Isfriend { get; set; }
        public int Isfamily { get; set; }
    }
    public class Photos
    {
        public int Page { get; set; }
        public int Pages { get; set; }
        public int Perpage { get; set; }
        public string Total { get; set; }
        public List<object> Photo { get; set; }
    }

    public class FlickrData
    {
        public Photos Photos { get; set; }
        public string Stat { get; set; }
    }
}
