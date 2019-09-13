namespace HOTEL_Management
{
    partial class ManageRoomsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioNO = new System.Windows.Forms.RadioButton();
            this.radioYES = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Button();
            this.removeroom = new System.Windows.Forms.Button();
            this.editroom = new System.Windows.Forms.Button();
            this.addroom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.numbertext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.removeroom);
            this.panel1.Controls.Add(this.editroom);
            this.panel1.Controls.Add(this.addroom);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.phonetext);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.numbertext);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 519);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.radioNO);
            this.panel3.Controls.Add(this.radioYES);
            this.panel3.Location = new System.Drawing.Point(121, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 43);
            this.panel3.TabIndex = 20;
            // 
            // radioNO
            // 
            this.radioNO.AutoSize = true;
            this.radioNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioNO.ForeColor = System.Drawing.Color.Red;
            this.radioNO.Location = new System.Drawing.Point(119, 7);
            this.radioNO.Name = "radioNO";
            this.radioNO.Size = new System.Drawing.Size(59, 28);
            this.radioNO.TabIndex = 1;
            this.radioNO.TabStop = true;
            this.radioNO.Text = "NO";
            this.radioNO.UseVisualStyleBackColor = true;
            // 
            // radioYES
            // 
            this.radioYES.AutoSize = true;
            this.radioYES.Checked = true;
            this.radioYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioYES.ForeColor = System.Drawing.Color.Green;
            this.radioYES.Location = new System.Drawing.Point(16, 7);
            this.radioYES.Name = "radioYES";
            this.radioYES.Size = new System.Drawing.Size(68, 28);
            this.radioYES.TabIndex = 0;
            this.radioYES.TabStop = true;
            this.radioYES.Text = "YES";
            this.radioYES.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(56, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Free:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(121, 136);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(220, 32);
            this.comboBoxRoomType.TabIndex = 17;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.Location = new System.Drawing.Point(16, 447);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(311, 33);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // removeroom
            // 
            this.removeroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeroom.Location = new System.Drawing.Point(16, 369);
            this.removeroom.Name = "removeroom";
            this.removeroom.Size = new System.Drawing.Size(311, 33);
            this.removeroom.TabIndex = 15;
            this.removeroom.Text = "Remove";
            this.removeroom.UseVisualStyleBackColor = true;
            this.removeroom.Click += new System.EventHandler(this.removeroom_Click);
            // 
            // editroom
            // 
            this.editroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editroom.Location = new System.Drawing.Point(16, 408);
            this.editroom.Name = "editroom";
            this.editroom.Size = new System.Drawing.Size(311, 33);
            this.editroom.TabIndex = 14;
            this.editroom.Text = "Edit";
            this.editroom.UseVisualStyleBackColor = true;
            this.editroom.Click += new System.EventHandler(this.editroom_Click);
            // 
            // addroom
            // 
            this.addroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addroom.Location = new System.Drawing.Point(16, 330);
            this.addroom.Name = "addroom";
            this.addroom.Size = new System.Drawing.Size(311, 33);
            this.addroom.TabIndex = 13;
            this.addroom.Text = "Add New Room";
            this.addroom.UseVisualStyleBackColor = true;
            this.addroom.Click += new System.EventHandler(this.addroom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(489, 420);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
           
            // 
            // phonetext
            // 
            this.phonetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phonetext.Location = new System.Drawing.Point(121, 184);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(220, 29);
            this.phonetext.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(40, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(3, 144);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 24);
            this.label.TabIndex = 4;
            this.label.Text = "Room Type:";
            // 
            // numbertext
            // 
            this.numbertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numbertext.Location = new System.Drawing.Point(121, 90);
            this.numbertext.Name = "numbertext";
            this.numbertext.Size = new System.Drawing.Size(111, 29);
            this.numbertext.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room No:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 519);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRoomsForm";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button removeroom;
        private System.Windows.Forms.Button editroom;
        private System.Windows.Forms.Button addroom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox numbertext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioNO;
        private System.Windows.Forms.RadioButton radioYES;
    }
}