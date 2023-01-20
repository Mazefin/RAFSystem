namespace RAFSystem
{
    partial class Cashier
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.Label();
            this.fn1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.payout = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.ln1 = new System.Windows.Forms.TextBox();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middlenameBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.totalcost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.ylBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Last = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.overpay = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Student ID";
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(105, 12);
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            this.studentID.Size = new System.Drawing.Size(100, 20);
            this.studentID.TabIndex = 1;
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Location = new System.Drawing.Point(13, 89);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(58, 13);
            this.ln.TabIndex = 3;
            this.ln.Text = "Last Name";
            // 
            // fn1
            // 
            this.fn1.AutoSize = true;
            this.fn1.Location = new System.Drawing.Point(16, 140);
            this.fn1.Name = "fn1";
            this.fn1.Size = new System.Drawing.Size(57, 13);
            this.fn1.TabIndex = 4;
            this.fn1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Middle Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Age";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(318, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 334);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // payout
            // 
            this.payout.Location = new System.Drawing.Point(12, 337);
            this.payout.Name = "payout";
            this.payout.Size = new System.Drawing.Size(100, 20);
            this.payout.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Amount Expected";
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(12, 377);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(111, 23);
            this.print.TabIndex = 17;
            this.print.Text = "Print Receipt";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(469, 406);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 18;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(12, 66);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.ReadOnly = true;
            this.lastnameBox.Size = new System.Drawing.Size(88, 20);
            this.lastnameBox.TabIndex = 19;
            // 
            // ln1
            // 
            this.ln1.Location = new System.Drawing.Point(8, 111);
            this.ln1.Name = "ln1";
            this.ln1.ReadOnly = true;
            this.ln1.Size = new System.Drawing.Size(88, 20);
            this.ln1.TabIndex = 19;
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(12, 117);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.ReadOnly = true;
            this.firstnameBox.Size = new System.Drawing.Size(88, 20);
            this.firstnameBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // middlenameBox
            // 
            this.middlenameBox.Location = new System.Drawing.Point(12, 184);
            this.middlenameBox.Name = "middlenameBox";
            this.middlenameBox.ReadOnly = true;
            this.middlenameBox.Size = new System.Drawing.Size(88, 20);
            this.middlenameBox.TabIndex = 21;
            // 
            // genderBox
            // 
            this.genderBox.Location = new System.Drawing.Point(155, 66);
            this.genderBox.Name = "genderBox";
            this.genderBox.ReadOnly = true;
            this.genderBox.Size = new System.Drawing.Size(88, 20);
            this.genderBox.TabIndex = 22;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(155, 117);
            this.ageBox.Name = "ageBox";
            this.ageBox.ReadOnly = true;
            this.ageBox.Size = new System.Drawing.Size(88, 20);
            this.ageBox.TabIndex = 23;
            // 
            // totalcost
            // 
            this.totalcost.Location = new System.Drawing.Point(117, 268);
            this.totalcost.Name = "totalcost";
            this.totalcost.ReadOnly = true;
            this.totalcost.Size = new System.Drawing.Size(88, 20);
            this.totalcost.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Course";
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(155, 184);
            this.courseBox.Name = "courseBox";
            this.courseBox.ReadOnly = true;
            this.courseBox.Size = new System.Drawing.Size(88, 20);
            this.courseBox.TabIndex = 26;
            // 
            // ylBox
            // 
            this.ylBox.Location = new System.Drawing.Point(456, 35);
            this.ylBox.Name = "ylBox";
            this.ylBox.ReadOnly = true;
            this.ylBox.Size = new System.Drawing.Size(88, 20);
            this.ylBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Year Level";
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(8, 111);
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            this.Last.Size = new System.Drawing.Size(88, 20);
            this.Last.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 350);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Deducted by :";
            // 
            // overpay
            // 
            this.overpay.AutoSize = true;
            this.overpay.Location = new System.Drawing.Point(150, 291);
            this.overpay.Name = "overpay";
            this.overpay.Size = new System.Drawing.Size(13, 13);
            this.overpay.TabIndex = 30;
            this.overpay.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Due to Over payment";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 454);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.overpay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ylBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalcost);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.middlenameBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.print);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.payout);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fn1);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.label1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label fn1;
        private System.Windows.Forms.TextBox payout;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox ln1;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox middlenameBox;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.TextBox ylBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Last;
        private System.Windows.Forms.TextBox totalcost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label overpay;
        private System.Windows.Forms.Label label13;
    }
}