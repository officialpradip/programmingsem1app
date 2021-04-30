namespace secondapp
{
    partial class FormLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnchangepassword = new System.Windows.Forms.Button();
            this.currentpasswordtxt = new System.Windows.Forms.TextBox();
            this.newpasswordtxt = new System.Windows.Forms.TextBox();
            this.confirmpasswordtxt = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lvbconfirmpassword = new System.Windows.Forms.Label();
            this.lvbnewpassword = new System.Windows.Forms.Label();
            this.lvbcurrentpassword = new System.Windows.Forms.Label();
            this.lvbusername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnchangepassword);
            this.groupBox1.Controls.Add(this.currentpasswordtxt);
            this.groupBox1.Controls.Add(this.newpasswordtxt);
            this.groupBox1.Controls.Add(this.confirmpasswordtxt);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.lvbconfirmpassword);
            this.groupBox1.Controls.Add(this.lvbnewpassword);
            this.groupBox1.Controls.Add(this.lvbcurrentpassword);
            this.groupBox1.Controls.Add(this.lvbusername);
            this.groupBox1.Location = new System.Drawing.Point(309, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // btncancel
            // 
            this.btncancel.Image = global::secondapp.Properties.Resources.icon_cancel;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btncancel.Location = new System.Drawing.Point(260, 319);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(211, 55);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnchangepassword
            // 
            this.btnchangepassword.Image = global::secondapp.Properties.Resources.icon_key;
            this.btnchangepassword.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnchangepassword.Location = new System.Drawing.Point(6, 319);
            this.btnchangepassword.Name = "btnchangepassword";
            this.btnchangepassword.Size = new System.Drawing.Size(211, 55);
            this.btnchangepassword.TabIndex = 8;
            this.btnchangepassword.Text = "Change Password";
            this.btnchangepassword.UseVisualStyleBackColor = true;
            // 
            // currentpasswordtxt
            // 
            this.currentpasswordtxt.Location = new System.Drawing.Point(182, 98);
            this.currentpasswordtxt.Name = "currentpasswordtxt";
            this.currentpasswordtxt.Size = new System.Drawing.Size(168, 20);
            this.currentpasswordtxt.TabIndex = 7;
            // 
            // newpasswordtxt
            // 
            this.newpasswordtxt.Location = new System.Drawing.Point(182, 150);
            this.newpasswordtxt.Name = "newpasswordtxt";
            this.newpasswordtxt.Size = new System.Drawing.Size(168, 20);
            this.newpasswordtxt.TabIndex = 6;
            // 
            // confirmpasswordtxt
            // 
            this.confirmpasswordtxt.Location = new System.Drawing.Point(182, 207);
            this.confirmpasswordtxt.Name = "confirmpasswordtxt";
            this.confirmpasswordtxt.Size = new System.Drawing.Size(168, 20);
            this.confirmpasswordtxt.TabIndex = 5;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(182, 42);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(168, 20);
            this.txtusername.TabIndex = 4;
            // 
            // lvbconfirmpassword
            // 
            this.lvbconfirmpassword.AutoSize = true;
            this.lvbconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbconfirmpassword.Location = new System.Drawing.Point(22, 207);
            this.lvbconfirmpassword.Name = "lvbconfirmpassword";
            this.lvbconfirmpassword.Size = new System.Drawing.Size(137, 20);
            this.lvbconfirmpassword.TabIndex = 3;
            this.lvbconfirmpassword.Text = "Confirm Password";
            // 
            // lvbnewpassword
            // 
            this.lvbnewpassword.AutoSize = true;
            this.lvbnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbnewpassword.Location = new System.Drawing.Point(22, 148);
            this.lvbnewpassword.Name = "lvbnewpassword";
            this.lvbnewpassword.Size = new System.Drawing.Size(113, 20);
            this.lvbnewpassword.TabIndex = 2;
            this.lvbnewpassword.Text = "New Password";
            // 
            // lvbcurrentpassword
            // 
            this.lvbcurrentpassword.AutoSize = true;
            this.lvbcurrentpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbcurrentpassword.Location = new System.Drawing.Point(22, 96);
            this.lvbcurrentpassword.Name = "lvbcurrentpassword";
            this.lvbcurrentpassword.Size = new System.Drawing.Size(135, 20);
            this.lvbcurrentpassword.TabIndex = 1;
            this.lvbcurrentpassword.Text = "Current Password";
            // 
            // lvbusername
            // 
            this.lvbusername.AutoSize = true;
            this.lvbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbusername.Location = new System.Drawing.Point(22, 45);
            this.lvbusername.Name = "lvbusername";
            this.lvbusername.Size = new System.Drawing.Size(83, 20);
            this.lvbusername.TabIndex = 0;
            this.lvbusername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::secondapp.Properties.Resources.user_access_512;
            this.pictureBox1.Location = new System.Drawing.Point(16, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Changepasword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Changepasword";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Changepasword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnchangepassword;
        private System.Windows.Forms.TextBox currentpasswordtxt;
        private System.Windows.Forms.TextBox newpasswordtxt;
        private System.Windows.Forms.TextBox confirmpasswordtxt;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lvbconfirmpassword;
        private System.Windows.Forms.Label lvbnewpassword;
        private System.Windows.Forms.Label lvbcurrentpassword;
        private System.Windows.Forms.Label lvbusername;
    }
}