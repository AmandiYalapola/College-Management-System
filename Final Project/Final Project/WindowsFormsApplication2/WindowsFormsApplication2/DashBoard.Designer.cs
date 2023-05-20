namespace WindowsFormsApplication2
{
    partial class DashBoard
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
            this.lblstudent = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblteacher = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblfees = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblevents = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.lblstudent);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(58, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 239);
            this.panel1.TabIndex = 0;
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudent.ForeColor = System.Drawing.Color.White;
            this.lblstudent.Location = new System.Drawing.Point(198, 75);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(52, 55);
            this.lblstudent.TabIndex = 1;
            this.lblstudent.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(457, 57);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblteacher);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(839, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 239);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.ForeColor = System.Drawing.Color.White;
            this.lblteacher.Location = new System.Drawing.Point(207, 75);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(47, 51);
            this.lblteacher.TabIndex = 1;
            this.lblteacher.Text = "0";
            this.lblteacher.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 57);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(134, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teachers";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepPink;
            this.panel4.Controls.Add(this.lblfees);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(58, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 239);
            this.panel4.TabIndex = 2;
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfees.ForeColor = System.Drawing.Color.White;
            this.lblfees.Location = new System.Drawing.Point(82, 67);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(43, 46);
            this.lblfees.TabIndex = 1;
            this.lblfees.Text = "0";
            this.lblfees.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(0, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(457, 57);
            this.panel6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fees Collected";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Aqua;
            this.panel7.Controls.Add(this.lblevents);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(839, 332);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(457, 239);
            this.panel7.TabIndex = 2;
            // 
            // lblevents
            // 
            this.lblevents.AutoSize = true;
            this.lblevents.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevents.ForeColor = System.Drawing.Color.White;
            this.lblevents.Location = new System.Drawing.Point(198, 75);
            this.lblevents.Name = "lblevents";
            this.lblevents.Size = new System.Drawing.Size(52, 55);
            this.lblevents.TabIndex = 1;
            this.lblevents.Text = "0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.label);
            this.panel8.Location = new System.Drawing.Point(0, 182);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(457, 57);
            this.panel8.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(166, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 44);
            this.label.TabIndex = 0;
            this.label.Text = "Events";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1352, 623);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblevents;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label;
    }
}