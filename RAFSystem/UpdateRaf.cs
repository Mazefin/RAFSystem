using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RAFSystem
{
    public partial class UpdateRaf : Form
    {

        public Form1 FRM1 { get; set; }


        SqlConnection con = new SqlConnection(publicstuff.con1);


        SqlCommand Commando;
        SqlDataReader DataReaders;


        public Registrar Registrars { get; set; }

        public static UpdateRaf raf;
        public static UpdateRaf getRaf{
            get
            {
                if (raf == null)
                {
                    raf = new UpdateRaf();

                }
                return raf;
            }


        }


        
        

        public UpdateRaf(Registrar Regi)
        {
            InitializeComponent();
           

            

        }

        private void tableLoad()
        {

            con.Open();

                SqlCommand cmd = new SqlCommand("SELECT SubjectID,Subjects from Subject", con);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Subjects";
                listBox1.ValueMember = "SubjectID";






            //  SqlCommand filter = new SqlCommand("Select Subjects,Courses,SchoolYear FROM Subject WHERE Courses like '%" + course.Text + "'", con);


            //  SqlCommand filter = new SqlCommand("Select Subjects,Courses,SchoolYear FROM Subject WHERE Courses='" + course.Text + "' AND SchoolYear='" + sy.Text + "';", con);

            //

          

            //  -------

            // This adds Subjects to the ListView

            SqlCommand filter = new SqlCommand("Select Subject FROM StudentInfoFull WHERE StudentID =@id", con);
            filter.Parameters.AddWithValue("@id", id.Text);

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
            //------------------

        }


        public UpdateRaf()
        {
        }


        // Update Button, Update Selected Student File
        private void button2_Click(object sender, EventArgs e)
        {
           
            // Initialise Strings to set as Text for later.
            String
                StID,
                FirstName,
                LastName,
                Course,
                SchoolYear,
                Age,
                Gender,
                SubjectCost,
                ExtraCost,
                TotalCosts,
                MiddleName;
                


            StID = id.Text;
            FirstName = firstname.Text;
            LastName = lastname.Text;
            Course = course.Text;
            SchoolYear = sy.Text;
            Age = age.Text;
            Gender = gender.Text;
            SubjectCost = subjectcosts.Text;
            ExtraCost = labprice.Text;
            TotalCosts = totalprice.Text;
            MiddleName = middleName.Text;

            //--------------


            // These Section Updates and Replaces your ID and Subjects

            if (
                  Int32.TryParse(Age, out int result) == true &&
                       result > 0 

                )
            {

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "UPDATE StudentInfo SET"
                            + " FirstName = '" + FirstName + "',"
                            + " LastName =  '" + LastName + "',"
                            + " Course = '" + Course + "',"
                            + " SchoolYears = '" + SchoolYear + "',"
                            + " Age = '" + Age + "',"
                            + " Gender = '" + Gender + "',"
                            + " SubjectCosts = '" + SubjectCost + "',"
                            + " ExtraCosts = '" + ExtraCost + "',"
                            + " TotalCost = '" + TotalCosts + "',"
                            + " MiddleName = '" + MiddleName + "'"
                            + " WHERE ID = " + StID;

                        cmd.ExecuteNonQuery();


                        cmd.CommandText = "DELETE FROM StudentInfoFull WHERE StudentID = "
                                   + StID;

                        cmd.ExecuteNonQuery();

                        con.Close();


                        con.Open();

                        SqlCommand cmd1 = con.CreateCommand();
                        for (int i = 0; i <= listView1.Items.Count - 1; i++)
                        {

                            cmd1.CommandText = "INSERT INTO StudentInfoFull(StudentID, Subject) VALUES ('"
                           + StID
                           + "','" + listView1.Items[i].SubItems[0].Text
                           + "')";

                            cmd1.ExecuteNonQuery();
                        }




                        MessageBox.Show("Student Record Updated");

                        con.Close();




            }
            else
            {

                MessageBox.Show("Either Age, Student ID or Both isn't Integers or they are in the Invalid Spectrum");



            }
            // ------------













        }

        //-------------------

        private void UpdateRaf_Load(object sender, EventArgs e)
        {



                id.Text = Registrar.selectedrow.Cells[0].Value.ToString();
                firstname.Text = Registrar.selectedrow.Cells[1].Value.ToString();
                lastname.Text = Registrar.selectedrow.Cells[2].Value.ToString();
                course.Text = Registrar.selectedrow.Cells[3].Value.ToString();
                sy.Text = Registrar.selectedrow.Cells[4].Value.ToString();
                age.Text = Registrar.selectedrow.Cells[5].Value.ToString();
                gender.Text = Registrar.selectedrow.Cells[6].Value.ToString();



                subjectcosts.Text = Registrar.selectedrow.Cells[7].Value.ToString();
                labprice.Text = Registrar.selectedrow.Cells[8].Value.ToString();
                totalprice.Text = Registrar.selectedrow.Cells[9].Value.ToString();


                middleName.Text = Registrar.selectedrow.Cells[10].Value.ToString();

                listView1.GridLines = true;
                listView1.View = View.Details;

                listView1.Columns.Add("Subject", 150);




                //


                combo.Items.Clear();




                string sql = "SELECT * FROM StudentInfo";
                Commando = new SqlCommand(sql, con);
                con.Open();

                DataReaders = Commando.ExecuteReader();
                while (DataReaders.Read())
                {
                    combo.Items.Add(DataReaders["ID"]);

                }

                con.Close();




                //---------











                tableLoad();
            
         
            

            
        }

        private void course_TextChanged(object sender, EventArgs e)
        {

        }

        public int costs;




        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            String Selected = listBox1.Text;

             ListViewItem item = listView1.FindItemWithText(Selected);
           


            if (item == null)
            {


                listView1.Items.Add(Selected);
             
               

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
                    int tempClaus = 1000;

                    double Costs = Double.Parse(labprice.Text);

                    double Result = Costs + tempClaus;

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
                    int tempClaus = 350;

                    double Costs = Double.Parse(subjectcosts.Text);
                    double LabPrice = Double.Parse(labprice.Text);


                    double Result = Costs + tempClaus;

                    subjectcosts.Text = Result.ToString();



                    double OverResult = Result + LabPrice;

                    totalprice.Text = OverResult.ToString();


                }




            }
            else
            {
                MessageBox.Show("You've already Selected this Subject.", "Error?", MessageBoxButtons.OK);

            }












        }

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
                int tempClaus = 1000;

                double Costs = Double.Parse(labprice.Text);

                if (Double.Parse(labprice.Text) > 0) {
                    double Result = Costs - tempClaus;



                    labprice.Text = Result.ToString();

                }


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
                int tempClaus = 350;

                double LabPrice = Double.Parse(labprice.Text);
                double Costs = Double.Parse(subjectcosts.Text);


                if (Costs > 0)
                {   

                    double Result = Costs - tempClaus;

                    

                    subjectcosts.Text = Result.ToString();


                    double OverResult = Result + LabPrice;

                    totalprice.Text = OverResult.ToString();
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar Reg = new Registrar();
            Reg.Show();
            this.Close();
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            String TempItem = combo.GetItemText(combo.SelectedItem);
            


            if (!TempItem.Equals("800000")) {


                Commando = new SqlCommand("SELECT * FROM StudentInfo WHERE ID=@ids", con);
                Commando.Parameters.AddWithValue("@ids", TempItem);
                con.Open();

                DataReaders = Commando.ExecuteReader();

                while (DataReaders.Read())
                {

                    String ID = DataReaders["ID"].ToString();
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


                    id.Text = ID;
                    firstname.Text = FirstName;
                    lastname.Text = LastName;
                    course.Text = Course;
                    sy.Text = SchoolYears;
                    age.Text = Age;
                    gender.Text = Gender;
                    subjectcosts.Text = SubjectCost;
                    labprice.Text = ExtraCost;
                    totalprice.Text = TotalCosts;
                    middleName.Text = MiddleName;

                }


                DataReaders.Close();
              

                con.Close();

                tableLoad();
               

                //-----------------













            }
            else
            {

                MessageBox.Show("Cannot Alter that Information.");


            }








        }

        private void printraf_Click(object sender, EventArgs e)
        {

            MessageBox.Show("RAF Printed");


            String fileName = id.Text + "RAF"+ ".pdf";
           

            string[] output1 =
           {
                " [BASIC RAF] ",

                "[Student ID]: " + id.Text + " ",
                "[First Name]: " + firstname.Text + " ",
                "[Middle Name]: " + middleName.Text + " ",
                "[Last Name]: " + lastname.Text + " ",
                "[Gender]: " + gender.Text + " ",
                "[Course]: " + course.Text + " ",


            };



            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
            PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
            doc.Open();


            for (int i = 0; i < output1.Length; i++)
            {
                doc.Add(new iTextSharp.text.Paragraph(output1[i]));
            }

            ListViewItem[] items = new ListViewItem[listView1.Items.Count];
            listView1.Items.CopyTo(items, 0);

            for (int i = 0; i < items.Length; i++)
            {

                doc.Add(new iTextSharp.text.Paragraph(items[i].Text.ToString()));
            }
            doc.Close();





        }
    }
}
