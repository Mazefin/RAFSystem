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
    public partial class Registrar : Form
    {
        // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseInfo.mdf;Integrated Security=True");
        // SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\AL\\source\\repos\\RAFSystem\\RAFSystem\\DatabaseInfo.mdf;Integrated Security=True");


        SqlConnection con = new SqlConnection(publicstuff.con1);



        SqlCommand Commando;
        SqlDataReader DataReaders;

        public static Registrar instance;




        public Registrar()
        {
            InitializeComponent();

            con.Open();
            //  SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StudentInfo", SqlCon);

            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM StudentInfo", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            griddata.DataSource = dtbl;
            instance = this;




            con.Close();




        }



        private void addbtn_Click(object sender, EventArgs e)
        {
            AddStudentRAF ASR = new AddStudentRAF();
            this.Close();
            ASR.Show();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {


          

            var index = Convert.ToInt32(griddata.CurrentRow.Cells[0].Value);
                String Conversion = index.ToString();

                con.Open();

                if (Conversion != "800000")
                {



                    UpdateRaf RAF = new UpdateRaf(this);
                    RAF.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cannot Edit That RAF");

                }

                con.Close();

           





            

        }

        public static DataGridViewRow selectedrow;

        private void reloadgrid_Click(object sender, EventArgs e)
        {

            LoadGridView();


        }

        private void LoadGridView()
        {

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM StudentInfo";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            griddata.DataSource = dt;
         



            con.Close();
        }

        private void delraf_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to stop this Student from Existing?", "Delete Student", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                var index = Convert.ToInt32(griddata.CurrentRow.Cells[0].Value);
                String Conversion = index.ToString();

                con.Open();

                if (Conversion != "800000")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM StudentInfo WHERE ID = "
                        + Conversion;
                    cmd.ExecuteNonQuery();

                    combo.Items.Remove(Conversion);

                    cmd.CommandText = "DELETE FROM StudentInfoFull WHERE StudentID = "
                        + Conversion;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Cannot Remove Form 800000");

                }

                con.Close();
                MessageBox.Show("Selected Student has been deleted successfully.");

                LoadGridView();
            }
            else
            {
                MessageBox.Show("Selected Student remained.");
                //do something else
            }




        }

      


        private void Registrar_Load(object sender, EventArgs e)
        {
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


            LoadGridView();


        }


        private void logout_Click(object sender, EventArgs e)
        {
            Form1 FRM1 = new Form1();
            FRM1.Show();
            this.Hide();
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            String TempItem = combo.GetItemText(combo.SelectedItem);


            if (!TempItem.Equals("800000"))
            {


                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM StudentInfo WHERE ID =@ids";
                cmd.Parameters.AddWithValue("@ids", combo.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                griddata.DataSource = dt;



                con.Close();

            }
            else
            {
                MessageBox.Show("Unable to Use that one");


            }

        }

       

        private void griddata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                selectedrow = griddata.Rows[e.RowIndex];



            }



            var index = Convert.ToInt32(griddata.CurrentRow.Cells[0].Value);
            String Conversion = index.ToString();

            con.Open();

            if (Conversion != "800000")
            {



                UpdateRaf RAF = new UpdateRaf(this);
                RAF.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Cannot Edit That RAF");

            }

            con.Close();
        }

        private void griddata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                selectedrow = griddata.Rows[e.RowIndex];



            }



            var index = Convert.ToInt32(griddata.CurrentRow.Cells[0].Value);
            String Conversion = index.ToString();

            con.Open();

            if (Conversion != "800000")
            {



                UpdateRaf RAF = new UpdateRaf(this);
                RAF.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Cannot Edit That RAF");

            }

            con.Close();
        }
    }
}

