namespace CalenderApp
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_currentDay = new System.Windows.Forms.Label();
            this.lbl_currentYear = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::CalenderApp.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(265, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CalenderApp.Properties.Resources.calender;
            this.panel1.Controls.Add(this.lbl_currentYear);
            this.panel1.Controls.Add(this.lbl_currentDay);
            this.panel1.Location = new System.Drawing.Point(1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 296);
            this.panel1.TabIndex = 1;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lbl_currentDay
            // 
            this.lbl_currentDay.AutoSize = true;
            this.lbl_currentDay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentDay.Font = new System.Drawing.Font("Trebuchet MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_currentDay.Location = new System.Drawing.Point(68, 35);
            this.lbl_currentDay.Name = "lbl_currentDay";
            this.lbl_currentDay.Size = new System.Drawing.Size(0, 119);
            this.lbl_currentDay.TabIndex = 0;
            // 
            // lbl_currentYear
            // 
            this.lbl_currentYear.AutoSize = true;
            this.lbl_currentYear.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentYear.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_currentYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_currentYear.Location = new System.Drawing.Point(6, 221);
            this.lbl_currentYear.Name = "lbl_currentYear";
            this.lbl_currentYear.Size = new System.Drawing.Size(0, 61);
            this.lbl_currentYear.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calender App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_currentDay;
        private System.Windows.Forms.Label lbl_currentYear;
    }
}

