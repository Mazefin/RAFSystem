using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAFSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public UpdateRaf URAF { get; set; }

        


        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar Regi = new Registrar();
            Cashier Cash = new Cashier();

            Regi.Show();



        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
