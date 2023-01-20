namespace RAFSystem
{
    partial class Registrar
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
            this.griddata = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.delraf = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.reloadgrid = new System.Windows.Forms.Button();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.griddata)).BeginInit();
            this.SuspendLayout();
            // 
            // griddata
            // 
            this.griddata.AllowUserToAddRows = false;
            this.griddata.AllowUserToDeleteRows = false;
            this.griddata.AllowUserToResizeColumns = false;
            this.griddata.AllowUserToResizeRows = false;
            this.griddata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.griddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddata.ColumnHeadersVisible = false;
            this.griddata.Location = new System.Drawing.Point(119, 33);
            this.griddata.MultiSelect = false;
            this.griddata.Name = "griddata";
            this.griddata.ReadOnly = true;
            this.griddata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.griddata.Size = new System.Drawing.Size(414, 346);
            this.griddata.TabIndex = 0;
            this.griddata.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddata_CellContentDoubleClick);
            this.griddata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddata_CellDoubleClick);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(22, 74);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add RAF";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delraf
            // 
            this.delraf.Location = new System.Drawing.Point(22, 356);
            this.delraf.Name = "delraf";
            this.delraf.Size = new System.Drawing.Size(75, 23);
            this.delraf.TabIndex = 3;
            this.delraf.Text = "Delete RAF";
            this.delraf.UseVisualStyleBackColor = true;
            this.delraf.Click += new System.EventHandler(this.delraf_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(458, 385);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // reloadgrid
            // 
            this.reloadgrid.Location = new System.Drawing.Point(23, 128);
            this.reloadgrid.Name = "reloadgrid";
            this.reloadgrid.Size = new System.Drawing.Size(75, 23);
            this.reloadgrid.TabIndex = 5;
            this.reloadgrid.Text = "Refresh";
            this.reloadgrid.UseVisualStyleBackColor = true;
            this.reloadgrid.Click += new System.EventHandler(this.reloadgrid_Click);
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(12, 33);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(101, 21);
            this.combo.TabIndex = 6;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student ID List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "STUDENT ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Course";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 420);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.reloadgrid);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.delraf);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.griddata);
            this.Name = "Registrar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button delraf;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button reloadgrid;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView griddata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}