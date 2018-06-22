using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using FlickrNet;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Xml;
using System.ComponentModel;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace FastFoodRandomizerApp
{
    public partial class FastFoodDeatailPage : Form
    {
        public FastFoodDeatailPage()
        {
            InitializeComponent();
        }
        public void Form3_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Conn = new SqlConnection(connectionString: @"Server =.\sqlexpress; Initial Catalog = Fast Food Randomizer DB; Database= Fast Food Randomizer DB; integrated security = SSPI; user = nthorn; password = Test;");
        public string LabelText
        {
            get
            {
                return RestaurantName.Text;
            }
            set
            {
                RestaurantName.Text = value;
            }
        }
        public void RestaurantName_Click(object sender, EventArgs e)
        {
            
        }

        public void PictureBox1_click(object sender, EventArgs e)
        {

        }
    }
}
