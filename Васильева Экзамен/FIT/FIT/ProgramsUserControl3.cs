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
    public partial class ProgramsUserControl3 : UserControl
    {
        ProgramData programData = new ProgramData();
        private Client client;

        public ProgramsUserControl3(ProgramData programData)
        {
            InitializeComponent();
            this.programData = programData;
        }

        public ProgramsUserControl3(Client client)
        {
            this.client = client;
        }

        private void ProgramsUserControl3_Load(object sender, EventArgs e)
        {
            textBox1.Text = programData.program;
            textBox2.Text = programData.desc;
        }
    }
}
