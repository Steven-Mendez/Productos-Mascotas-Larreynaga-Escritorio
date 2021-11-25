
namespace PresentationLayer.FormsInventoryManager
{
    partial class FormBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.identificationTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployeeTxt = new System.Windows.Forms.Label();
            this.MoneyTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // customerTxt
            // 
            this.customerTxt.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTxt.Location = new System.Drawing.Point(12, 46);
            this.customerTxt.Name = "customerTxt";
            this.customerTxt.Size = new System.Drawing.Size(405, 37);
            this.customerTxt.TabIndex = 0;
            this.customerTxt.Text = "Steven Alexander Mendez Paiz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cedula:";
            // 
            // identificationTxt
            // 
            this.identificationTxt.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificationTxt.Location = new System.Drawing.Point(12, 120);
            this.identificationTxt.Name = "identificationTxt";
            this.identificationTxt.Size = new System.Drawing.Size(405, 37);
            this.identificationTxt.TabIndex = 0;
            this.identificationTxt.Text = "001-111111-1111A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empleado:";
            // 
            // EmployeeTxt
            // 
            this.EmployeeTxt.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTxt.Location = new System.Drawing.Point(12, 194);
            this.EmployeeTxt.Name = "EmployeeTxt";
            this.EmployeeTxt.Size = new System.Drawing.Size(405, 37);
            this.EmployeeTxt.TabIndex = 0;
            this.EmployeeTxt.Text = "Steven Alexander Mendez Paiz";
            // 
            // MoneyTxt
            // 
            this.MoneyTxt.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.MoneyTxt.Location = new System.Drawing.Point(99, 231);
            this.MoneyTxt.Name = "MoneyTxt";
            this.MoneyTxt.Size = new System.Drawing.Size(318, 37);
            this.MoneyTxt.TabIndex = 1;
            this.MoneyTxt.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total:";
            // 
            // ButtonBill
            // 
            this.ButtonBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(163)))));
            this.ButtonBill.FlatAppearance.BorderSize = 0;
            this.ButtonBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBill.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.ButtonBill.Location = new System.Drawing.Point(137, 271);
            this.ButtonBill.Name = "ButtonBill";
            this.ButtonBill.Size = new System.Drawing.Size(155, 42);
            this.ButtonBill.TabIndex = 16;
            this.ButtonBill.Text = "Facturar";
            this.ButtonBill.UseVisualStyleBackColor = false;
            this.ButtonBill.Click += new System.EventHandler(this.ButtonBill_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 325);
            this.Controls.Add(this.ButtonBill);
            this.Controls.Add(this.MoneyTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.identificationTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeTxt);
            this.Controls.Add(this.customerTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBill";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label identificationTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmployeeTxt;
        private System.Windows.Forms.Label MoneyTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonBill;
    }
}