
namespace PresentationLayer.FormsInventoryManager
{
    partial class FormMenu
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
            this.ButtonInventoryManager = new System.Windows.Forms.Button();
            this.ButtonAccountSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonInventoryManager
            // 
            this.ButtonInventoryManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.ButtonInventoryManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonInventoryManager.FlatAppearance.BorderSize = 0;
            this.ButtonInventoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInventoryManager.Font = new System.Drawing.Font("Mulish Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInventoryManager.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonInventoryManager.Location = new System.Drawing.Point(0, 0);
            this.ButtonInventoryManager.Name = "ButtonInventoryManager";
            this.ButtonInventoryManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonInventoryManager.Size = new System.Drawing.Size(304, 82);
            this.ButtonInventoryManager.TabIndex = 1;
            this.ButtonInventoryManager.Text = "Gestión de Inventario";
            this.ButtonInventoryManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonInventoryManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonInventoryManager.UseVisualStyleBackColor = false;
            this.ButtonInventoryManager.Click += new System.EventHandler(this.ButtonInventoryManager_Click);
            // 
            // ButtonAccountSettings
            // 
            this.ButtonAccountSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.ButtonAccountSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAccountSettings.FlatAppearance.BorderSize = 0;
            this.ButtonAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccountSettings.Font = new System.Drawing.Font("Mulish Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAccountSettings.Image = global::PresentationLayer.Properties.Resources.clarity_settings_solid_gray;
            this.ButtonAccountSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAccountSettings.Location = new System.Drawing.Point(0, 82);
            this.ButtonAccountSettings.Name = "ButtonAccountSettings";
            this.ButtonAccountSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonAccountSettings.Size = new System.Drawing.Size(304, 82);
            this.ButtonAccountSettings.TabIndex = 2;
            this.ButtonAccountSettings.Text = "Ajustes de Cuenta   ";
            this.ButtonAccountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAccountSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAccountSettings.UseVisualStyleBackColor = false;
            this.ButtonAccountSettings.Click += new System.EventHandler(this.ButtonAccountSettings_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(304, 453);
            this.Controls.Add(this.ButtonAccountSettings);
            this.Controls.Add(this.ButtonInventoryManager);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.ShowInTaskbar = false;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonInventoryManager;
        private System.Windows.Forms.Button ButtonAccountSettings;
    }
}