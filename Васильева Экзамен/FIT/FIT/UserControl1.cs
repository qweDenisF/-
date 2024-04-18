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
    public partial class UserControl1 : UserControl
    {
        public VisitingObject visitingObject;
        public UserControl1(VisitingObject visit)
        {
            InitializeComponent();
            this.visitingObject = visit;
        }

        public void UserControl1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            idLabel.Text = visitingObject.ID;
            fullNameLabel.Text = visitingObject.fullName;
            serviceLabel.Text = visitingObject.service;
            time.Text = visitingObject.time;
            Phone.Text = visitingObject.phone;
            priceLabel.Text = visitingObject.price;
        }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }

        private void deleteLabel_MouseMove(object sender, MouseEventArgs e)
        {
            deleteLabel.BackColor = Color.LightGray;
        }

        private void deleteLabel_MouseLeave(object sender, EventArgs e)
        {
            deleteLabel.BackColor = this.BackColor;

        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {
            var delete = MessageBox.Show("Удалить запись?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (delete == DialogResult.Yes)
            {
                string sqlConnect = @"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=FIT;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(sqlConnect))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("delete from Visiting Where (ID = @id)", connection);
                    sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(idLabel.Text));
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                }
                
                MessageBox.Show("Обновите данные формы. Нажмите на кнопку 'Вcе записи'");
            }
        }
    }
}