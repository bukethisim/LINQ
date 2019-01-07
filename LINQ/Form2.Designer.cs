namespace LINQ
{
    partial class Form2
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
            this.btn_NewEmployee = new System.Windows.Forms.Button();
            this.lbl_EmployeeCount = new System.Windows.Forms.Label();
            this.lbl_AvgSalary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_NewEmployee
            // 
            this.btn_NewEmployee.Location = new System.Drawing.Point(12, 21);
            this.btn_NewEmployee.Name = "btn_NewEmployee";
            this.btn_NewEmployee.Size = new System.Drawing.Size(145, 35);
            this.btn_NewEmployee.TabIndex = 0;
            this.btn_NewEmployee.Text = "Yeni Personel";
            this.btn_NewEmployee.UseVisualStyleBackColor = true;
            this.btn_NewEmployee.Click += new System.EventHandler(this.btn_NewEmployee_Click);
            // 
            // lbl_EmployeeCount
            // 
            this.lbl_EmployeeCount.AutoSize = true;
            this.lbl_EmployeeCount.Location = new System.Drawing.Point(16, 82);
            this.lbl_EmployeeCount.Name = "lbl_EmployeeCount";
            this.lbl_EmployeeCount.Size = new System.Drawing.Size(120, 13);
            this.lbl_EmployeeCount.TabIndex = 1;
            this.lbl_EmployeeCount.Text = "Şu anda 0 personel var.";
            // 
            // lbl_AvgSalary
            // 
            this.lbl_AvgSalary.AutoSize = true;
            this.lbl_AvgSalary.Location = new System.Drawing.Point(16, 105);
            this.lbl_AvgSalary.Name = "lbl_AvgSalary";
            this.lbl_AvgSalary.Size = new System.Drawing.Size(149, 13);
            this.lbl_AvgSalary.TabIndex = 2;
            this.lbl_AvgSalary.Text = "Personel maaşı ortalama 0 TL.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Son eklenen personelin";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(45, 150);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(34, 13);
            this.lbl_Age.TabIndex = 4;
            this.lbl_Age.Text = "yaşı 0";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Location = new System.Drawing.Point(45, 172);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(43, 13);
            this.lbl_Salary.TabIndex = 5;
            this.lbl_Salary.Text = "maaşı 0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 204);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_AvgSalary);
            this.Controls.Add(this.lbl_EmployeeCount);
            this.Controls.Add(this.btn_NewEmployee);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewEmployee;
        private System.Windows.Forms.Label lbl_EmployeeCount;
        private System.Windows.Forms.Label lbl_AvgSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Salary;
    }
}