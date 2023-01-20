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

namespace RAFSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
                password.ForeColor = Color.Gray;
                password.Text = "Enter Password";
                password.UseSystemPasswordChar = false;
                SelectNextControl(password, true, true, false, true);


                username.ForeColor = Color.Gray;
                username.Text = "Enter Username";
                username.UseSystemPasswordChar = false;
                SelectNextControl(password, true, true, false, true);

            


        }

        public UpdateRaf URAF { get; set; }

        


        private void loginbtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(publicstuff.con1);
            con.Open();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;



            }
            else
            {

                password.UseSystemPasswordChar = true;
            }
        }

      

      

        private void username_Click(object sender, EventArgs e)
        {
            if (username.ForeColor == Color.Gray)
            {
                username.ForeColor = Color.Empty;
                username.Text = "";

            }
        }

      

        private void password_Click(object sender, EventArgs e)
        {
            if (password.ForeColor == Color.Gray)
            {
                password.ForeColor = Color.Empty;
                password.Text = "";

            }
        }
    }
}
