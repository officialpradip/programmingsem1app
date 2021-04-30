namespace secondapp
{
    partial class FormDesignation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesignation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvb = new System.Windows.Forms.Label();
            this.gradedesignationList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtdesignation1 = new System.Windows.Forms.TextBox();
            this.txtdesignationId1 = new System.Windows.Forms.TextBox();
            this.lvbdesignation = new System.Windows.Forms.Label();
            this.lvldesignation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gradedesignationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnrestart);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 73);
            this.panel1.TabIndex = 0;
            // 
            // btnrestart
            // 
            this.btnrestart.Image = ((System.Drawing.Image)(resources.GetObject("btnrestart.Image")));
            this.btnrestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrestart.Location = new System.Drawing.Point(642, 21);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(89, 27);
            this.btnrestart.TabIndex = 3;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(508, 21);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(70, 27);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(385, 20);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(89, 27);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 73);
            this.panel2.TabIndex = 0;
            // 
            // lvb
            // 
            this.lvb.AutoSize = true;
            this.lvb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvb.Location = new System.Drawing.Point(86, 21);
            this.lvb.Name = "lvb";
            this.lvb.Size = new System.Drawing.Size(199, 25);
            this.lvb.TabIndex = 0;
            this.lvb.Text = "Designation Entry";
            // 
            // gradedesignationList
            // 
            this.gradedesignationList.Controls.Add(this.dataGridView1);
            this.gradedesignationList.Location = new System.Drawing.Point(12, 110);
            this.gradedesignationList.Name = "gradedesignationList";
            this.gradedesignationList.Size = new System.Drawing.Size(366, 291);
            this.gradedesignationList.TabIndex = 1;
            this.gradedesignationList.TabStop = false;
            this.gradedesignationList.Text = "Designation List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Designation Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Designation";
            this.Column2.Name = "Column2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.txtdesignation1);
            this.groupBox2.Controls.Add(this.txtdesignationId1);
            this.groupBox2.Controls.Add(this.lvbdesignation);
            this.groupBox2.Controls.Add(this.lvldesignation);
            this.groupBox2.Location = new System.Drawing.Point(428, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 284);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Designation Entry";
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(201, 207);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 36);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(32, 207);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 36);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // txtdesignation1
            // 
            this.txtdesignation1.Location = new System.Drawing.Point(157, 136);
            this.txtdesignation1.Name = "txtdesignation1";
            this.txtdesignation1.Size = new System.Drawing.Size(107, 20);
            this.txtdesignation1.TabIndex = 3;
            // 
            // txtdesignationId1
            // 
            this.txtdesignationId1.Location = new System.Drawing.Point(157, 66);
            this.txtdesignationId1.Name = "txtdesignationId1";
            this.txtdesignationId1.Size = new System.Drawing.Size(107, 20);
            this.txtdesignationId1.TabIndex = 2;
            // 
            // lvbdesignation
            // 
            this.lvbdesignation.AutoSize = true;
            this.lvbdesignation.Location = new System.Drawing.Point(38, 143);
            this.lvbdesignation.Name = "lvbdesignation";
            this.lvbdesignation.Size = new System.Drawing.Size(63, 13);
            this.lvbdesignation.TabIndex = 1;
            this.lvbdesignation.Text = "Designation";
            // 
            // lvldesignation
            // 
            this.lvldesignation.AutoSize = true;
            this.lvldesignation.Location = new System.Drawing.Point(38, 64);
            this.lvldesignation.Name = "lvldesignation";
            this.lvldesignation.Size = new System.Drawing.Size(75, 13);
            this.lvldesignation.TabIndex = 0;
            this.lvldesignation.Text = "Designation Id";
            // 
            // FormDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gradedesignationList);
            this.Controls.Add(this.panel1);
            this.Name = "FormDesignation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gradedesignationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lvb;
        private System.Windows.Forms.GroupBox gradedesignationList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtdesignation1;
        private System.Windows.Forms.TextBox txtdesignationId1;
        private System.Windows.Forms.Label lvbdesignation;
        private System.Windows.Forms.Label lvldesignation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnrestart;
    }
}

