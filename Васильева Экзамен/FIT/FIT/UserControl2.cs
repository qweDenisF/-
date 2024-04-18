using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlConnect = @"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=FIT;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(sqlConnect))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("Insert into Visiting values (@FullName, @Service, @Price, @DateTime, @Phone)", connection);
                    sqlCommand.Parameters.AddWithValue("@FullName", textBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@Service", textBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@Price", Convert.ToInt32(textBox3.Text));
                    sqlCommand.Parameters.AddWithValue("@DateTime", textBox4.Text);
                    sqlCommand.Parameters.AddWithValue("@Phone", textBox5.Text);
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Данные не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Данные сохранены");
        }
    }
}
