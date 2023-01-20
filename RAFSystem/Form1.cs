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
           
            Registrar Regi = new Registrar();
            Cashier Cash = new Cashier();

        

            if (username.Text == "Cashier" && password.Text == "123")
            {
                this.Hide();
                Cash.Show();


            }else if (username.Text == "Registrar" && password.Text == "123")
            {
                this.Hide();
                Regi.Show();


            }
            else
            {

                MessageBox.Show("Invalud Input, Only Cashier and Registrar");



            }








        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
