namespace Company
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnCompanies = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCompanies
            // 
            this.BtnCompanies.BackColor = System.Drawing.Color.SlateGray;
            this.BtnCompanies.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCompanies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCompanies.Location = new System.Drawing.Point(131, 113);
            this.BtnCompanies.Name = "BtnCompanies";
            this.BtnCompanies.Size = new System.Drawing.Size(119, 59);
            this.BtnCompanies.TabIndex = 0;
            this.BtnCompanies.Text = "Companies";
            this.BtnCompanies.UseVisualStyleBackColor = false;
            this.BtnCompanies.Click += new System.EventHandler(this.BtnCompanies_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.SlateGray;
            this.btnDepartment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepartment.Location = new System.Drawing.Point(297, 113);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(119, 59);
            this.btnDepartment.TabIndex = 1;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.SlateGray;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.Location = new System.Drawing.Point(224, 201);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(119, 59);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Group Of Companies";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(570, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.BtnCompanies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCompanies;
        private Button btnDepartment;
        private Button btnEmployee;
        private Label label1;
    }
}