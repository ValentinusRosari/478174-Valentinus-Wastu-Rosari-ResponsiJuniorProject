namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbNama = new System.Windows.Forms.TextBox();
            tbDep = new System.Windows.Forms.TextBox();
            btnInsert = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(209, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 40);
            label1.TabIndex = 0;
            label1.Text = "logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 121);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 151);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new System.Drawing.Point(117, 118);
            tbNama.Name = "tbNama";
            tbNama.Size = new System.Drawing.Size(180, 23);
            tbNama.TabIndex = 3;
            // 
            // tbDep
            // 
            tbDep.Location = new System.Drawing.Point(117, 148);
            tbDep.Name = "tbDep";
            tbDep.Size = new System.Drawing.Size(180, 23);
            tbDep.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(12, 193);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(75, 23);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(117, 193);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(222, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(491, 211);
            dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new System.Drawing.Point(303, 121);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 100);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(1, 1);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 15);
            label4.TabIndex = 10;
            label4.Text = "ID Departemen :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(48, 15);
            label5.TabIndex = 11;
            label5.Text = "HR : HR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 47);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(85, 15);
            label6.TabIndex = 12;
            label6.Text = "ENG : Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 69);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(90, 15);
            label7.TabIndex = 13;
            label7.Text = "DEV : Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(107, 27);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(90, 15);
            label8.TabIndex = 14;
            label8.Text = "PM : Product M";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(107, 47);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(75, 15);
            label9.TabIndex = 15;
            label9.Text = "FIN : Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(514, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(tbDep);
            Controls.Add(tbNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbDep;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
