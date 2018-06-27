using System;
using System.Windows.Forms;

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
            MainPage mainpage = new MainPage();

        }
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

        public void FlickrImage_click(object sender, EventArgs e)
        {

        }
    }
}
