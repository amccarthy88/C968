using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class closeWindowMessage : Form
    {
        private C968 c968;
        public closeWindowMessage(C968 c968)
        {
            InitializeComponent();
            this.c968 = c968;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            c968.Close();
        }

        private void closeWindowMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
