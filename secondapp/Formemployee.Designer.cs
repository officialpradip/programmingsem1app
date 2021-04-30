namespace secondapp
{
    partial class Formemployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvbreset = new System.Windows.Forms.Label();
            this.searchtxtbymobile = new System.Windows.Forms.TextBox();
            this.searchtxtbyname = new System.Windows.Forms.TextBox();
            this.lvbsearchbymobile = new System.Windows.Forms.Label();
            this.lvbsearchbyname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvbemployeesearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.isadmintxt = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.departmenttxtcombo = new System.Windows.Forms.ComboBox();
            this.designationtxtbox = new System.Windows.Forms.ComboBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.employetxtid = new System.Windows.Forms.TextBox();
            this.lvbisadmin = new System.Windows.Forms.Label();
            this.lvbpassword = new System.Windows.Forms.Label();
            this.lvbusername = new System.Windows.Forms.Label();
            this.lvbemail = new System.Windows.Forms.Label();
            this.lvbmobileno = new System.Windows.Forms.Label();
            this.lvbaddress = new System.Windows.Forms.Label();
            this.lvbdob = new System.Windows.Forms.Label();
            this.lvbdepartment = new System.Windows.Forms.Label();
            this.lvbdesignation = new System.Windows.Forms.Label();
            this.lvbame = new System.Windows.Forms.Label();
            this.lvbemployeeid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvbreset);
            this.panel1.Controls.Add(this.searchtxtbymobile);
            this.panel1.Controls.Add(this.searchtxtbyname);
            this.panel1.Controls.Add(this.lvbsearchbymobile);
            this.panel1.Controls.Add(this.lvbsearchbyname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 67);
            this.panel1.TabIndex = 0;
            // 
            // lvbreset
            // 
            this.lvbreset.AutoSize = true;
            this.lvbreset.Location = new System.Drawing.Point(995, 20);
            this.lvbreset.Name = "lvbreset";
            this.lvbreset.Size = new System.Drawing.Size(35, 13);
            this.lvbreset.TabIndex = 5;
            this.lvbreset.Text = "Reset";
            // 
            // searchtxtbymobile
            // 
            this.searchtxtbymobile.Location = new System.Drawing.Point(837, 21);
            this.searchtxtbymobile.Name = "searchtxtbymobile";
            this.searchtxtbymobile.Size = new System.Drawing.Size(87, 20);
            this.searchtxtbymobile.TabIndex = 4;
            this.searchtxtbymobile.TextChanged += new System.EventHandler(this.searchtxtbymobile_TextChanged);
            // 
            // searchtxtbyname
            // 
            this.searchtxtbyname.Location = new System.Drawing.Point(434, 24);
            this.searchtxtbyname.Name = "searchtxtbyname";
            this.searchtxtbyname.Size = new System.Drawing.Size(133, 20);
            this.searchtxtbyname.TabIndex = 3;
            // 
            // lvbsearchbymobile
            // 
            this.lvbsearchbymobile.AutoSize = true;
            this.lvbsearchbymobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbsearchbymobile.Location = new System.Drawing.Point(664, 18);
            this.lvbsearchbymobile.Name = "lvbsearchbymobile";
            this.lvbsearchbymobile.Size = new System.Drawing.Size(130, 20);
            this.lvbsearchbymobile.TabIndex = 2;
            this.lvbsearchbymobile.Text = "Search by Mobile";
            this.lvbsearchbymobile.Click += new System.EventHandler(this.lvbsearchbymobile_Click);
            // 
            // lvbsearchbyname
            // 
            this.lvbsearchbyname.AutoSize = true;
            this.lvbsearchbyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbsearchbyname.Location = new System.Drawing.Point(283, 22);
            this.lvbsearchbyname.Name = "lvbsearchbyname";
            this.lvbsearchbyname.Size = new System.Drawing.Size(126, 20);
            this.lvbsearchbyname.TabIndex = 1;
            this.lvbsearchbyname.Text = "Search by Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvbemployeesearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 67);
            this.panel2.TabIndex = 0;
            // 
            // lvbemployeesearch
            // 
            this.lvbemployeesearch.AutoSize = true;
            this.lvbemployeesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbemployeesearch.Location = new System.Drawing.Point(19, 21);
            this.lvbemployeesearch.Name = "lvbemployeesearch";
            this.lvbemployeesearch.Size = new System.Drawing.Size(196, 25);
            this.lvbemployeesearch.TabIndex = 0;
            this.lvbemployeesearch.Text = "Employee Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(10, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Designation";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Department";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dob";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mobile No.";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.isadmintxt);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.txtmobile);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.departmenttxtcombo);
            this.groupBox2.Controls.Add(this.designationtxtbox);
            this.groupBox2.Controls.Add(this.nametxt);
            this.groupBox2.Controls.Add(this.employetxtid);
            this.groupBox2.Controls.Add(this.lvbisadmin);
            this.groupBox2.Controls.Add(this.lvbpassword);
            this.groupBox2.Controls.Add(this.lvbusername);
            this.groupBox2.Controls.Add(this.lvbemail);
            this.groupBox2.Controls.Add(this.lvbmobileno);
            this.groupBox2.Controls.Add(this.lvbaddress);
            this.groupBox2.Controls.Add(this.lvbdob);
            this.groupBox2.Controls.Add(this.lvbdepartment);
            this.groupBox2.Controls.Add(this.lvbdesignation);
            this.groupBox2.Controls.Add(this.lvbame);
            this.groupBox2.Controls.Add(this.lvbemployeeid);
            this.groupBox2.Location = new System.Drawing.Point(875, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 435);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Entry";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(155, 371);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(77, 47);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(16, 371);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(77, 47);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(111, 240);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(101, 20);
            this.txtemail.TabIndex = 21;
            // 
            // isadmintxt
            // 
            this.isadmintxt.Location = new System.Drawing.Point(108, 325);
            this.isadmintxt.Name = "isadmintxt";
            this.isadmintxt.Size = new System.Drawing.Size(13, 20);
            this.isadmintxt.TabIndex = 20;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(106, 295);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(99, 20);
            this.txtpassword.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 269);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 18;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(110, 201);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(104, 20);
            this.txtmobile.TabIndex = 17;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(110, 177);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(104, 20);
            this.txtaddress.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // departmenttxtcombo
            // 
            this.departmenttxtcombo.FormattingEnabled = true;
            this.departmenttxtcombo.Location = new System.Drawing.Point(110, 119);
            this.departmenttxtcombo.Name = "departmenttxtcombo";
            this.departmenttxtcombo.Size = new System.Drawing.Size(102, 21);
            this.departmenttxtcombo.TabIndex = 14;
            // 
            // designationtxtbox
            // 
            this.designationtxtbox.FormattingEnabled = true;
            this.designationtxtbox.Location = new System.Drawing.Point(110, 92);
            this.designationtxtbox.Name = "designationtxtbox";
            this.designationtxtbox.Size = new System.Drawing.Size(102, 21);
            this.designationtxtbox.TabIndex = 13;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(110, 63);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(99, 20);
            this.nametxt.TabIndex = 12;
            // 
            // employetxtid
            // 
            this.employetxtid.Location = new System.Drawing.Point(110, 32);
            this.employetxtid.Name = "employetxtid";
            this.employetxtid.Size = new System.Drawing.Size(99, 20);
            this.employetxtid.TabIndex = 11;
            // 
            // lvbisadmin
            // 
            this.lvbisadmin.AutoSize = true;
            this.lvbisadmin.Location = new System.Drawing.Point(12, 325);
            this.lvbisadmin.Name = "lvbisadmin";
            this.lvbisadmin.Size = new System.Drawing.Size(44, 13);
            this.lvbisadmin.TabIndex = 10;
            this.lvbisadmin.Text = "IsAdmin";
            this.lvbisadmin.Click += new System.EventHandler(this.label11_Click);
            // 
            // lvbpassword
            // 
            this.lvbpassword.AutoSize = true;
            this.lvbpassword.Location = new System.Drawing.Point(6, 298);
            this.lvbpassword.Name = "lvbpassword";
            this.lvbpassword.Size = new System.Drawing.Size(53, 13);
            this.lvbpassword.TabIndex = 9;
            this.lvbpassword.Text = "Password";
            // 
            // lvbusername
            // 
            this.lvbusername.AutoSize = true;
            this.lvbusername.Location = new System.Drawing.Point(6, 276);
            this.lvbusername.Name = "lvbusername";
            this.lvbusername.Size = new System.Drawing.Size(55, 13);
            this.lvbusername.TabIndex = 8;
            this.lvbusername.Text = "Username";
            // 
            // lvbemail
            // 
            this.lvbemail.AutoSize = true;
            this.lvbemail.Location = new System.Drawing.Point(17, 243);
            this.lvbemail.Name = "lvbemail";
            this.lvbemail.Size = new System.Drawing.Size(32, 13);
            this.lvbemail.TabIndex = 7;
            this.lvbemail.Text = "Email";
            this.lvbemail.Click += new System.EventHandler(this.label8_Click);
            // 
            // lvbmobileno
            // 
            this.lvbmobileno.AutoSize = true;
            this.lvbmobileno.Location = new System.Drawing.Point(12, 208);
            this.lvbmobileno.Name = "lvbmobileno";
            this.lvbmobileno.Size = new System.Drawing.Size(58, 13);
            this.lvbmobileno.TabIndex = 6;
            this.lvbmobileno.Text = "Mobile No.";
            // 
            // lvbaddress
            // 
            this.lvbaddress.AutoSize = true;
            this.lvbaddress.Location = new System.Drawing.Point(13, 176);
            this.lvbaddress.Name = "lvbaddress";
            this.lvbaddress.Size = new System.Drawing.Size(45, 13);
            this.lvbaddress.TabIndex = 5;
            this.lvbaddress.Text = "Address";
            this.lvbaddress.Click += new System.EventHandler(this.label6_Click);
            // 
            // lvbdob
            // 
            this.lvbdob.AutoSize = true;
            this.lvbdob.Location = new System.Drawing.Point(17, 151);
            this.lvbdob.Name = "lvbdob";
            this.lvbdob.Size = new System.Drawing.Size(27, 13);
            this.lvbdob.TabIndex = 4;
            this.lvbdob.Text = "Dob";
            // 
            // lvbdepartment
            // 
            this.lvbdepartment.AutoSize = true;
            this.lvbdepartment.Location = new System.Drawing.Point(13, 118);
            this.lvbdepartment.Name = "lvbdepartment";
            this.lvbdepartment.Size = new System.Drawing.Size(62, 13);
            this.lvbdepartment.TabIndex = 3;
            this.lvbdepartment.Text = "Department";
            // 
            // lvbdesignation
            // 
            this.lvbdesignation.AutoSize = true;
            this.lvbdesignation.Location = new System.Drawing.Point(12, 91);
            this.lvbdesignation.Name = "lvbdesignation";
            this.lvbdesignation.Size = new System.Drawing.Size(63, 13);
            this.lvbdesignation.TabIndex = 2;
            this.lvbdesignation.Text = "Designation";
            this.lvbdesignation.Click += new System.EventHandler(this.label3_Click);
            // 
            // lvbame
            // 
            this.lvbame.AutoSize = true;
            this.lvbame.Location = new System.Drawing.Point(10, 63);
            this.lvbame.Name = "lvbame";
            this.lvbame.Size = new System.Drawing.Size(35, 13);
            this.lvbame.TabIndex = 1;
            this.lvbame.Text = "Name";
            // 
            // lvbemployeeid
            // 
            this.lvbemployeeid.AutoSize = true;
            this.lvbemployeeid.Location = new System.Drawing.Point(10, 35);
            this.lvbemployeeid.Name = "lvbemployeeid";
            this.lvbemployeeid.Size = new System.Drawing.Size(65, 13);
            this.lvbemployeeid.TabIndex = 0;
            this.lvbemployeeid.Text = "Employee Id";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtxtbymobile;
        private System.Windows.Forms.TextBox searchtxtbyname;
        private System.Windows.Forms.Label lvbsearchbymobile;
        private System.Windows.Forms.Label lvbsearchbyname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lvbemployeesearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lvbreset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lvbisadmin;
        private System.Windows.Forms.Label lvbpassword;
        private System.Windows.Forms.Label lvbusername;
        private System.Windows.Forms.Label lvbemail;
        private System.Windows.Forms.Label lvbmobileno;
        private System.Windows.Forms.Label lvbaddress;
        private System.Windows.Forms.Label lvbdob;
        private System.Windows.Forms.Label lvbdepartment;
        private System.Windows.Forms.Label lvbdesignation;
        private System.Windows.Forms.Label lvbame;
        private System.Windows.Forms.Label lvbemployeeid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox isadmintxt;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox departmenttxtcombo;
        private System.Windows.Forms.ComboBox designationtxtbox;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox employetxtid;
    }
}