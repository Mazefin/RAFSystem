using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using System.Globalization;
using System.Net.Http.Headers;

namespace RAFSystem
{
    public partial class AddStudentRAF : Form
    {
        // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseInfo.mdf;Integrated Security=True");

        SqlConnection con = new SqlConnection(publicstuff.con1);



        SqlCommand Commando;
        SqlDataReader DataReaders;
        SqlDataAdapter DataAdept;
        public AddStudentRAF()
        {
            InitializeComponent();
            con.Open();
            string[] Subject = listBox1.Items.OfType<string>().ToArray();






            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SubjectID,Subjects from Subject", con);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Subjects";
                listBox1.ValueMember = "SubjectID";



            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                con.Close();
            }

        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void RAF_Click(object sender, EventArgs e)
        {






            // Standard Open

            if
            (
                stnid.Text == "" ||
                firstname.Text == "" ||
                lastname.Text == "" ||
                course.Text == "" ||
                sy.Text == "" ||
                age.Text == "" ||
                gender.Text == "" ||
                middleName.Text == ""


            )
            {
                MessageBox.Show("Please Fill the Form Properly.");



            }
            else
            {

               

               if (
                     Int32.TryParse(age.Text, out int result) == true &&
                       result > 0 &&
                       Int32.TryParse(stnid.Text, out int results) == true &&
                       results > 0

                    ) 
                { 

                        Commando = new SqlCommand("SELECT * FROM StudentInfo WHERE ID='" + stnid.Text + "'", con);
                    DataAdept = new SqlDataAdapter(Commando);
                    DataTable dt = new DataTable();
                    DataAdept.Fill(dt);

                    if (dt.Rows.Count >= 1) {

                        MessageBox.Show("ID already existed.");

                    }
                    else
                    {


                        con.Open();




                        // These add Student's Identification
                        String TempID = stnid.Text;
                        String TFirstName = firstname.Text;
                        String TLastName = lastname.Text;
                        String TCourse = course.Text;
                        String SchoolYear = sy.Text;
                        String Age = age.Text;
                        String Gender = gender.Text;
                        String SubjectCosts = costs.Text;
                        String ExtraCosts = labprice.Text;
                        String TotalCosts = totalprice.Text;
                        String MiddleName = middleName.Text;


                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT INTO StudentInfo VALUES ('"
                            + TempID
                            + "','" + TFirstName
                            + "','" + TLastName
                            + "','" + TCourse
                            + "','" + SchoolYear
                            + "','" + Age
                            + "','" + Gender
                            + "','" + SubjectCosts
                            + "','" + ExtraCosts
                            + "','" + TotalCosts
                            + "','" + MiddleName
                            + "','" + "Null"
                            +
                            "')";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("New record added to Student table");








                        // ---------------------------------------


                        // These add Subject with the basis of the Student's ID

                        SqlCommand cmd1 = con.CreateCommand();
                        for (int i = 0; i <= listView1.Items.Count - 1; i++)
                        {

                            cmd1.CommandText = "INSERT INTO StudentInfoFull(StudentID, Subject) VALUES ('"
                           + TempID
                           + "','" + listView1.Items[i].SubItems[0].Text
                           + "')";

                            cmd1.ExecuteNonQuery();
                        }


                        // -----------------------------------------



                        // Standard Close 
                        con.Close();


                    }

                }
                else
                {
                    MessageBox.Show("Either Age, Student ID or Both isn't Integers or they are in the Invalid Spectrum");



                }

            }



            stnid.Clear();
            firstname.Clear();
            lastname.Clear();
            course.Clear();
            sy.Clear();
            age.Clear();
            gender.Clear();
            costs.Text = "0.00";
            labprice.Text = "0.00";
            totalprice.Text = "0.00";

            listView1.Items.Clear();



        }

        
   


        // Honestly I forgot what this is suppose to be
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Registrar Reg = new Registrar();
            Reg.Show();
            this.Close();
        }
        // ----------------

        // and what ever this variable is jk, I just remembered its used for Costs
        public int Cost;
        // ---------------------
       

        // Add Subject and Check and Increase Costs

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            String Selected = listBox1.Text;

            ListViewItem item = listView1.FindItemWithText(Selected);
                

