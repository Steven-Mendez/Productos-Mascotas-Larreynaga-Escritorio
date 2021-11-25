
namespace PresentationLayer.FormsInventoryManager
{
    partial class ProductButton
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.ButtonDetails = new System.Windows.Forms.Button();
            this.PictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.PictureBoxCardView = new System.Windows.Forms.PictureBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCardView)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.BackColor = System.Drawing.Color.White;
            this.LabelName.Font = new System.Drawing.Font("Mulish", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(10, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(147, 74);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Combis";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrice
            // 
            this.LabelPrice.BackColor = System.Drawing.Color.White;
            this.LabelPrice.Font = new System.Drawing.Font("Mulish", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.LabelPrice.Location = new System.Drawing.Point(10, 90);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(147, 33);
            this.LabelPrice.TabIndex = 2;
            this.LabelPrice.Text = "$999999.99";
            this.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonDetails
            // 
            this.ButtonDetails.BackColor = System.Drawing.Color.White;
            this.ButtonDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDetails.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDetails.Location = new System.Drawing.Point(10, 130);
            this.ButtonDetails.Name = "ButtonDetails";
            this.ButtonDetails.Size = new System.Drawing.Size(147, 37);
            this.ButtonDetails.TabIndex = 3;
            this.ButtonDetails.Text = "Detalles";
            this.ButtonDetails.UseVisualStyleBackColor = false;
            // 
            // PictureBoxProduct
            // 
            this.PictureBoxProduct.BackColor = System.Drawing.Color.White;
            this.PictureBoxProduct.Image = global::PresentationLayer.InventoryManager.combis_adulto_mejor_alimento_;
            this.PictureBoxProduct.Location = new System.Drawing.Point(165, 9);
            this.PictureBoxProduct.Name = "PictureBoxProduct";
            this.PictureBoxProduct.Size = new System.Drawing.Size(183, 209);
            this.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxProduct.TabIndex = 1;
            this.PictureBoxProduct.TabStop = false;
            // 
            // PictureBoxCardView
            // 
            this.PictureBoxCardView.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxCardView.Image = global::PresentationLayer.InventoryManager.product_card1;
            this.PictureBoxCardView.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxCardView.Name = "PictureBoxCardView";
            this.PictureBoxCardView.Size = new System.Drawing.Size(354, 221);
            this.PictureBoxCardView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCardView.TabIndex = 4;
            this.PictureBoxCardView.TabStop = false;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Location = new System.Drawing.Point(10, 181);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(147, 37);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Agregar";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // ProductButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonDetails);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PictureBoxProduct);
            this.Controls.Add(this.PictureBoxCardView);
            this.Name = "ProductButton";
            this.Size = new System.Drawing.Size(360, 227);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCardView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBoxProduct;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Button ButtonDetails;
        private System.Windows.Forms.PictureBox PictureBoxCardView;
        private System.Windows.Forms.Button ButtonAdd;
    }
}
