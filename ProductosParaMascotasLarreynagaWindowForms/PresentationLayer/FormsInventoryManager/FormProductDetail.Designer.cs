
namespace PresentationLayer.FormsInventoryManager
{
    partial class FormProductDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductDetail));
            this.PictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.RichTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.LabelStock = new System.Windows.Forms.Label();
            this.LabelNumberStock = new System.Windows.Forms.Label();
            this.NumericUpDownProduct = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxProduct
            // 
            this.PictureBoxProduct.BackColor = System.Drawing.Color.White;
            this.PictureBoxProduct.Image = global::PresentationLayer.InventoryManager.combis_adulto_mejor_alimento_;
            this.PictureBoxProduct.Location = new System.Drawing.Point(12, 60);
            this.PictureBoxProduct.Name = "PictureBoxProduct";
            this.PictureBoxProduct.Size = new System.Drawing.Size(289, 267);
            this.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxProduct.TabIndex = 2;
            this.PictureBoxProduct.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.BackColor = System.Drawing.Color.White;
            this.LabelName.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(580, 37);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Combis";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrice
            // 
            this.LabelPrice.BackColor = System.Drawing.Color.White;
            this.LabelPrice.Font = new System.Drawing.Font("Mulish", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.LabelPrice.Location = new System.Drawing.Point(12, 330);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(288, 40);
            this.LabelPrice.TabIndex = 4;
            this.LabelPrice.Text = "$999999.99";
            this.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Mulish", 20.25F);
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelDescription.Location = new System.Drawing.Point(307, 60);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(160, 37);
            this.LabelDescription.TabIndex = 5;
            this.LabelDescription.Text = "Descripción";
            // 
            // RichTextBoxDescription
            // 
            this.RichTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxDescription.Font = new System.Drawing.Font("Mulish", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxDescription.Location = new System.Drawing.Point(314, 108);
            this.RichTextBoxDescription.Name = "RichTextBoxDescription";
            this.RichTextBoxDescription.ReadOnly = true;
            this.RichTextBoxDescription.Size = new System.Drawing.Size(340, 161);
            this.RichTextBoxDescription.TabIndex = 6;
            this.RichTextBoxDescription.Text = resources.GetString("RichTextBoxDescription.Text");
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Mulish", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Location = new System.Drawing.Point(314, 328);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(147, 40);
            this.ButtonAdd.TabIndex = 8;
            this.ButtonAdd.Text = "Agregar";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // LabelStock
            // 
            this.LabelStock.AutoSize = true;
            this.LabelStock.Font = new System.Drawing.Font("Mulish", 20.25F);
            this.LabelStock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelStock.Location = new System.Drawing.Point(307, 280);
            this.LabelStock.Name = "LabelStock";
            this.LabelStock.Size = new System.Drawing.Size(160, 37);
            this.LabelStock.TabIndex = 9;
            this.LabelStock.Text = "Existencias:";
            // 
            // LabelNumberStock
            // 
            this.LabelNumberStock.BackColor = System.Drawing.Color.White;
            this.LabelNumberStock.Font = new System.Drawing.Font("Mulish", 20.25F);
            this.LabelNumberStock.ForeColor = System.Drawing.Color.Black;
            this.LabelNumberStock.Location = new System.Drawing.Point(473, 280);
            this.LabelNumberStock.Name = "LabelNumberStock";
            this.LabelNumberStock.Size = new System.Drawing.Size(181, 37);
            this.LabelNumberStock.TabIndex = 10;
            this.LabelNumberStock.Text = "999999999";
            this.LabelNumberStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericUpDownProduct
            // 
            this.NumericUpDownProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericUpDownProduct.Font = new System.Drawing.Font("Mulish", 20.25F);
            this.NumericUpDownProduct.Location = new System.Drawing.Point(480, 328);
            this.NumericUpDownProduct.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownProduct.Name = "NumericUpDownProduct";
            this.NumericUpDownProduct.Size = new System.Drawing.Size(174, 41);
            this.NumericUpDownProduct.TabIndex = 11;
            this.NumericUpDownProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownProduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 381);
            this.Controls.Add(this.NumericUpDownProduct);
            this.Controls.Add(this.LabelNumberStock);
            this.Controls.Add(this.LabelStock);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.RichTextBoxDescription);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PictureBoxProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProductDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxProduct;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.RichTextBox RichTextBoxDescription;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label LabelStock;
        private System.Windows.Forms.Label LabelNumberStock;
        private System.Windows.Forms.NumericUpDown NumericUpDownProduct;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}