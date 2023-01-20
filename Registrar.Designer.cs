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
            this.griddata.BackgroundColor = System.Drawing.Color.Linen;
            this.griddata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.griddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddata.ColumnHeadersVisible = false;
            this.griddata.Location = new System.Drawing.Point(139, 38);
            this.griddata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.griddata.MultiSelect = false;
            this.griddata.Name = "griddata";
            this.griddata.ReadOnly = true;
            this.griddata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.griddata.Size = new System.Drawing.Size(483, 399);
            this.griddata.TabIndex = 0;
            this.griddata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddata_CellContentClick);
            this.griddata.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddata_CellContentDoubleClick);
            this.griddata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddata_CellDoubleClick);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DarkGray;
            this.addbtn.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(26, 85);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(88, 27);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add RAF";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delraf
            // 
            this.delraf.BackColor = System.Drawing.Color.DarkGray;
            this.delraf.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delraf.Location = new System.Drawing.Point(26, 411);
            this.delraf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delraf.Name = "delraf";
            this.delraf.Size = new System.Drawing.Size(88, 27);
            this.delraf.TabIndex = 3;
            this.delraf.Text = "Delete RAF";
            this.delraf.UseVisualStyleBackColor = false;
            this.delraf.Click += new System.EventHandler(this.delraf_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.DarkGray;
            this.logout.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(534, 444);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(88, 27);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // reloadgrid
            // 
            this.reloadgrid.BackColor = System.Drawing.Color.DarkGray;
            this.reloadgrid.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadgrid.Location = new System.Drawing.Point(27, 148);
            this.reloadgrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reloadgrid.Name = "reloadgrid";
            this.reloadgrid.Size = new System.Drawing.Size(88, 27);
            this.reloadgrid.TabIndex = 5;
            this.reloadgrid.Text = "Refresh";
            this.reloadgrid.UseVisualStyleBackColor = false;
            this.reloadgrid.Click += new System.EventHandler(this.reloadgrid_Click);
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(14, 38);
            this.combo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(117, 23);
            this.combo.TabIndex = 6;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student ID List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "STUDENT ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Course";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(650, 485);
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
            this.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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