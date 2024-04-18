using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT
{
    public partial class Form1 : Form
    {
        List<VisitingObject> allVisits;
        public Form1()
        {
            InitializeComponent();

            ShowAllVisits();
        }

        private void ShowAllVisits()
        {
            label3.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            

            fullNameLabel.Visible = true;
            idLabel.Visible = true;
            idLabel.Visible = true;
            priceLabel.Visible = true;
            Phone.Visible = true;
            serviceLabel.Visible = true;
            time.Visible = true;

            flowLayoutPanel1.Controls.Clear();
            allVisits = new List<VisitingObject>();

            string sqlConnect = @"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=FIT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(sqlConnect))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Visiting", connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    VisitingObject visit = new VisitingObject();
                    visit.ID = reader.GetInt32(0).ToString();
                    visit.fullName = reader.GetString(1);
                    visit.service = reader.GetString(2);
                    visit.price = reader.GetInt32(3).ToString();
                    visit.time = reader.GetString(4);
                    visit.phone = reader.GetString(5);

                    allVisits.Add(visit);

                    UserControl1 userContol = new UserControl1(visit);
                    flowLayoutPanel1.Controls.Add(userContol);
                }
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            UserControl2 userControl2 = new UserControl2();
            flowLayoutPanel1.Controls.Add(userControl2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllVisits();
        }

        private void progandservice_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label2.Visible = true;

            fullNameLabel.Visible = false;
            idLabel.Visible = false;
            idLabel.Visible = false;
            priceLabel.Visible = false;
            Phone.Visible = false;
            serviceLabel.Visible = false;
            time.Visible = false;

            flowLayoutPanel1.Controls.Clear();
            string sqlConnect = @"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=FIT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(sqlConnect))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Programs", connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ProgramData program = new ProgramData();
                    program.program = reader.GetString(1);
                    program.desc = reader.GetString(0);

                    ProgramsUserControl3 userContol = new ProgramsUserControl3(program);
                    flowLayoutPanel1.Controls.Add(userContol);
                }
                connection.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label3.Visible = false;
            label2.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            fullNameLabel.Visible = true;
            idLabel.Visible = true;

            priceLabel.Visible = true;
            Phone.Visible = true;
            serviceLabel.Visible = false;
            time.Visible = false;

            flowLayoutPanel1.Controls.Clear();
            string sqlConnect = @"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=FIT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(sqlConnect))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Clients", connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.ID = reader.GetInt32(0).ToString();
                    client.fullName = reader.GetString(1);
                    client.Membership = reader.GetString(2);
                    client.CardNumber = reader.GetInt32(3).ToString();
                   client.Price = reader.GetString(4);
                   client.phone = reader.GetString(5);

                    ClientUserControl3 userContol = new ClientUserControl3(client);
                    flowLayoutPanel1.Controls.Add(userContol);
                }
                connection.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
