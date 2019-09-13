namespace HOTEL_Management
{
    partial class ManageReservationsForm
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
            this.dateTimeOUT = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeIN = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReservID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearFields = new System.Windows.Forms.Button();
            this.RemoveReservation = new System.Windows.Forms.Button();
            this.EditReservation = new System.Windows.Forms.Button();
            this.AddReservation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.dateTimeOUT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimeIN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxRoomNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.textBoxClientID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxReservID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ClearFields);
            this.panel1.Controls.Add(this.RemoveReservation);
            this.panel1.Controls.Add(this.EditReservation);
            this.panel1.Controls.Add(this.AddReservation);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 480);
            this.panel1.TabIndex = 2;
            // 
            // dateTimeOUT
            // 
            this.dateTimeOUT.CustomFormat = "dd/MM/yyyy";
            this.dateTimeOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeOUT.Location = new System.Drawing.Point(158, 285);
            this.dateTimeOUT.Name = "dateTimeOUT";
            this.dateTimeOUT.Size = new System.Drawing.Size(191, 29);
            this.dateTimeOUT.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date OUT:";
            // 
            // dateTimeIN
            // 
            this.dateTimeIN.CustomFormat = "dd/MM/yyyy";
            this.dateTimeIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeIN.Location = new System.Drawing.Point(158, 252);
            this.dateTimeIN.Name = "dateTimeIN";
            this.dateTimeIN.Size = new System.Drawing.Size(191, 29);
            this.dateTimeIN.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date IN:";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(158, 210);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(163, 32);
            this.comboBoxRoomNumber.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Room Number:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(158, 163);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(163, 32);
            this.comboBoxRoomType.TabIndex = 23;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(12, 163);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 24);
            this.label.TabIndex = 22;
            this.label.Text = "Room Type:";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxClientID.Location = new System.Drawing.Point(158, 87);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(111, 29);
            this.textBoxClientID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Client ID:";
            // 
            // textBoxReservID
            // 
            this.textBoxReservID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxReservID.Location = new System.Drawing.Point(160, 124);
            this.textBoxReservID.Name = "textBoxReservID";
            this.textBoxReservID.Size = new System.Drawing.Size(111, 29);
            this.textBoxReservID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Reserv ID:";
            // 
            // ClearFields
            // 
            this.ClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearFields.Location = new System.Drawing.Point(16, 447);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(311, 33);
            this.ClearFields.TabIndex = 16;
            this.ClearFields.Text = "Clear Fields";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // RemoveReservation
            // 
            this.RemoveReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveReservation.Location = new System.Drawing.Point(16, 369);
            this.RemoveReservation.Name = "RemoveReservation";
            this.RemoveReservation.Size = new System.Drawing.Size(311, 33);
            this.RemoveReservation.TabIndex = 15;
            this.RemoveReservation.Text = "Remove";
            this.RemoveReservation.UseVisualStyleBackColor = true;
            this.RemoveReservation.Click += new System.EventHandler(this.RemoveReservation_Click);
            // 
            // EditReservation
            // 
            this.EditReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditReservation.Location = new System.Drawing.Point(16, 408);
            this.EditReservation.Name = "EditReservation";
            this.EditReservation.Size = new System.Drawing.Size(311, 33);
            this.EditReservation.TabIndex = 14;
            this.EditReservation.Text = "Edit";
            this.EditReservation.UseVisualStyleBackColor = true;
            this.EditReservation.Click += new System.EventHandler(this.EditReservation_Click);
            // 
            // AddReservation
            // 
            this.AddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddReservation.Location = new System.Drawing.Point(16, 330);
            this.AddReservation.Name = "AddReservation";
            this.AddReservation.Size = new System.Drawing.Size(311, 33);
            this.AddReservation.TabIndex = 13;
            this.AddReservation.Text = "Add Reservation";
            this.AddReservation.UseVisualStyleBackColor = true;
            this.AddReservation.Click += new System.EventHandler(this.AddReservation_Click);
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
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 480);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReservationsForm";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearFields;
        private System.Windows.Forms.Button RemoveReservation;
        private System.Windows.Forms.Button EditReservation;
        private System.Windows.Forms.Button AddReservation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dateTimeOUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReservID;
        private System.Windows.Forms.Label label2;
    }
}