                if (item == null)
                {


                    listView1.Items.Add(Selected);
                    



                 if(

                         Selected.Equals("Computer 1") ||
                         Selected.Equals("Keyboards 1") ||
                         Selected.Equals("Color Theory Lab") ||
                         Selected.Equals("Writing New Media") ||
                         Selected.Equals("Technical Writing") ||
                         Selected.Equals("Spears!") ||
                         Selected.Equals("Mathematics of Modern World") ||
                         Selected.Equals("Guns!") ||
                         Selected.Equals("More of Philantrophy") ||
                         Selected.Equals("Introduction to Basics") ||
                         Selected.Equals("Principles of Intermediate") ||
                         Selected.Equals("Class 101") ||
                         Selected.Equals("Reading?") ||
                         Selected.Equals("How Thesis?") ||
                         Selected.Equals("Ladders!")
                )
                {
                        double tempClaus = 1000.00;

                        double Costs = Double.Parse(labprice.Text);

                        double Result = tempClaus + Costs;

                        

                         labprice.Text = Result.ToString();

                        


                 }




                if (

                    Selected.Equals("Ethics") ||
                    Selected.Equals("Math in 1960s") ||
                    Selected.Equals("Art Appreciation") ||
                    Selected.Equals("Drawing 1 Lec") ||
                    Selected.Equals("Art Philippine History") ||
                    Selected.Equals("Color Theory Lec") ||
                    Selected.Equals("Drawing 2 Lec") ||
                    Selected.Equals("Art Appreciate") ||
                    Selected.Equals("Mathematics of Cavemen") ||
                    Selected.Equals("History of Rocks") ||
                    Selected.Equals("Introduction to Philantrophy") ||
                    Selected.Equals("History of Stones") ||
                    Selected.Equals("History of Something") ||
                    Selected.Equals("Learning!") ||
                    Selected.Equals("Studyology") ||
                    Selected.Equals("Theoretical Phys Ed") ||
                    Selected.Equals("Math 1-2-3") ||
                    Selected.Equals("Simplified Chinese") ||
                    Selected.Equals("Nominal Ascertainment") ||
                    Selected.Equals("Canned Response Parenthesis") ||
                    Selected.Equals("Applied Thesis") ||
                    Selected.Equals("How to Graduate") ||


                     Selected.Equals("Computer 1") ||
                     Selected.Equals("Keyboards 1") ||
                     Selected.Equals("Color Theory Lab") ||
                     Selected.Equals("Writing New Media") ||
                     Selected.Equals("Technical Writing") ||
                     Selected.Equals("Spears!") ||
                     Selected.Equals("Mathematics of Modern World") ||
                     Selected.Equals("Guns!") ||
                     Selected.Equals("More of Philantrophy") ||
                     Selected.Equals("Introduction to Basics") ||
                     Selected.Equals("Principles of Intermediate") ||
                     Selected.Equals("Class 101") ||
                     Selected.Equals("Reading?") ||
                     Selected.Equals("How Thesis?") ||
                     Selected.Equals("Ladders!")

                )
                {
                    float Costs = float.Parse(costs.Text, CultureInfo.InvariantCulture.NumberFormat);
                    float LabPrice = float.Parse(labprice.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double tempClaus = 350.00;


                    double Result = Costs + tempClaus;
                    costs.Text = Result.ToString();







                    double OverResult = Result + LabPrice;

                    totalprice.Text = OverResult.ToString();



                }




            }
                else
                {
                    MessageBox.Show("You've already Selected this Subject.", "Error?", MessageBoxButtons.OK);

                }


            


           





        }
        // ------------------

        // Removes Subject and Check and Reduce Costs
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String Selected = listView1.SelectedItems[0].Text;
            listView1.SelectedItems[0].Remove();



            if (

                 Selected.Equals("Computer 1") ||
                 Selected.Equals("Keyboards 1") ||
                 Selected.Equals("Color Theory Lab") ||
                 Selected.Equals("Writing New Media") ||
                 Selected.Equals("Technical Writing") ||
                 Selected.Equals("Spears!") ||
                 Selected.Equals("Mathematics of Modern World") ||
                 Selected.Equals("Guns!") ||
                 Selected.Equals("More of Philantrophy") ||
                 Selected.Equals("Introduction to Basics") ||
                 Selected.Equals("Principles of Intermediate") ||
                 Selected.Equals("Class 101") ||
                 Selected.Equals("Reading?") ||
                 Selected.Equals("How Thesis?") ||
                 Selected.Equals("Ladders!")
            )
            {
                double tempClaus = 1000.00;

                double Costs = Double.Parse(labprice.Text);

                double Result = Costs - tempClaus;

                labprice.Text = Result.ToString();




            }





            if (

                    Selected.Equals("Ethics") ||
                    Selected.Equals("Math in 1960s") ||
                    Selected.Equals("Art Appreciation") ||
                    Selected.Equals("Drawing 1 Lec") ||
                    Selected.Equals("Art Philippine History") ||
                    Selected.Equals("Color Theory Lec") ||
                    Selected.Equals("Drawing 2 Lec") ||
                    Selected.Equals("Art Appreciate") ||
                    Selected.Equals("Mathematics of Cavemen") ||
                    Selected.Equals("History of Rocks") ||
                    Selected.Equals("Introduction to Philantrophy") ||
                    Selected.Equals("History of Stones") ||
                    Selected.Equals("History of Something") ||
                    Selected.Equals("Learning!") ||
                    Selected.Equals("Studyology") ||
                    Selected.Equals("Theoretical Phys Ed") ||
                    Selected.Equals("Math 1-2-3") ||
                    Selected.Equals("Simplified Chinese") ||
                    Selected.Equals("Nominal Ascertainment") ||
                    Selected.Equals("Canned Response Parenthesis") ||
                    Selected.Equals("Applied Thesis") ||
                    Selected.Equals("How to Graduate") ||


                     Selected.Equals("Computer 1") ||
                     Selected.Equals("Keyboards 1") ||
                     Selected.Equals("Color Theory Lab") ||
                     Selected.Equals("Writing New Media") ||
                     Selected.Equals("Technical Writing") ||
                     Selected.Equals("Spears!") ||
                     Selected.Equals("Mathematics of Modern World") ||
                     Selected.Equals("Guns!") ||
                     Selected.Equals("More of Philantrophy") ||
                     Selected.Equals("Introduction to Basics") ||
                     Selected.Equals("Principles of Intermediate") ||
                     Selected.Equals("Class 101") ||
                     Selected.Equals("Reading?") ||
                     Selected.Equals("How Thesis?") ||
                     Selected.Equals("Ladders!")

                )
            {
                double tempClaus = 350.00;

                
                double LabPrice = Double.Parse(labprice.Text);
                double Costs = Double.Parse(costs.Text);



                double Result = Costs - tempClaus;

                costs.Text = Result.ToString();


              


                double OverResult = Result + LabPrice;

                totalprice.Text = OverResult.ToString();



            }



        }
        // ------------------
    }
}
