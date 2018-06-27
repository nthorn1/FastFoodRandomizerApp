using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FastFoodRandomizerApp
{
    public partial class AddLocationPage : Form
    {
        SqlConnection Conn = new SqlConnection(connectionString: @"Server =.\sqlexpress; Initial Catalog = Fast Food Randomizer DB; Database= Fast Food Randomizer DB; integrated security = SSPI; user = nthorn; password = Test;");

        public AddLocationPage()
        {
            InitializeComponent();
        }

        private void SaveLocation_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.AddLocationTextBox.Text, @"[^\w\s]"))
            {
                SqlCommand cmd = new SqlCommand("dbo.sp_insert", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@FastFoodChains", AddLocationTextBox.Text);

                Conn.Open();

                cmd.ExecuteNonQuery();

                Conn.Close();

                MessageBox.Show("Location Saved");

                AddLocationTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid Character");
            }
        }

        private void AddLocationTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {

        }
    }
}
