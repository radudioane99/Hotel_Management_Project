namespace HOTEL_Management
{
    partial class ManageClientsForm
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
            this.clear = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countrytext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastnametext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstnametext = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.countrytext);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.phonetext);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lastnametext);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.firstnametext);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.idtext);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 519);
            this.panel1.TabIndex = 0;
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
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remove.Location = new System.Drawing.Point(16, 369);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(311, 33);
            this.remove.TabIndex = 15;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit.Location = new System.Drawing.Point(16, 408);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(311, 33);
            this.edit.TabIndex = 14;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Location = new System.Drawing.Point(16, 330);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(311, 33);
            this.add.TabIndex = 13;
            this.add.Text = "Add New Client";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(489, 420);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // countrytext
            // 
            this.countrytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countrytext.Location = new System.Drawing.Point(117, 278);
            this.countrytext.Name = "countrytext";
            this.countrytext.Size = new System.Drawing.Size(220, 29);
            this.countrytext.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(36, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Country:";
            // 
            // phonetext
            // 
            this.phonetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phonetext.Location = new System.Drawing.Point(117, 232);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(220, 29);
            this.phonetext.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(45, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // lastnametext
            // 
            this.lastnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastnametext.Location = new System.Drawing.Point(117, 185);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.Size = new System.Drawing.Size(220, 29);
            this.lastnametext.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name:";
            // 
            // firstnametext
            // 
            this.firstnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstnametext.Location = new System.Drawing.Point(117, 137);
            this.firstnametext.Name = "firstnametext";
            this.firstnametext.Size = new System.Drawing.Size(220, 29);
            this.firstnametext.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(12, 142);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(106, 24);
            this.label.TabIndex = 4;
            this.label.Text = "First Name:";
            // 
            // idtext
            // 
            this.idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idtext.Location = new System.Drawing.Point(117, 87);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(111, 29);
            this.idtext.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(84, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 519);
            this.Controls.Add(this.panel1);
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClientsForm";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countrytext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastnametext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstnametext;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
    }
}