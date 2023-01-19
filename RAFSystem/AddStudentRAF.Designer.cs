namespace RAFSystem
{
    partial class AddStudentRAF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RAF = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.stnid = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.sy = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.course = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.costs = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labprice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalprice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RAF
            // 
            this.RAF.Location = new System.Drawing.Point(305, 467);
            this.RAF.Name = "RAF";
            this.RAF.Size = new System.Drawing.Size(75, 23);
            this.RAF.TabIndex = 0;
            this.RAF.Text = "Add Student";
            this.RAF.UseVisualStyleBackColor = true;
            this.RAF.Click += new System.EventHandler(this.RAF_Click);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(90, 72);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 1;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(90, 111);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 2;
            // 
            // stnid
            // 
            this.stnid.Location = new System.Drawing.Point(90, 29);
            this.stnid.Name = "stnid";
            this.stnid.Size = new System.Drawing.Size(100, 20);
            this.stnid.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 160);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(461, 467);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 8;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // sy
            // 
            this.sy.Location = new System.Drawing.Point(90, 180);
            this.sy.Name = "sy";
            this.sy.Size = new System.Drawing.Size(100, 20);
            this.sy.TabIndex = 10;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(90, 218);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "School Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gender";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(90, 257);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 20);
            this.gender.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(305, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 300);
            this.listView1.TabIndex = 16;
            this.listView1.TileSize = new System.Drawing.Size(136, 20);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(90, 296);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(100, 20);
            this.course.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Unit Cost:";
            // 
            // costs
            // 
            this.costs.AutoSize = true;
            this.costs.Location = new System.Drawing.Point(462, 353);
            this.costs.Name = "costs";
            this.costs.Size = new System.Drawing.Size(28, 13);
            this.costs.TabIndex = 20;
            this.costs.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Extra Expenses:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "_____________________________";
            // 
            // labprice
            // 
            this.labprice.AutoSize = true;
            this.labprice.Location = new System.Drawing.Point(462, 381);
            this.labprice.Name = "labprice";
            this.labprice.Size = new System.Drawing.Size(28, 13);
            this.labprice.TabIndex = 23;
            this.labprice.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Overall Unit Cost:";
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.Location = new System.Drawing.Point(462, 418);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(28, 13);
            this.totalprice.TabIndex = 25;
            this.totalprice.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Middle Name";
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(90, 145);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(100, 20);
            this.middleName.TabIndex = 27;
            // 
            // AddStudentRAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 502);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labprice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.costs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.course);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sy);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.stnid);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.RAF);
            this.Name = "AddStudentRAF";
            this.Text = "AddStudentRAF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RAF;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox stnid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox sy;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label costs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox middleName;
    }
}