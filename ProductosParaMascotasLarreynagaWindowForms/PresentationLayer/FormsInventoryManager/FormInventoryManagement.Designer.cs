
namespace PresentationLayer.FormsInventoryManager
{
    partial class FormInventoryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventoryManagement));
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DataGridViewInventoryManagament = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.ImageButtonCategories = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonDelete = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonEditProduct = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonAddProduct = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonOrderDescending = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonOrderAscending = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonSearchByStock = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonSearchBySalePrice = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonDescription = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonSearchByCategory = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonSearchByProductName = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonSearchByID = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PictureBoxSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInventoryManagament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Mulish", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.TextBoxSearch.Location = new System.Drawing.Point(41, 16);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(310, 31);
            this.TextBoxSearch.TabIndex = 11;
            this.ToolTip.SetToolTip(this.TextBoxSearch, "");
            this.ToolTip.SetToolTipIcon(this.TextBoxSearch, null);
            this.ToolTip.SetToolTipTitle(this.TextBoxSearch, "");
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // DataGridViewInventoryManagament
            // 
            this.DataGridViewInventoryManagament.AllowCustomTheming = false;
            this.DataGridViewInventoryManagament.AllowUserToAddRows = false;
            this.DataGridViewInventoryManagament.AllowUserToDeleteRows = false;
            this.DataGridViewInventoryManagament.AllowUserToResizeColumns = false;
            this.DataGridViewInventoryManagament.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewInventoryManagament.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewInventoryManagament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInventoryManagament.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.DataGridViewInventoryManagament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewInventoryManagament.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInventoryManagament.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridViewInventoryManagament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInventoryManagament.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewInventoryManagament.ColumnHeadersHeight = 40;
            this.DataGridViewInventoryManagament.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            this.DataGridViewInventoryManagament.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewInventoryManagament.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewInventoryManagament.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.DataGridViewInventoryManagament.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewInventoryManagament.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.DataGridViewInventoryManagament.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.DataGridViewInventoryManagament.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.DataGridViewInventoryManagament.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewInventoryManagament.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewInventoryManagament.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.DataGridViewInventoryManagament.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewInventoryManagament.CurrentTheme.Name = null;
            this.DataGridViewInventoryManagament.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.DataGridViewInventoryManagament.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewInventoryManagament.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewInventoryManagament.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.DataGridViewInventoryManagament.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewInventoryManagament.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewInventoryManagament.EnableHeadersVisualStyles = false;
            this.DataGridViewInventoryManagament.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.DataGridViewInventoryManagament.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.DataGridViewInventoryManagament.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewInventoryManagament.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewInventoryManagament.Location = new System.Drawing.Point(7, 59);
            this.DataGridViewInventoryManagament.MultiSelect = false;
            this.DataGridViewInventoryManagament.Name = "DataGridViewInventoryManagament";
            this.DataGridViewInventoryManagament.ReadOnly = true;
            this.DataGridViewInventoryManagament.RowHeadersVisible = false;
            this.DataGridViewInventoryManagament.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridViewInventoryManagament.RowTemplate.Height = 40;
            this.DataGridViewInventoryManagament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInventoryManagament.Size = new System.Drawing.Size(1048, 635);
            this.DataGridViewInventoryManagament.TabIndex = 12;
            this.DataGridViewInventoryManagament.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            this.ToolTip.SetToolTip(this.DataGridViewInventoryManagament, "");
            this.ToolTip.SetToolTipIcon(this.DataGridViewInventoryManagament, null);
            this.ToolTip.SetToolTipTitle(this.DataGridViewInventoryManagament, "");
            this.DataGridViewInventoryManagament.DoubleClick += new System.EventHandler(this.DataGridViewInventoryManagament_DoubleClick);
            // 
            // ToolTip
            // 
            this.ToolTip.Active = true;
            this.ToolTip.AlignTextWithTitle = false;
            this.ToolTip.AllowAutoClose = false;
            this.ToolTip.AllowFading = true;
            this.ToolTip.AutoCloseDuration = 5000;
            this.ToolTip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolTip.BorderColor = System.Drawing.Color.Gainsboro;
            this.ToolTip.ClickToShowDisplayControl = false;
            this.ToolTip.ConvertNewlinesToBreakTags = true;
            this.ToolTip.DisplayControl = null;
            this.ToolTip.EntryAnimationSpeed = 350;
            this.ToolTip.ExitAnimationSpeed = 200;
            this.ToolTip.GenerateAutoCloseDuration = false;
            this.ToolTip.IconMargin = 6;
            this.ToolTip.InitialDelay = 0;
            this.ToolTip.Name = "ToolTip";
            this.ToolTip.Opacity = 1D;
            this.ToolTip.OverrideToolTipTitles = false;
            this.ToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ShowBorders = false;
            this.ToolTip.ShowIcons = true;
            this.ToolTip.ShowShadows = true;
            this.ToolTip.Tag = null;
            this.ToolTip.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolTip.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolTip.TextMargin = 2;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.ToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.ToolTip.ToolTipTitle = null;
            // 
            // ImageButtonCategories
            // 
            this.ImageButtonCategories.ActiveImage = null;
            this.ImageButtonCategories.AllowAnimations = true;
            this.ImageButtonCategories.AllowBuffering = false;
            this.ImageButtonCategories.AllowToggling = false;
            this.ImageButtonCategories.AllowZooming = true;
            this.ImageButtonCategories.AllowZoomingOnFocus = false;
            this.ImageButtonCategories.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonCategories.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonCategories.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonCategories.ErrorImage")));
            this.ImageButtonCategories.FadeWhenInactive = false;
            this.ImageButtonCategories.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonCategories.Image = global::PresentationLayer.InventoryManager.inventory_management_categories;
            this.ImageButtonCategories.ImageActive = null;
            this.ImageButtonCategories.ImageLocation = null;
            this.ImageButtonCategories.ImageMargin = 0;
            this.ImageButtonCategories.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonCategories.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonCategories.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonCategories.InitialImage")));
            this.ImageButtonCategories.Location = new System.Drawing.Point(1015, 9);
            this.ImageButtonCategories.Name = "ImageButtonCategories";
            this.ImageButtonCategories.Rotation = 0;
            this.ImageButtonCategories.ShowActiveImage = true;
            this.ImageButtonCategories.ShowCursorChanges = true;
            this.ImageButtonCategories.ShowImageBorders = true;
            this.ImageButtonCategories.ShowSizeMarkers = false;
            this.ImageButtonCategories.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonCategories.TabIndex = 10;
            this.ToolTip.SetToolTip(this.ImageButtonCategories, "");
            this.ToolTip.SetToolTipIcon(this.ImageButtonCategories, null);
            this.ImageButtonCategories.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonCategories, "");
            this.ImageButtonCategories.WaitOnLoad = false;
            this.ImageButtonCategories.Zoom = 0;
            this.ImageButtonCategories.ZoomSpeed = 10;
            this.ImageButtonCategories.Click += new System.EventHandler(this.ImageButtonCategories_Click);
            // 
            // ImageButtonDelete
            // 
            this.ImageButtonDelete.ActiveImage = null;
            this.ImageButtonDelete.AllowAnimations = true;
            this.ImageButtonDelete.AllowBuffering = false;
            this.ImageButtonDelete.AllowToggling = false;
            this.ImageButtonDelete.AllowZooming = true;
            this.ImageButtonDelete.AllowZoomingOnFocus = false;
            this.ImageButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonDelete.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonDelete.ErrorImage")));
            this.ImageButtonDelete.FadeWhenInactive = false;
            this.ImageButtonDelete.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonDelete.Image = global::PresentationLayer.InventoryManager.inventory_management_delete_filled;
            this.ImageButtonDelete.ImageActive = null;
            this.ImageButtonDelete.ImageLocation = null;
            this.ImageButtonDelete.ImageMargin = 0;
            this.ImageButtonDelete.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonDelete.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonDelete.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonDelete.InitialImage")));
            this.ImageButtonDelete.Location = new System.Drawing.Point(961, 10);
            this.ImageButtonDelete.Name = "ImageButtonDelete";
            this.ImageButtonDelete.Rotation = 0;
            this.ImageButtonDelete.ShowActiveImage = true;
            this.ImageButtonDelete.ShowCursorChanges = true;
            this.ImageButtonDelete.ShowImageBorders = true;
            this.ImageButtonDelete.ShowSizeMarkers = false;
            this.ImageButtonDelete.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonDelete.TabIndex = 10;
            this.ToolTip.SetToolTip(this.ImageButtonDelete, "");
            this.ToolTip.SetToolTipIcon(this.ImageButtonDelete, null);
            this.ImageButtonDelete.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonDelete, "");
            this.ImageButtonDelete.WaitOnLoad = false;
            this.ImageButtonDelete.Zoom = 0;
            this.ImageButtonDelete.ZoomSpeed = 10;
            this.ImageButtonDelete.Click += new System.EventHandler(this.ImageButtonDelete_Click);
            // 
            // ImageButtonEditProduct
            // 
            this.ImageButtonEditProduct.ActiveImage = null;
            this.ImageButtonEditProduct.AllowAnimations = true;
            this.ImageButtonEditProduct.AllowBuffering = false;
            this.ImageButtonEditProduct.AllowToggling = false;
            this.ImageButtonEditProduct.AllowZooming = true;
            this.ImageButtonEditProduct.AllowZoomingOnFocus = false;
            this.ImageButtonEditProduct.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonEditProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonEditProduct.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonEditProduct.ErrorImage")));
            this.ImageButtonEditProduct.FadeWhenInactive = false;
            this.ImageButtonEditProduct.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonEditProduct.Image = global::PresentationLayer.InventoryManager.inventory_management_edit_ebony;
            this.ImageButtonEditProduct.ImageActive = null;
            this.ImageButtonEditProduct.ImageLocation = null;
            this.ImageButtonEditProduct.ImageMargin = 0;
            this.ImageButtonEditProduct.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonEditProduct.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonEditProduct.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonEditProduct.InitialImage")));
            this.ImageButtonEditProduct.Location = new System.Drawing.Point(907, 10);
            this.ImageButtonEditProduct.Name = "ImageButtonEditProduct";
            this.ImageButtonEditProduct.Rotation = 0;
            this.ImageButtonEditProduct.ShowActiveImage = true;
            this.ImageButtonEditProduct.ShowCursorChanges = true;
            this.ImageButtonEditProduct.ShowImageBorders = true;
            this.ImageButtonEditProduct.ShowSizeMarkers = false;
            this.ImageButtonEditProduct.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonEditProduct.TabIndex = 10;
            this.ToolTip.SetToolTip(this.ImageButtonEditProduct, "Editar Producto");
            this.ToolTip.SetToolTipIcon(this.ImageButtonEditProduct, null);
            this.ImageButtonEditProduct.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonEditProduct, "Operación");
            this.ImageButtonEditProduct.WaitOnLoad = false;
            this.ImageButtonEditProduct.Zoom = 0;
            this.ImageButtonEditProduct.ZoomSpeed = 10;
            this.ImageButtonEditProduct.Click += new System.EventHandler(this.ImageButtonEditProduct_Click);
            // 
            // ImageButtonAddProduct
            // 
            this.ImageButtonAddProduct.ActiveImage = null;
            this.ImageButtonAddProduct.AllowAnimations = true;
            this.ImageButtonAddProduct.AllowBuffering = false;
            this.ImageButtonAddProduct.AllowToggling = false;
            this.ImageButtonAddProduct.AllowZooming = true;
            this.ImageButtonAddProduct.AllowZoomingOnFocus = false;
            this.ImageButtonAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonAddProduct.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonAddProduct.ErrorImage")));
            this.ImageButtonAddProduct.FadeWhenInactive = false;
            this.ImageButtonAddProduct.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonAddProduct.Image = global::PresentationLayer.InventoryManager.inventory_management_add_ebony;
            this.ImageButtonAddProduct.ImageActive = null;
            this.ImageButtonAddProduct.ImageLocation = null;
            this.ImageButtonAddProduct.ImageMargin = 0;
            this.ImageButtonAddProduct.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonAddProduct.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonAddProduct.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonAddProduct.InitialImage")));
            this.ImageButtonAddProduct.Location = new System.Drawing.Point(853, 10);
            this.ImageButtonAddProduct.Name = "ImageButtonAddProduct";
            this.ImageButtonAddProduct.Rotation = 0;
            this.ImageButtonAddProduct.ShowActiveImage = true;
            this.ImageButtonAddProduct.ShowCursorChanges = true;
            this.ImageButtonAddProduct.ShowImageBorders = true;
            this.ImageButtonAddProduct.ShowSizeMarkers = false;
            this.ImageButtonAddProduct.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonAddProduct.TabIndex = 9;
            this.ToolTip.SetToolTip(this.ImageButtonAddProduct, "Agregar Producto");
            this.ToolTip.SetToolTipIcon(this.ImageButtonAddProduct, null);
            this.ImageButtonAddProduct.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonAddProduct, "Operación");
            this.ImageButtonAddProduct.WaitOnLoad = false;
            this.ImageButtonAddProduct.Zoom = 0;
            this.ImageButtonAddProduct.ZoomSpeed = 10;
            this.ImageButtonAddProduct.Click += new System.EventHandler(this.ImageButtonAddProduct_Click);
            // 
            // ImageButtonOrderDescending
            // 
            this.ImageButtonOrderDescending.ActiveImage = null;
            this.ImageButtonOrderDescending.AllowAnimations = true;
            this.ImageButtonOrderDescending.AllowBuffering = false;
            this.ImageButtonOrderDescending.AllowToggling = false;
            this.ImageButtonOrderDescending.AllowZooming = true;
            this.ImageButtonOrderDescending.AllowZoomingOnFocus = false;
            this.ImageButtonOrderDescending.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonOrderDescending.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonOrderDescending.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonOrderDescending.ErrorImage")));
            this.ImageButtonOrderDescending.FadeWhenInactive = false;
            this.ImageButtonOrderDescending.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonOrderDescending.Image = global::PresentationLayer.InventoryManager.inventory_management_sort_descending_ebony;
            this.ImageButtonOrderDescending.ImageActive = null;
            this.ImageButtonOrderDescending.ImageLocation = null;
            this.ImageButtonOrderDescending.ImageMargin = 0;
            this.ImageButtonOrderDescending.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonOrderDescending.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonOrderDescending.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonOrderDescending.InitialImage")));
            this.ImageButtonOrderDescending.Location = new System.Drawing.Point(799, 10);
            this.ImageButtonOrderDescending.Name = "ImageButtonOrderDescending";
            this.ImageButtonOrderDescending.Rotation = 0;
            this.ImageButtonOrderDescending.ShowActiveImage = true;
            this.ImageButtonOrderDescending.ShowCursorChanges = true;
            this.ImageButtonOrderDescending.ShowImageBorders = true;
            this.ImageButtonOrderDescending.ShowSizeMarkers = false;
            this.ImageButtonOrderDescending.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonOrderDescending.TabIndex = 8;
            this.ToolTip.SetToolTip(this.ImageButtonOrderDescending, "Descendente");
            this.ToolTip.SetToolTipIcon(this.ImageButtonOrderDescending, null);
            this.ImageButtonOrderDescending.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonOrderDescending, "Ordenar");
            this.ImageButtonOrderDescending.WaitOnLoad = false;
            this.ImageButtonOrderDescending.Zoom = 0;
            this.ImageButtonOrderDescending.ZoomSpeed = 10;
            this.ImageButtonOrderDescending.Click += new System.EventHandler(this.ImageButtonOrderDescending_Click);
            // 
            // ImageButtonOrderAscending
            // 
            this.ImageButtonOrderAscending.ActiveImage = null;
            this.ImageButtonOrderAscending.AllowAnimations = true;
            this.ImageButtonOrderAscending.AllowBuffering = false;
            this.ImageButtonOrderAscending.AllowToggling = false;
            this.ImageButtonOrderAscending.AllowZooming = true;
            this.ImageButtonOrderAscending.AllowZoomingOnFocus = false;
            this.ImageButtonOrderAscending.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonOrderAscending.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonOrderAscending.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonOrderAscending.ErrorImage")));
            this.ImageButtonOrderAscending.FadeWhenInactive = false;
            this.ImageButtonOrderAscending.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonOrderAscending.Image = global::PresentationLayer.InventoryManager.inventory_management_sort_ascending_green;
            this.ImageButtonOrderAscending.ImageActive = null;
            this.ImageButtonOrderAscending.ImageLocation = null;
            this.ImageButtonOrderAscending.ImageMargin = 0;
            this.ImageButtonOrderAscending.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonOrderAscending.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonOrderAscending.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonOrderAscending.InitialImage")));
            this.ImageButtonOrderAscending.Location = new System.Drawing.Point(745, 10);
            this.ImageButtonOrderAscending.Name = "ImageButtonOrderAscending";
            this.ImageButtonOrderAscending.Rotation = 0;
            this.ImageButtonOrderAscending.ShowActiveImage = true;
            this.ImageButtonOrderAscending.ShowCursorChanges = true;
            this.ImageButtonOrderAscending.ShowImageBorders = true;
            this.ImageButtonOrderAscending.ShowSizeMarkers = false;
            this.ImageButtonOrderAscending.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonOrderAscending.TabIndex = 7;
            this.ToolTip.SetToolTip(this.ImageButtonOrderAscending, "Ascendente");
            this.ToolTip.SetToolTipIcon(this.ImageButtonOrderAscending, null);
            this.ImageButtonOrderAscending.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonOrderAscending, "Ordenar");
            this.ImageButtonOrderAscending.WaitOnLoad = false;
            this.ImageButtonOrderAscending.Zoom = 0;
            this.ImageButtonOrderAscending.ZoomSpeed = 10;
            this.ImageButtonOrderAscending.Click += new System.EventHandler(this.ImageButtonOrderAscending_Click);
            // 
            // ImageButtonSearchByStock
            // 
            this.ImageButtonSearchByStock.ActiveImage = null;
            this.ImageButtonSearchByStock.AllowAnimations = true;
            this.ImageButtonSearchByStock.AllowBuffering = false;
            this.ImageButtonSearchByStock.AllowToggling = false;
            this.ImageButtonSearchByStock.AllowZooming = true;
            this.ImageButtonSearchByStock.AllowZoomingOnFocus = false;
            this.ImageButtonSearchByStock.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonSearchByStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonSearchByStock.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchByStock.ErrorImage")));
            this.ImageButtonSearchByStock.FadeWhenInactive = false;
            this.ImageButtonSearchByStock.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonSearchByStock.Image = global::PresentationLayer.InventoryManager.inventory_management_stock_ebony;
            this.ImageButtonSearchByStock.ImageActive = null;
            this.ImageButtonSearchByStock.ImageLocation = null;
            this.ImageButtonSearchByStock.ImageMargin = 0;
            this.ImageButtonSearchByStock.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonSearchByStock.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchByStock.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchByStock.InitialImage")));
            this.ImageButtonSearchByStock.Location = new System.Drawing.Point(691, 10);
            this.ImageButtonSearchByStock.Name = "ImageButtonSearchByStock";
            this.ImageButtonSearchByStock.Rotation = 0;
            this.ImageButtonSearchByStock.ShowActiveImage = true;
            this.ImageButtonSearchByStock.ShowCursorChanges = true;
            this.ImageButtonSearchByStock.ShowImageBorders = true;
            this.ImageButtonSearchByStock.ShowSizeMarkers = false;
            this.ImageButtonSearchByStock.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchByStock.TabIndex = 6;
            this.ToolTip.SetToolTip(this.ImageButtonSearchByStock, "Existencias");
            this.ToolTip.SetToolTipIcon(this.ImageButtonSearchByStock, null);
            this.ImageButtonSearchByStock.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonSearchByStock, "Ordenar Por");
            this.ImageButtonSearchByStock.WaitOnLoad = false;
            this.ImageButtonSearchByStock.Zoom = 0;
            this.ImageButtonSearchByStock.ZoomSpeed = 10;
            this.ImageButtonSearchByStock.Click += new System.EventHandler(this.ImageButtonSearchByStock_Click);
            // 
            // ImageButtonSearchBySalePrice
            // 
            this.ImageButtonSearchBySalePrice.ActiveImage = null;
            this.ImageButtonSearchBySalePrice.AllowAnimations = true;
            this.ImageButtonSearchBySalePrice.AllowBuffering = false;
            this.ImageButtonSearchBySalePrice.AllowToggling = false;
            this.ImageButtonSearchBySalePrice.AllowZooming = true;
            this.ImageButtonSearchBySalePrice.AllowZoomingOnFocus = false;
            this.ImageButtonSearchBySalePrice.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonSearchBySalePrice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonSearchBySalePrice.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchBySalePrice.ErrorImage")));
            this.ImageButtonSearchBySalePrice.FadeWhenInactive = false;
            this.ImageButtonSearchBySalePrice.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonSearchBySalePrice.Image = global::PresentationLayer.InventoryManager.inventory_management_price_ebony;
            this.ImageButtonSearchBySalePrice.ImageActive = null;
            this.ImageButtonSearchBySalePrice.ImageLocation = null;
            this.ImageButtonSearchBySalePrice.ImageMargin = 0;
            this.ImageButtonSearchBySalePrice.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonSearchBySalePrice.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchBySalePrice.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchBySalePrice.InitialImage")));
            this.ImageButtonSearchBySalePrice.Location = new System.Drawing.Point(637, 10);
            this.ImageButtonSearchBySalePrice.Name = "ImageButtonSearchBySalePrice";
            this.ImageButtonSearchBySalePrice.Rotation = 0;
            this.ImageButtonSearchBySalePrice.ShowActiveImage = true;
            this.ImageButtonSearchBySalePrice.ShowCursorChanges = true;
            this.ImageButtonSearchBySalePrice.ShowImageBorders = true;
            this.ImageButtonSearchBySalePrice.ShowSizeMarkers = false;
            this.ImageButtonSearchBySalePrice.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchBySalePrice.TabIndex = 6;
            this.ToolTip.SetToolTip(this.ImageButtonSearchBySalePrice, "Precio Venta");
            this.ToolTip.SetToolTipIcon(this.ImageButtonSearchBySalePrice, null);
            this.ImageButtonSearchBySalePrice.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonSearchBySalePrice, "Ordenar Por");
            this.ImageButtonSearchBySalePrice.WaitOnLoad = false;
            this.ImageButtonSearchBySalePrice.Zoom = 0;
            this.ImageButtonSearchBySalePrice.ZoomSpeed = 10;
            this.ImageButtonSearchBySalePrice.Click += new System.EventHandler(this.ImageButtonSearchBySalePrice_Click);
            // 
            // ImageButtonDescription
            // 
            this.ImageButtonDescription.ActiveImage = null;
            this.ImageButtonDescription.AllowAnimations = true;
            this.ImageButtonDescription.AllowBuffering = false;
            this.ImageButtonDescription.AllowToggling = false;
            this.ImageButtonDescription.AllowZooming = true;
            this.ImageButtonDescription.AllowZoomingOnFocus = false;
            this.ImageButtonDescription.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonDescription.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonDescription.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonDescription.ErrorImage")));
            this.ImageButtonDescription.FadeWhenInactive = false;
            this.ImageButtonDescription.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonDescription.Image = global::PresentationLayer.InventoryManager.inventory_management_description;
            this.ImageButtonDescription.ImageActive = null;
            this.ImageButtonDescription.ImageLocation = null;
            this.ImageButtonDescription.ImageMargin = 0;
            this.ImageButtonDescription.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonDescription.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonDescription.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonDescription.InitialImage")));
            this.ImageButtonDescription.Location = new System.Drawing.Point(529, 10);
            this.ImageButtonDescription.Name = "ImageButtonDescription";
            this.ImageButtonDescription.Rotation = 0;
            this.ImageButtonDescription.ShowActiveImage = true;
            this.ImageButtonDescription.ShowCursorChanges = true;
            this.ImageButtonDescription.ShowImageBorders = true;
            this.ImageButtonDescription.ShowSizeMarkers = false;
            this.ImageButtonDescription.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonDescription.TabIndex = 4;
            this.ToolTip.SetToolTip(this.ImageButtonDescription, "");
            this.ToolTip.SetToolTipIcon(this.ImageButtonDescription, null);
            this.ImageButtonDescription.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonDescription, "");
            this.ImageButtonDescription.WaitOnLoad = false;
            this.ImageButtonDescription.Zoom = 0;
            this.ImageButtonDescription.ZoomSpeed = 10;
            this.ImageButtonDescription.Click += new System.EventHandler(this.ImageButtonDescription_Click);
            // 
            // ImageButtonSearchByCategory
            // 
            this.ImageButtonSearchByCategory.ActiveImage = null;
            this.ImageButtonSearchByCategory.AllowAnimations = true;
            this.ImageButtonSearchByCategory.AllowBuffering = false;
            this.ImageButtonSearchByCategory.AllowToggling = false;
            this.ImageButtonSearchByCategory.AllowZooming = true;
            this.ImageButtonSearchByCategory.AllowZoomingOnFocus = false;
            this.ImageButtonSearchByCategory.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonSearchByCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonSearchByCategory.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchByCategory.ErrorImage")));
            this.ImageButtonSearchByCategory.FadeWhenInactive = false;
            this.ImageButtonSearchByCategory.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonSearchByCategory.Image = global::PresentationLayer.InventoryManager.inventory_management_category_ebony;
            this.ImageButtonSearchByCategory.ImageActive = null;
            this.ImageButtonSearchByCategory.ImageLocation = null;
            this.ImageButtonSearchByCategory.ImageMargin = 0;
            this.ImageButtonSearchByCategory.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonSearchByCategory.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchByCategory.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchByCategory.InitialImage")));
            this.ImageButtonSearchByCategory.Location = new System.Drawing.Point(583, 10);
            this.ImageButtonSearchByCategory.Name = "ImageButtonSearchByCategory";
            this.ImageButtonSearchByCategory.Rotation = 0;
            this.ImageButtonSearchByCategory.ShowActiveImage = true;
            this.ImageButtonSearchByCategory.ShowCursorChanges = true;
            this.ImageButtonSearchByCategory.ShowImageBorders = true;
            this.ImageButtonSearchByCategory.ShowSizeMarkers = false;
            this.ImageButtonSearchByCategory.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchByCategory.TabIndex = 4;
            this.ToolTip.SetToolTip(this.ImageButtonSearchByCategory, "Categoria");
            this.ToolTip.SetToolTipIcon(this.ImageButtonSearchByCategory, null);
            this.ImageButtonSearchByCategory.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonSearchByCategory, "Ordenar Por");
            this.ImageButtonSearchByCategory.WaitOnLoad = false;
            this.ImageButtonSearchByCategory.Zoom = 0;
            this.ImageButtonSearchByCategory.ZoomSpeed = 10;
            this.ImageButtonSearchByCategory.Click += new System.EventHandler(this.ImageButtonSearchByCategory_Click);
            // 
            // ImageButtonSearchByProductName
            // 
            this.ImageButtonSearchByProductName.ActiveImage = null;
            this.ImageButtonSearchByProductName.AllowAnimations = true;
            this.ImageButtonSearchByProductName.AllowBuffering = false;
            this.ImageButtonSearchByProductName.AllowToggling = false;
            this.ImageButtonSearchByProductName.AllowZooming = true;
            this.ImageButtonSearchByProductName.AllowZoomingOnFocus = false;
            this.ImageButtonSearchByProductName.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonSearchByProductName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonSearchByProductName.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchByProductName.ErrorImage")));
            this.ImageButtonSearchByProductName.FadeWhenInactive = false;
            this.ImageButtonSearchByProductName.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonSearchByProductName.Image = global::PresentationLayer.InventoryManager.inventory_management_bag_fill_ebony;
            this.ImageButtonSearchByProductName.ImageActive = null;
            this.ImageButtonSearchByProductName.ImageLocation = null;
            this.ImageButtonSearchByProductName.ImageMargin = 0;
            this.ImageButtonSearchByProductName.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonSearchByProductName.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchByProductName.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchByProductName.InitialImage")));
            this.ImageButtonSearchByProductName.Location = new System.Drawing.Point(475, 10);
            this.ImageButtonSearchByProductName.Name = "ImageButtonSearchByProductName";
            this.ImageButtonSearchByProductName.Rotation = 0;
            this.ImageButtonSearchByProductName.ShowActiveImage = true;
            this.ImageButtonSearchByProductName.ShowCursorChanges = true;
            this.ImageButtonSearchByProductName.ShowImageBorders = true;
            this.ImageButtonSearchByProductName.ShowSizeMarkers = false;
            this.ImageButtonSearchByProductName.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchByProductName.TabIndex = 3;
            this.ToolTip.SetToolTip(this.ImageButtonSearchByProductName, "Nombre");
            this.ToolTip.SetToolTipIcon(this.ImageButtonSearchByProductName, null);
            this.ImageButtonSearchByProductName.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonSearchByProductName, "Ordenar Por");
            this.ImageButtonSearchByProductName.WaitOnLoad = false;
            this.ImageButtonSearchByProductName.Zoom = 0;
            this.ImageButtonSearchByProductName.ZoomSpeed = 10;
            this.ImageButtonSearchByProductName.Click += new System.EventHandler(this.ImageButtonSearchByProductName_Click);
            // 
            // ImageButtonSearchByID
            // 
            this.ImageButtonSearchByID.ActiveImage = null;
            this.ImageButtonSearchByID.AllowAnimations = true;
            this.ImageButtonSearchByID.AllowBuffering = false;
            this.ImageButtonSearchByID.AllowToggling = false;
            this.ImageButtonSearchByID.AllowZooming = true;
            this.ImageButtonSearchByID.AllowZoomingOnFocus = false;
            this.ImageButtonSearchByID.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonSearchByID.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonSearchByID.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchByID.ErrorImage")));
            this.ImageButtonSearchByID.FadeWhenInactive = false;
            this.ImageButtonSearchByID.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonSearchByID.Image = global::PresentationLayer.InventoryManager.inventory_management_id_button_ebony;
            this.ImageButtonSearchByID.ImageActive = null;
            this.ImageButtonSearchByID.ImageLocation = null;
            this.ImageButtonSearchByID.ImageMargin = 0;
            this.ImageButtonSearchByID.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonSearchByID.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchByID.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonSearchByID.InitialImage")));
            this.ImageButtonSearchByID.Location = new System.Drawing.Point(421, 10);
            this.ImageButtonSearchByID.Name = "ImageButtonSearchByID";
            this.ImageButtonSearchByID.Rotation = 0;
            this.ImageButtonSearchByID.ShowActiveImage = true;
            this.ImageButtonSearchByID.ShowCursorChanges = true;
            this.ImageButtonSearchByID.ShowImageBorders = true;
            this.ImageButtonSearchByID.ShowSizeMarkers = false;
            this.ImageButtonSearchByID.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonSearchByID.TabIndex = 2;
            this.ToolTip.SetToolTip(this.ImageButtonSearchByID, "ID");
            this.ToolTip.SetToolTipIcon(this.ImageButtonSearchByID, null);
            this.ImageButtonSearchByID.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonSearchByID, "Ordenar Por");
            this.ImageButtonSearchByID.WaitOnLoad = false;
            this.ImageButtonSearchByID.Zoom = 0;
            this.ImageButtonSearchByID.ZoomSpeed = 10;
            this.ImageButtonSearchByID.Click += new System.EventHandler(this.ImageButtonSearchByID_Click);
            // 
            // ImageButtonRefresh
            // 
            this.ImageButtonRefresh.ActiveImage = null;
            this.ImageButtonRefresh.AllowAnimations = true;
            this.ImageButtonRefresh.AllowBuffering = false;
            this.ImageButtonRefresh.AllowToggling = false;
            this.ImageButtonRefresh.AllowZooming = true;
            this.ImageButtonRefresh.AllowZoomingOnFocus = false;
            this.ImageButtonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonRefresh.ErrorImage")));
            this.ImageButtonRefresh.FadeWhenInactive = false;
            this.ImageButtonRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonRefresh.Image = global::PresentationLayer.InventoryManager.inventory_management_update_ebony;
            this.ImageButtonRefresh.ImageActive = null;
            this.ImageButtonRefresh.ImageLocation = null;
            this.ImageButtonRefresh.ImageMargin = 0;
            this.ImageButtonRefresh.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonRefresh.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ImageButtonRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonRefresh.InitialImage")));
            this.ImageButtonRefresh.Location = new System.Drawing.Point(367, 10);
            this.ImageButtonRefresh.Name = "ImageButtonRefresh";
            this.ImageButtonRefresh.Rotation = 0;
            this.ImageButtonRefresh.ShowActiveImage = true;
            this.ImageButtonRefresh.ShowCursorChanges = true;
            this.ImageButtonRefresh.ShowImageBorders = true;
            this.ImageButtonRefresh.ShowSizeMarkers = false;
            this.ImageButtonRefresh.Size = new System.Drawing.Size(40, 40);
            this.ImageButtonRefresh.TabIndex = 1;
            this.ToolTip.SetToolTip(this.ImageButtonRefresh, "Restablecer");
            this.ToolTip.SetToolTipIcon(this.ImageButtonRefresh, null);
            this.ImageButtonRefresh.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.ImageButtonRefresh, "");
            this.ImageButtonRefresh.WaitOnLoad = false;
            this.ImageButtonRefresh.Zoom = 0;
            this.ImageButtonRefresh.ZoomSpeed = 10;
            this.ImageButtonRefresh.Click += new System.EventHandler(this.ImageButtonRefresh_Click);
            // 
            // PictureBoxSearch
            // 
            this.PictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSearch.Image")));
            this.PictureBoxSearch.Location = new System.Drawing.Point(7, 9);
            this.PictureBoxSearch.Name = "PictureBoxSearch";
            this.PictureBoxSearch.Size = new System.Drawing.Size(350, 44);
            this.PictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxSearch.TabIndex = 0;
            this.PictureBoxSearch.TabStop = false;
            this.ToolTip.SetToolTip(this.PictureBoxSearch, "");
            this.ToolTip.SetToolTipIcon(this.PictureBoxSearch, null);
            this.ToolTip.SetToolTipTitle(this.PictureBoxSearch, "");
            // 
            // FormInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1062, 706);
            this.Controls.Add(this.DataGridViewInventoryManagament);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ImageButtonCategories);
            this.Controls.Add(this.ImageButtonDelete);
            this.Controls.Add(this.ImageButtonEditProduct);
            this.Controls.Add(this.ImageButtonAddProduct);
            this.Controls.Add(this.ImageButtonOrderDescending);
            this.Controls.Add(this.ImageButtonOrderAscending);
            this.Controls.Add(this.ImageButtonSearchByStock);
            this.Controls.Add(this.ImageButtonSearchBySalePrice);
            this.Controls.Add(this.ImageButtonDescription);
            this.Controls.Add(this.ImageButtonSearchByCategory);
            this.Controls.Add(this.ImageButtonSearchByProductName);
            this.Controls.Add(this.ImageButtonSearchByID);
            this.Controls.Add(this.ImageButtonRefresh);
            this.Controls.Add(this.PictureBoxSearch);
            this.Font = new System.Drawing.Font("Mulish", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventoryManagement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormInventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInventoryManagament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxSearch;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonSearchByID;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonSearchByProductName;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonSearchByCategory;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonSearchBySalePrice;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonOrderAscending;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonOrderDescending;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonAddProduct;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonEditProduct;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridViewInventoryManagament;
        private Bunifu.UI.WinForms.BunifuToolTip ToolTip;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonSearchByStock;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonDescription;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonDelete;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonCategories;
    }
}