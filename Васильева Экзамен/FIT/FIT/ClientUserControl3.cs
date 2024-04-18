using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT
{
    public partial class ClientUserControl3 : UserControl
    {
        Client client;
        public ClientUserControl3(Client client)
        {
            
            InitializeComponent();

            this.client = client;
        }

        private void deleteLabel_MouseLeave(object sender, EventArgs e)
        {
            deleteLabel.BackColor = this.BackColor;
        }

        private void deleteLabel_MouseHover(object sender, EventArgs e)
        {
        }

        private void ClientUserControl3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            idLabel.Text = client.ID;
            fullNameLabel.Text = client.fullName;
            membershiptype.Text = client.Membership;
            number.Text = client.CardNumber;
            priceLabel.Text = client.Price;
            Phone.Text = client.phone;
        }

        private void deleteLabel_MouseMove(object sender, MouseEventArgs e)
        {
            deleteLabel.BackColor = Color.LightGray;
        }

        private void ClientUserControl3_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }

        private void ClientUserControl3_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.AliceBlue;

        }
    }
}
