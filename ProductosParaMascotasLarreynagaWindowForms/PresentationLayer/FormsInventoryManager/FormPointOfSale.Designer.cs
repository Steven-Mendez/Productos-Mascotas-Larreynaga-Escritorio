
namespace PresentationLayer.FormsInventoryManager
{
    partial class FormPointOfSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPointOfSale));
            this.PanelSide = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.PanelMoney = new System.Windows.Forms.Panel();
            this.LabelTotalMoney = new System.Windows.Forms.Label();
            this.LabelTotalText = new System.Windows.Forms.Label();
            this.ButtonBill = new System.Windows.Forms.Button();
            this.ButtonClearAll = new System.Windows.Forms.Button();
            this.ButtonClearOne = new System.Windows.Forms.Button();
            this.DataGridViewBill = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ImageButtonToys = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonAccessories = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonFood = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonRabbit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonBird = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonCats = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonDogs = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonAll = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.FlowPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelSide.SuspendLayout();
            this.PanelMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBill)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.PanelSide.Controls.Add(this.ButtonCancel);
            this.PanelSide.Controls.Add(this.PanelMoney);
            this.PanelSide.Controls.Add(this.LabelTotalText);
            this.PanelSide.Controls.Add(this.ButtonBill);
            this.PanelSide.Controls.Add(this.ButtonClearAll);
            this.PanelSide.Controls.Add(this.ButtonClearOne);
            this.PanelSide.Controls.Add(this.DataGridViewBill);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSide.Location = new System.Drawing.Point(752, 0);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(310, 706);
            this.PanelSide.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ButtonCancel.Location = new System.Drawing.Point(171, 652);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(127, 42);
            this.ButtonCancel.TabIndex = 16;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // PanelMoney
            // 
            this.PanelMoney.AutoScroll = true;
            this.PanelMoney.Controls.Add(this.LabelTotalMoney);
            this.PanelMoney.Location = new System.Drawing.Point(90, 558);
            this.PanelMoney.Name = "PanelMoney";
            this.PanelMoney.Size = new System.Drawing.Size(208, 83);
            this.PanelMoney.TabIndex = 15;
            // 
            // LabelTotalMoney
            // 
            this.LabelTotalMoney.AutoSize = true;
            this.LabelTotalMoney.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalMoney.Location = new System.Drawing.Point(3, 36);
            this.LabelTotalMoney.Name = "LabelTotalMoney";
            this.LabelTotalMoney.Size = new System.Drawing.Size(54, 22);
            this.LabelTotalMoney.TabIndex = 0;
            this.LabelTotalMoney.Text = "$0.00";
            // 
            // LabelTotalText
            // 
            this.LabelTotalText.AutoSize = true;
            this.LabelTotalText.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalText.Location = new System.Drawing.Point(6, 594);
            this.LabelTotalText.Name = "LabelTotalText";
            this.LabelTotalText.Size = new System.Drawing.Size(52, 22);
            this.LabelTotalText.TabIndex = 0;
            this.LabelTotalText.Text = "Total:";
            // 
            // ButtonBill
            // 
            this.ButtonBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(163)))));
            this.ButtonBill.FlatAppearance.BorderSize = 0;
            this.ButtonBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBill.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.ButtonBill.Location = new System.Drawing.Point(10, 652);
            this.ButtonBill.Name = "ButtonBill";
            this.ButtonBill.Size = new System.Drawing.Size(155, 42);
            this.ButtonBill.TabIndex = 14;
            this.ButtonBill.Text = "Facturar";
            this.ButtonBill.UseVisualStyleBackColor = false;
            this.ButtonBill.Click += new System.EventHandler(this.ButtonBill_Click);
            // 
            // ButtonClearAll
            // 
            this.ButtonClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ButtonClearAll.FlatAppearance.BorderSize = 0;
            this.ButtonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearAll.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ButtonClearAll.Location = new System.Drawing.Point(129, 7);
            this.ButtonClearAll.Name = "ButtonClearAll";
            this.ButtonClearAll.Size = new System.Drawing.Size(169, 42);
            this.ButtonClearAll.TabIndex = 14;
            this.ButtonClearAll.Text = "Quitar Todo";
            this.ButtonClearAll.UseVisualStyleBackColor = false;
            this.ButtonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
            // 
            // ButtonClearOne
            // 
            this.ButtonClearOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(145)))));
            this.ButtonClearOne.FlatAppearance.BorderSize = 0;
            this.ButtonClearOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearOne.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(105)))), ((int)(((byte)(23)))));
            this.ButtonClearOne.Location = new System.Drawing.Point(10, 7);
            this.ButtonClearOne.Name = "ButtonClearOne";
            this.ButtonClearOne.Size = new System.Drawing.Size(113, 42);
            this.ButtonClearOne.TabIndex = 14;
            this.ButtonClearOne.Text = "Quitar";
            this.ButtonClearOne.UseVisualStyleBackColor = false;
            this.ButtonClearOne.Click += new System.EventHandler(this.ButtonClearOne_Click);
            // 
            // DataGridViewBill
            // 
            this.DataGridViewBill.AllowCustomTheming = false;
            this.DataGridViewBill.AllowUserToAddRows = false;
            this.DataGridViewBill.AllowUserToDeleteRows = false;
            this.DataGridViewBill.AllowUserToResizeColumns = false;
            this.DataGridViewBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewBill.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewBill.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridViewBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewBill.ColumnHeadersHeight = 40;
            this.DataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.QTY,
            this.Precio,
            this.ID});
            this.DataGridViewBill.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            this.DataGridViewBill.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewBill.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewBill.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.DataGridViewBill.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewBill.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.DataGridViewBill.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.DataGridViewBill.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.DataGridViewBill.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewBill.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewBill.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.DataGridViewBill.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewBill.CurrentTheme.Name = null;
            this.DataGridViewBill.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.DataGridViewBill.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewBill.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewBill.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.DataGridViewBill.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewBill.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewBill.EnableHeadersVisualStyles = false;
            this.DataGridViewBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.DataGridViewBill.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.DataGridViewBill.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewBill.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewBill.Location = new System.Drawing.Point(10, 58);
            this.DataGridViewBill.MultiSelect = false;
            this.DataGridViewBill.Name = "DataGridViewBill";
            this.DataGridViewBill.ReadOnly = true;
            this.DataGridViewBill.RowHeadersVisible = false;
            this.DataGridViewBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridViewBill.RowTemplate.Height = 40;
            this.DataGridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewBill.Size = new System.Drawing.Size(385, 494);
            this.DataGridViewBill.TabIndex = 13;
            this.DataGridViewBill.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Item.Frozen = true;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QTY.Frozen = true;
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.FillWeight = 5F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.TextBoxSearch);
            this.PanelTop.Controls.Add(this.ImageButtonToys);
            this.PanelTop.Controls.Add(this.ImageButtonAccessories);
            this.PanelTop.Controls.Add(this.ImageButtonFood);
            this.PanelTop.Controls.Add(this.ImageButtonRabbit);
            this.PanelTop.Controls.Add(this.ImageButtonBird);
            this.PanelTop.Controls.Add(this.ImageButtonCats);
            this.PanelTop.Controls.Add(this.ImageButtonDogs);
            this.PanelTop.Controls.Add(this.ImageButtonAll);
            this.PanelTop.Controls.Add(this.PictureBoxSearch);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(752, 58);
            this.PanelTop.TabIndex = 1;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Mulish", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.TextBoxSearch.Location = new System.Drawing.Point(37, 10);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(310, 31);
            this.TextBoxSearch.TabIndex = 21;
            this.TextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            // 
            // ImageButtonToys
            // 
            this.ImageButtonToys.ActiveImage = null;
            this.ImageButtonToys.AllowAnimations = true;
            this.ImageButtonToys.AllowBuffering = false;
            this.ImageButtonToys.AllowToggling = false;
            this.ImageButtonToys.AllowZooming = true;
            this.ImageButtonToys.AllowZoomingOnFocus = false;
            this.ImageButtonToys.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonToys.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonToys.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonToys.ErrorImage")));
            this.ImageButtonToys.FadeWhenInactive = false;
            this.ImageButtonToys.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonToys.Image = global::PresentationLayer.InventoryManager.rope_black;
            this.ImageButtonToys.ImageActive = null;
            this.ImageButtonToys.ImageLocation = null;
            this.ImageButtonToys.ImageMargin = 0;
            this.ImageButtonToys.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonToys.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonToys.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonToys.InitialImage")));
            this.ImageButtonToys.Location = new System.Drawing.Point(689, 9);
            this.ImageButtonToys.Name = "ImageButtonToys";
            this.ImageButtonToys.Rotation = 0;
            this.ImageButtonToys.ShowActiveImage = true;
            this.ImageButtonToys.ShowCursorChanges = true;
            this.ImageButtonToys.ShowImageBorders = true;
            this.ImageButtonToys.ShowSizeMarkers = false;
            this.ImageButtonToys.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonToys.TabIndex = 20;
            this.ImageButtonToys.ToolTipText = "";
            this.ImageButtonToys.Visible = false;
            this.ImageButtonToys.WaitOnLoad = false;
            this.ImageButtonToys.Zoom = 0;
            this.ImageButtonToys.ZoomSpeed = 10;
            // 
            // ImageButtonAccessories
            // 
            this.ImageButtonAccessories.ActiveImage = null;
            this.ImageButtonAccessories.AllowAnimations = true;
            this.ImageButtonAccessories.AllowBuffering = false;
            this.ImageButtonAccessories.AllowToggling = false;
            this.ImageButtonAccessories.AllowZooming = true;
            this.ImageButtonAccessories.AllowZoomingOnFocus = false;
            this.ImageButtonAccessories.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonAccessories.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonAccessories.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonAccessories.ErrorImage")));
            this.ImageButtonAccessories.FadeWhenInactive = false;
            this.ImageButtonAccessories.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonAccessories.Image = global::PresentationLayer.InventoryManager.bone_black;
            this.ImageButtonAccessories.ImageActive = null;
            this.ImageButtonAccessories.ImageLocation = null;
            this.ImageButtonAccessories.ImageMargin = 0;
            this.ImageButtonAccessories.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonAccessories.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonAccessories.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonAccessories.InitialImage")));
            this.ImageButtonAccessories.Location = new System.Drawing.Point(642, 7);
            this.ImageButtonAccessories.Name = "ImageButtonAccessories";
            this.ImageButtonAccessories.Rotation = 0;
            this.ImageButtonAccessories.ShowActiveImage = true;
            this.ImageButtonAccessories.ShowCursorChanges = true;
            this.ImageButtonAccessories.ShowImageBorders = true;
            this.ImageButtonAccessories.ShowSizeMarkers = false;
            this.ImageButtonAccessories.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonAccessories.TabIndex = 18;
            this.ImageButtonAccessories.ToolTipText = "";
            this.ImageButtonAccessories.Visible = false;
            this.ImageButtonAccessories.WaitOnLoad = false;
            this.ImageButtonAccessories.Zoom = 0;
            this.ImageButtonAccessories.ZoomSpeed = 10;
            // 
            // ImageButtonFood
            // 
            this.ImageButtonFood.ActiveImage = null;
            this.ImageButtonFood.AllowAnimations = true;
            this.ImageButtonFood.AllowBuffering = false;
            this.ImageButtonFood.AllowToggling = false;
            this.ImageButtonFood.AllowZooming = true;
            this.ImageButtonFood.AllowZoomingOnFocus = false;
            this.ImageButtonFood.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonFood.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonFood.ErrorImage")));
            this.ImageButtonFood.FadeWhenInactive = false;
            this.ImageButtonFood.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonFood.Image = global::PresentationLayer.InventoryManager.food_black;
            this.ImageButtonFood.ImageActive = null;
            this.ImageButtonFood.ImageLocation = null;
            this.ImageButtonFood.ImageMargin = 0;
            this.ImageButtonFood.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonFood.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonFood.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonFood.InitialImage")));
            this.ImageButtonFood.Location = new System.Drawing.Point(595, 7);
            this.ImageButtonFood.Name = "ImageButtonFood";
            this.ImageButtonFood.Rotation = 0;
            this.ImageButtonFood.ShowActiveImage = true;
            this.ImageButtonFood.ShowCursorChanges = true;
            this.ImageButtonFood.ShowImageBorders = true;
            this.ImageButtonFood.ShowSizeMarkers = false;
            this.ImageButtonFood.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonFood.TabIndex = 19;
            this.ImageButtonFood.ToolTipText = "";
            this.ImageButtonFood.Visible = false;
            this.ImageButtonFood.WaitOnLoad = false;
            this.ImageButtonFood.Zoom = 0;
            this.ImageButtonFood.ZoomSpeed = 10;
            // 
            // ImageButtonRabbit
            // 
            this.ImageButtonRabbit.ActiveImage = null;
            this.ImageButtonRabbit.AllowAnimations = true;
            this.ImageButtonRabbit.AllowBuffering = false;
            this.ImageButtonRabbit.AllowToggling = false;
            this.ImageButtonRabbit.AllowZooming = true;
            this.ImageButtonRabbit.AllowZoomingOnFocus = false;
            this.ImageButtonRabbit.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonRabbit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonRabbit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonRabbit.ErrorImage")));
            this.ImageButtonRabbit.FadeWhenInactive = false;
            this.ImageButtonRabbit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonRabbit.Image = global::PresentationLayer.InventoryManager.Conejo_black;
            this.ImageButtonRabbit.ImageActive = null;
            this.ImageButtonRabbit.ImageLocation = null;
            this.ImageButtonRabbit.ImageMargin = 0;
            this.ImageButtonRabbit.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonRabbit.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonRabbit.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonRabbit.InitialImage")));
            this.ImageButtonRabbit.Location = new System.Drawing.Point(501, 7);
            this.ImageButtonRabbit.Name = "ImageButtonRabbit";
            this.ImageButtonRabbit.Rotation = 0;
            this.ImageButtonRabbit.ShowActiveImage = true;
            this.ImageButtonRabbit.ShowCursorChanges = true;
            this.ImageButtonRabbit.ShowImageBorders = true;
            this.ImageButtonRabbit.ShowSizeMarkers = false;
            this.ImageButtonRabbit.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonRabbit.TabIndex = 16;
            this.ImageButtonRabbit.ToolTipText = "";
            this.ImageButtonRabbit.Visible = false;
            this.ImageButtonRabbit.WaitOnLoad = false;
            this.ImageButtonRabbit.Zoom = 0;
            this.ImageButtonRabbit.ZoomSpeed = 10;
            // 
            // ImageButtonBird
            // 
            this.ImageButtonBird.ActiveImage = null;
            this.ImageButtonBird.AllowAnimations = true;
            this.ImageButtonBird.AllowBuffering = false;
            this.ImageButtonBird.AllowToggling = false;
            this.ImageButtonBird.AllowZooming = true;
            this.ImageButtonBird.AllowZoomingOnFocus = false;
            this.ImageButtonBird.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonBird.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonBird.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonBird.ErrorImage")));
            this.ImageButtonBird.FadeWhenInactive = false;
            this.ImageButtonBird.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonBird.Image = global::PresentationLayer.InventoryManager.Ave_black;
            this.ImageButtonBird.ImageActive = null;
            this.ImageButtonBird.ImageLocation = null;
            this.ImageButtonBird.ImageMargin = 0;
            this.ImageButtonBird.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonBird.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonBird.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonBird.InitialImage")));
            this.ImageButtonBird.Location = new System.Drawing.Point(548, 7);
            this.ImageButtonBird.Name = "ImageButtonBird";
            this.ImageButtonBird.Rotation = 0;
            this.ImageButtonBird.ShowActiveImage = true;
            this.ImageButtonBird.ShowCursorChanges = true;
            this.ImageButtonBird.ShowImageBorders = true;
            this.ImageButtonBird.ShowSizeMarkers = false;
            this.ImageButtonBird.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonBird.TabIndex = 17;
            this.ImageButtonBird.ToolTipText = "";
            this.ImageButtonBird.Visible = false;
            this.ImageButtonBird.WaitOnLoad = false;
            this.ImageButtonBird.Zoom = 0;
            this.ImageButtonBird.ZoomSpeed = 10;
            // 
            // ImageButtonCats
            // 
            this.ImageButtonCats.ActiveImage = null;
            this.ImageButtonCats.AllowAnimations = true;
            this.ImageButtonCats.AllowBuffering = false;
            this.ImageButtonCats.AllowToggling = false;
            this.ImageButtonCats.AllowZooming = true;
            this.ImageButtonCats.AllowZoomingOnFocus = false;
            this.ImageButtonCats.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonCats.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonCats.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonCats.ErrorImage")));
            this.ImageButtonCats.FadeWhenInactive = false;
            this.ImageButtonCats.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonCats.Image = global::PresentationLayer.InventoryManager.Gato_black;
            this.ImageButtonCats.ImageActive = null;
            this.ImageButtonCats.ImageLocation = null;
            this.ImageButtonCats.ImageMargin = 0;
            this.ImageButtonCats.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonCats.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonCats.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonCats.InitialImage")));
            this.ImageButtonCats.Location = new System.Drawing.Point(454, 7);
            this.ImageButtonCats.Name = "ImageButtonCats";
            this.ImageButtonCats.Rotation = 0;
            this.ImageButtonCats.ShowActiveImage = true;
            this.ImageButtonCats.ShowCursorChanges = true;
            this.ImageButtonCats.ShowImageBorders = true;
            this.ImageButtonCats.ShowSizeMarkers = false;
            this.ImageButtonCats.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonCats.TabIndex = 15;
            this.ImageButtonCats.ToolTipText = "";
            this.ImageButtonCats.Visible = false;
            this.ImageButtonCats.WaitOnLoad = false;
            this.ImageButtonCats.Zoom = 0;
            this.ImageButtonCats.ZoomSpeed = 10;
            // 
            // ImageButtonDogs
            // 
            this.ImageButtonDogs.ActiveImage = null;
            this.ImageButtonDogs.AllowAnimations = true;
            this.ImageButtonDogs.AllowBuffering = false;
            this.ImageButtonDogs.AllowToggling = false;
            this.ImageButtonDogs.AllowZooming = true;
            this.ImageButtonDogs.AllowZoomingOnFocus = false;
            this.ImageButtonDogs.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonDogs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonDogs.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonDogs.ErrorImage")));
            this.ImageButtonDogs.FadeWhenInactive = false;
            this.ImageButtonDogs.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonDogs.Image = global::PresentationLayer.InventoryManager.Perro_black;
            this.ImageButtonDogs.ImageActive = null;
            this.ImageButtonDogs.ImageLocation = null;
            this.ImageButtonDogs.ImageMargin = 0;
            this.ImageButtonDogs.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonDogs.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonDogs.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonDogs.InitialImage")));
            this.ImageButtonDogs.Location = new System.Drawing.Point(407, 7);
            this.ImageButtonDogs.Name = "ImageButtonDogs";
            this.ImageButtonDogs.Rotation = 0;
            this.ImageButtonDogs.ShowActiveImage = true;
            this.ImageButtonDogs.ShowCursorChanges = true;
            this.ImageButtonDogs.ShowImageBorders = true;
            this.ImageButtonDogs.ShowSizeMarkers = false;
            this.ImageButtonDogs.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonDogs.TabIndex = 14;
            this.ImageButtonDogs.ToolTipText = "";
            this.ImageButtonDogs.Visible = false;
            this.ImageButtonDogs.WaitOnLoad = false;
            this.ImageButtonDogs.Zoom = 0;
            this.ImageButtonDogs.ZoomSpeed = 10;
            // 
            // ImageButtonAll
            // 
            this.ImageButtonAll.ActiveImage = null;
            this.ImageButtonAll.AllowAnimations = true;
            this.ImageButtonAll.AllowBuffering = false;
            this.ImageButtonAll.AllowToggling = false;
            this.ImageButtonAll.AllowZooming = true;
            this.ImageButtonAll.AllowZoomingOnFocus = false;
            this.ImageButtonAll.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonAll.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonAll.ErrorImage")));
            this.ImageButtonAll.FadeWhenInactive = false;
            this.ImageButtonAll.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonAll.Image = global::PresentationLayer.InventoryManager.all;
            this.ImageButtonAll.ImageActive = null;
            this.ImageButtonAll.ImageLocation = null;
            this.ImageButtonAll.ImageMargin = 0;
            this.ImageButtonAll.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonAll.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonAll.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonAll.InitialImage")));
            this.ImageButtonAll.Location = new System.Drawing.Point(360, 7);
            this.ImageButtonAll.Name = "ImageButtonAll";
            this.ImageButtonAll.Rotation = 0;
            this.ImageButtonAll.ShowActiveImage = true;
            this.ImageButtonAll.ShowCursorChanges = true;
            this.ImageButtonAll.ShowImageBorders = true;
            this.ImageButtonAll.ShowSizeMarkers = false;
            this.ImageButtonAll.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonAll.TabIndex = 13;
            this.ImageButtonAll.ToolTipText = "";
            this.ImageButtonAll.Visible = false;
            this.ImageButtonAll.WaitOnLoad = false;
            this.ImageButtonAll.Zoom = 0;
            this.ImageButtonAll.ZoomSpeed = 10;
            // 
            // PictureBoxSearch
            // 
            this.PictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSearch.Image")));
            this.PictureBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxSearch.Name = "PictureBoxSearch";
            this.PictureBoxSearch.Size = new System.Drawing.Size(350, 44);
            this.PictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxSearch.TabIndex = 12;
            this.PictureBoxSearch.TabStop = false;
            // 
            // FlowPanelProducts
            // 
            this.FlowPanelProducts.AutoScroll = true;
            this.FlowPanelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelProducts.Location = new System.Drawing.Point(0, 58);
            this.FlowPanelProducts.Name = "FlowPanelProducts";
            this.FlowPanelProducts.Size = new System.Drawing.Size(752, 648);
            this.FlowPanelProducts.TabIndex = 2;
            // 
            // FormPointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1062, 706);
            this.Controls.Add(this.FlowPanelProducts);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelSide);
            this.Font = new System.Drawing.Font("Mulish", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPointOfSale";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormPointOfSale";
            this.Load += new System.EventHandler(this.FormPointOfSale_Load);
            this.PanelSide.ResumeLayout(false);
            this.PanelSide.PerformLayout();
            this.PanelMoney.ResumeLayout(false);
            this.PanelMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBill)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelProducts;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonToys;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonAccessories;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonFood;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonRabbit;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonBird;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonCats;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonDogs;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonAll;
        private System.Windows.Forms.PictureBox PictureBoxSearch;
        private System.Windows.Forms.Panel PanelMoney;
        private System.Windows.Forms.Label LabelTotalMoney;
        private System.Windows.Forms.Label LabelTotalText;
        private System.Windows.Forms.Button ButtonBill;
        private System.Windows.Forms.Button ButtonClearAll;
        private System.Windows.Forms.Button ButtonClearOne;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridViewBill;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}