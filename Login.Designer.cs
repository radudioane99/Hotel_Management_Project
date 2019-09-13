namespace HOTEL_Management
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logbutton = new System.Windows.Forms.Button();
            this.passtext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usertext = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logbutton);
            this.groupBox1.Controls.Add(this.passtext);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.usertext);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // logbutton
            // 
            this.logbutton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.logbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logbutton.Location = new System.Drawing.Point(11, 126);
            this.logbutton.Name = "logbutton";
            this.logbutton.Size = new System.Drawing.Size(318, 48);
            this.logbutton.TabIndex = 6;
            this.logbutton.Text = "LOGIN";
            this.logbutton.UseVisualStyleBackColor = false;
            this.logbutton.Click += new System.EventHandler(this.logbutton_Click);
            // 
            // passtext
            // 
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passtext.Location = new System.Drawing.Point(124, 82);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(205, 31);
            this.passtext.TabIndex = 5;
            this.passtext.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.password.Location = new System.Drawing.Point(5, 88);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(112, 25);
            this.password.TabIndex = 4;
            this.password.Text = "Password:";
            // 
            // usertext
            // 
            this.usertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usertext.Location = new System.Drawing.Point(124, 38);
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(205, 31);
            this.usertext.TabIndex = 3;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.user.Location = new System.Drawing.Point(6, 43);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(119, 26);
            this.user.TabIndex = 2;
            this.user.Text = "Username:";
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HOTEL_Management.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(88, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(404, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logbutton;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label user;
    }
}