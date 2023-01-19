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
    public partial class Cashier : Form
    {

        SqlConnection con = new SqlConnection(publicstuff.con1);



        SqlCommand Commando;
        SqlDataReader DataReaders;
        SqlDataAdapter sDa;



        public Cashier()
        {
            InitializeComponent();
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("Subject", 150);



            comboBox1.Items.Clear();




            string sql = "SELECT * FROM StudentInfo";
            Commando = new SqlCommand(sql, con);
            con.Open();

            DataReaders = Commando.ExecuteReader();
            while (DataReaders.Read())
            {
                comboBox1.Items.Add(DataReaders["ID"]);

            }

            con.Close();



        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 FRM1 = new Form1();
            FRM1.Show();
            this.Close();
        }


        public void tableLoad()
        {
            con.Open();
            SqlCommand filter = new SqlCommand("Select Subject FROM StudentInfoFull WHERE StudentID =@id", con);
            filter.Parameters.AddWithValue("@id", studentID.Text);

            SqlDataReader rd;
            
            rd = filter.ExecuteReader();
            listView1.Items.Clear();


            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetString(0));
                lv.SubItems.Add(rd.GetString(0).ToString());

                listView1.Items.Add(lv);


            }


            rd.Close();
            filter.Dispose();


            con.Close();





        }

       

        private void summonstn_Click(object sender, EventArgs e)
        {
            String TempItem = comboBox1.GetItemText(comboBox1.SelectedItem);

            if (!studentID.Equals("800000") || !TempItem.Equals("800000"))
            {


                Commando = new SqlCommand("SELECT * FROM StudentInfo WHERE ID=@ids", con);
                Commando.Parameters.AddWithValue("@ids", studentID.Text);
                con.Open();

                DataReaders = Commando.ExecuteReader();

                while (DataReaders.Read())
                {

                    
                    String FirstName = DataReaders["FirstName"].ToString();
                    String LastName = DataReaders["LastName"].ToString();
                    String Course = DataReaders["Course"].ToString();
                    String SchoolYears = DataReaders["SchoolYears"].ToString();
                    String Age = DataReaders["Age"].ToString();
                    String Gender = DataReaders["Gender"].ToString();
                    String SubjectCost = DataReaders["SubjectCosts"].ToString();
                    String ExtraCost = DataReaders["ExtraCosts"].ToString();
                    String TotalCosts = DataReaders["TotalCost"].ToString();
                    String MiddleName = DataReaders["MiddleName"].ToString();


                    
                    firstnameBox.Text = FirstName;
                    lastnameBox.Text = LastName;
                    courseBox.Text = Course;
                    ylBox.Text = SchoolYears;
                    ageBox.Text = Age;
                    genderBox.Text = Gender;
                   middlenameBox.Text = MiddleName;

                    totalcost.Text = TotalCosts;


                }


                DataReaders.Close();


                con.Close();

                tableLoad();


                //-----------------













            }
            else
            {

                MessageBox.Show("Cannot Access that Information.");


            }







        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String TempItem = comboBox1.GetItemText(comboBox1.SelectedItem);


            if (!TempItem.Equals("800000"))
            {


                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM StudentInfo WHERE ID =@ids";
                cmd.Parameters.AddWithValue("@ids", comboBox1.SelectedItem.ToString());
                studentID.Text = TempItem;



                con.Close();


                Commando = new SqlCommand("SELECT * FROM StudentInfo WHERE ID=@ids", con);
                Commando.Parameters.AddWithValue("@ids", studentID.Text);
                con.Open();

                DataReaders = Commando.ExecuteReader();

                while (DataReaders.Read())
                {


                    String FirstName = DataReaders["FirstName"].ToString();
                    String LastName = DataReaders["LastName"].ToString();
                    String Course = DataReaders["Course"].ToString();
                    String SchoolYears = DataReaders["SchoolYears"].ToString();
                    String Age = DataReaders["Age"].ToString();
                    String Gender = DataReaders["Gender"].ToString();
                    String SubjectCost = DataReaders["SubjectCosts"].ToString();
                    String ExtraCost = DataReaders["ExtraCosts"].ToString();
                    String TotalCosts = DataReaders["TotalCost"].ToString();
                    String MiddleName = DataReaders["MiddleName"].ToString();



                    firstnameBox.Text = FirstName;
                    lastnameBox.Text = LastName;
                    courseBox.Text = Course;
                    ylBox.Text = SchoolYears;
                    ageBox.Text = Age;
                    genderBox.Text = Gender;
                    middlenameBox.Text = MiddleName;

                    totalcost.Text = TotalCosts;


                }


                DataReaders.Close();


                con.Close();

                tableLoad();




            }
            else
            {
                MessageBox.Show("Unable to Use that one");


            }
        }

        private void payment_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(payout.Text, out double result) && Double.Parse(payout.Text) >= 0)
            {
                double Payout = double.Parse(payout.Text);



                Commando = new SqlCommand("SELECT * FROM StudentInfo WHERE ID=@ids", con);
                Commando.Parameters.AddWithValue("@ids", studentID.Text);
                con.Open();

                DataReaders = Commando.ExecuteReader();

                while (DataReaders.Read())
                {


                    String TotalCosts = DataReaders["TotalCost"].ToString();


                    double ParsedTotalCosts = Double.Parse(TotalCosts);

                    if (Payout > ParsedTotalCosts)
                    {
                        double Total = Payout - ParsedTotalCosts;

                        MessageBox.Show
                            ("Overpaid: Please return this amount of Change: "
                             + Total
                             );



                    }
                    else if (Payout == ParsedTotalCosts)
                    {
                        double Total = Payout - ParsedTotalCosts;
                        MessageBox.Show
                          ("Payment Succesfull"
                           
                           );


                    }
                    else
                    {
                        double Total = ParsedTotalCosts - Payout;
                        MessageBox.Show
                          ("Remaining Balance: " +
                            Total
                           );


                    }
                    




                }
                

                DataReaders.Close();


                con.Close();





            }
            else
            {
                MessageBox.Show("Please Input Things Properly.");

            }







        }

        private void print_Click(object sender, EventArgs e)
        {














        }
    }
}
