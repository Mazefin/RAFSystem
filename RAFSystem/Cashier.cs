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
                    String Payment = DataReaders["Cash"].ToString();


                    firstnameBox.Text = FirstName;
                    lastnameBox.Text = LastName;
                    courseBox.Text = Course;
                    ylBox.Text = SchoolYears;
                    ageBox.Text = Age;
                    genderBox.Text = Gender;
                    middlenameBox.Text = MiddleName;
                    overpay.Text = Payment;
                    totalcost.Text = TotalCosts;


                   

                }


                DataReaders.Close();



                if (overpay.Text == "Null")
                {
                    overpay.Text = "0";


                }

                Commando = con.CreateCommand();
                Commando.CommandText = "UPDATE StudentInfo SET"
                + " Cash = '" + overpay.Text + "'"        
                 + " WHERE ID = " + studentID.Text;
                Commando.ExecuteNonQuery();
                Commando.Dispose();

                double paymento = double.Parse(overpay.Text);
                double totally = double.Parse(totalcost.Text);

                if (paymento < totally)
                {
                    double totalcosto = totally - paymento;

                    totalcost.Text = totalcosto.ToString();




                }
                else if (paymento > totally)
                {


                    double totalcosto = paymento - totally;

                    totalcost.Text = totalcosto.ToString();

                }
                else if (paymento == totally)
                {

                    double totalcosto = totally - paymento;


                    totalcost.Text = totalcosto.ToString();

                }










                con.Close();

                tableLoad();




            }
            else
            {
                MessageBox.Show("Unable to Use that one");


            }
        }


        public void reload()
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
                    String Payment = DataReaders["Cash"].ToString();


                    firstnameBox.Text = FirstName;
                    lastnameBox.Text = LastName;
                    courseBox.Text = Course;
                    ylBox.Text = SchoolYears;
                    ageBox.Text = Age;
                    genderBox.Text = Gender;
                    middlenameBox.Text = MiddleName;
                    overpay.Text = Payment;
                    totalcost.Text = TotalCosts;



                }



                DataReaders.Close();


                if (overpay.Text == "Null")
                {
                    overpay.Text = "0";


                }

                
                

                Commando = con.CreateCommand();
                Commando.CommandText = "UPDATE StudentInfo SET"
                + " Cash = '" + overpay.Text + "'"
                 + " WHERE ID = " + studentID.Text;
                Commando.ExecuteNonQuery();
                Commando.Dispose();



              


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
         }


        private void print_Click(object sender, EventArgs e)
        {
            // This if checks if tuition cost isn't 0
            if (double.Parse(totalcost.Text) > 0)
            {
                // this if checks if the payout value and studentid isn't empty
                if (payout.Text != string.Empty && studentID.Text != string.Empty)
                {


                    //this if will try if the payout is greater than 0 or if its a number
                    if (Double.TryParse(payout.Text, out double result) && Double.Parse(payout.Text) > 0)
                    {


















                        double Payout = double.Parse(payout.Text);

                        con.Open();

                        double ParsedTotalCosts;

                        ParsedTotalCosts = Double.Parse(totalcost.Text);


                        // this if checks if Payout Value is greater than the tuition fee
                        if (Payout > ParsedTotalCosts)
                        {
                            double Total = Payout - ParsedTotalCosts;


                            DialogResult dialogResult = MessageBox.Show("Is the Student asking Change?", "Overpayment Detected!", MessageBoxButtons.YesNo);


                            // this if checks if student wants the change or not
                            if (dialogResult == DialogResult.Yes)
                            {
                                MessageBox.Show
                                ("Overpaid: Please return this amount of Change: "
                                 + Total
                                 );


                                totalcost.Text = "0";


                                Commando = con.CreateCommand();
                                Commando.CommandText = "UPDATE StudentInfo SET"
                                + " SubjectCosts = '" + totalcost.Text + "',"
                                + " ExtraCosts = '" + totalcost.Text + "',"
                                + " TotalCost = '" + totalcost.Text + "'"
                                 + " WHERE ID = " + studentID.Text;
                                Commando.ExecuteNonQuery();
                                Commando.Dispose();

                            }
                            else
                            {


                                MessageBox.Show
                             ("This amount of Money has been stored into their account: "
                              + Total
                              );

                                totalcost.Text = "0";



                                Commando = con.CreateCommand();
                                Commando.CommandText = "UPDATE StudentInfo SET"
                                + " SubjectCosts = '" + totalcost.Text + "',"
                                + " ExtraCosts = '" + totalcost.Text + "',"
                                + " TotalCost = '" + totalcost.Text + "',"
                                 + " Cash = '" + Total.ToString() + "'"
                                 + " WHERE ID = " + studentID.Text;
                                Commando.ExecuteNonQuery();
                                Commando.Dispose();

                            }




                        }

                        // this check if tuition fee is the same as payout amount
                        else if (Payout == ParsedTotalCosts)
                        {
                            double Total = Payout - ParsedTotalCosts;
                            MessageBox.Show
                              ("Payment Succesfull"

                               );

                            totalcost.Text = "0";




                            Commando = con.CreateCommand();
                            Commando.CommandText = "UPDATE StudentInfo SET"
                            + " SubjectCosts = '" + totalcost.Text + "',"
                            + " ExtraCosts = '" + totalcost.Text + "',"
                            + " TotalCost = '" + totalcost.Text + "',"
                            + " Cash = '" + totalcost.Text + "'"
                             + " WHERE ID = " + studentID.Text;
                            Commando.ExecuteNonQuery();
                            Commando.Dispose();
















                        }
                        //this check if payout is less than tuition fee
                        else if (Payout < ParsedTotalCosts)
                        {
                            double Total = ParsedTotalCosts - Payout;
                            MessageBox.Show
                              ("Remaining Balance: " +
                                Total
                               );

                            totalcost.Text = Total.ToString();

                            Commando = con.CreateCommand();
                            Commando.CommandText = "UPDATE StudentInfo SET"
                            + " SubjectCosts = '" + totalcost.Text + "',"
                            + " ExtraCosts = '" + totalcost.Text + "',"
                            + " TotalCost = '" + totalcost.Text + "',"
                            + " Cash = '" + "0" + "'"
                             + " WHERE ID = " + studentID.Text;
                            Commando.ExecuteNonQuery();
                            Commando.Dispose();

                        }















                        con.Close();





                    }
                    else
                    {

                        //this check if the payout is a number and higher than 0
                        if (Double.TryParse(payout.Text, out double resulst) && Double.Parse(payout.Text) > 0)
                        {
                            // this check if payout is actually 0
                            if (Double.Parse(payout.Text) == 0)
                            {
                                MessageBox.Show("Student Paid for Nothing, No Changes were made.");

                            }
                            else
                            {

                                MessageBox.Show("Please Input Things Properly.");

                            }
                        }
                        else
                        {

                            MessageBox.Show("Please Input Things Properly.");


                        }


                    }




                }
                else
                {

                    // this check if ID is present or not
                    if (studentID.Text == string.Empty)
                    {
                        MessageBox.Show("Please check Student ID if it has anything.");

                    }
                    else
                    {
                        MessageBox.Show("Must Enter Amount to pay.");

                    }



                }

                reload();
            }
            else
            {
                MessageBox.Show("There's nothing to pay to.");



            }













        }
    }
}
