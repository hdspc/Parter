namespace WGU_C968_1_v001
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Parts = new System.Windows.Forms.Label();
            this.lbl_Products = new System.Windows.Forms.Label();
            this.lbl_MainTitle = new System.Windows.Forms.Label();
            this.dgv_PartsGrid = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_ProductsGrid = new System.Windows.Forms.DataGridView();
            this.txt_PartSearch = new System.Windows.Forms.TextBox();
            this.btn_PartSearch = new System.Windows.Forms.Button();
            this.btn_ProductSearch = new System.Windows.Forms.Button();
            this.txt_ProductSearch = new System.Windows.Forms.TextBox();
            this.btn_PartsAdd = new System.Windows.Forms.Button();
            this.Btn_PartsModify = new System.Windows.Forms.Button();
            this.Btn_PartsDelete = new System.Windows.Forms.Button();
            this.btn_ProductsAdd = new System.Windows.Forms.Button();
            this.btn_ProductsModify = new System.Windows.Forms.Button();
            this.btn_ProductsDelete = new System.Windows.Forms.Button();
            this.btn_Main_Exit = new System.Windows.Forms.Button();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Parts
            // 
            this.lbl_Parts.AutoSize = true;
            this.lbl_Parts.Font = new System.Drawing.Font("Segoe UI", 17.875F);
            this.lbl_Parts.Location = new System.Drawing.Point(30, 193);
            this.lbl_Parts.Name = "lbl_Parts";
            this.lbl_Parts.Size = new System.Drawing.Size(130, 65);
            this.lbl_Parts.TabIndex = 1;
            this.lbl_Parts.Text = "Parts";
            // 
            // lbl_Products
            // 
            this.lbl_Products.AutoSize = true;
            this.lbl_Products.Font = new System.Drawing.Font("Segoe UI", 17.875F);
            this.lbl_Products.Location = new System.Drawing.Point(868, 184);
            this.lbl_Products.Name = "lbl_Products";
            this.lbl_Products.Size = new System.Drawing.Size(213, 65);
            this.lbl_Products.TabIndex = 2;
            this.lbl_Products.Text = "Products";
            this.lbl_Products.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.AutoSize = true;
            this.lbl_MainTitle.Font = new System.Drawing.Font("Segoe UI", 12.875F);
            this.lbl_MainTitle.Location = new System.Drawing.Point(726, 99);
            this.lbl_MainTitle.Name = "lbl_MainTitle";
            this.lbl_MainTitle.Size = new System.Drawing.Size(286, 47);
            this.lbl_MainTitle.TabIndex = 3;
            this.lbl_MainTitle.Text = "Inventory System";
            // 
            // dgv_PartsGrid
            // 
            this.dgv_PartsGrid.AutoGenerateColumns = false;
            this.dgv_PartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PartsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.dgv_PartsGrid.DataSource = this.partBindingSource3;
            this.dgv_PartsGrid.Location = new System.Drawing.Point(30, 284);
            this.dgv_PartsGrid.Name = "dgv_PartsGrid";
            this.dgv_PartsGrid.RowHeadersWidth = 82;
            this.dgv_PartsGrid.RowTemplate.Height = 33;
            this.dgv_PartsGrid.Size = new System.Drawing.Size(802, 327);
            this.dgv_PartsGrid.TabIndex = 4;
            this.dgv_PartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.dgv_PartsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CompletedBinding);
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            this.partIDDataGridViewTextBoxColumn.Width = 116;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.Width = 200;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.Width = 200;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.Width = 200;
            // 
            // partBindingSource3
            // 
            this.partBindingSource3.DataSource = typeof(WGU_C968_1_v001.Part);
            // 
            // dgv_ProductsGrid
            // 
            this.dgv_ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductsGrid.Location = new System.Drawing.Point(879, 284);
            this.dgv_ProductsGrid.Name = "dgv_ProductsGrid";
            this.dgv_ProductsGrid.RowHeadersWidth = 82;
            this.dgv_ProductsGrid.RowTemplate.Height = 33;
            this.dgv_ProductsGrid.Size = new System.Drawing.Size(802, 327);
            this.dgv_ProductsGrid.TabIndex = 5;
            // 
            // txt_PartSearch
            // 
            this.txt_PartSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_PartSearch.Location = new System.Drawing.Point(647, 205);
            this.txt_PartSearch.Name = "txt_PartSearch";
            this.txt_PartSearch.Size = new System.Drawing.Size(185, 44);
            this.txt_PartSearch.TabIndex = 6;
            // 
            // btn_PartSearch
            // 
            this.btn_PartSearch.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btn_PartSearch.Location = new System.Drawing.Point(509, 204);
            this.btn_PartSearch.Name = "btn_PartSearch";
            this.btn_PartSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btn_PartSearch.Size = new System.Drawing.Size(121, 48);
            this.btn_PartSearch.TabIndex = 7;
            this.btn_PartSearch.Text = "Search";
            this.btn_PartSearch.UseVisualStyleBackColor = true;
            this.btn_PartSearch.Click += new System.EventHandler(this.btn_PartSearch_Click);
            // 
            // btn_ProductSearch
            // 
            this.btn_ProductSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_ProductSearch.Location = new System.Drawing.Point(1346, 204);
            this.btn_ProductSearch.Name = "btn_ProductSearch";
            this.btn_ProductSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btn_ProductSearch.Size = new System.Drawing.Size(121, 48);
            this.btn_ProductSearch.TabIndex = 9;
            this.btn_ProductSearch.Text = "Search";
            this.btn_ProductSearch.UseVisualStyleBackColor = true;
            this.btn_ProductSearch.Click += new System.EventHandler(this.btn_ProductSearch_Click);
            // 
            // txt_ProductSearch
            // 
            this.txt_ProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ProductSearch.Location = new System.Drawing.Point(1489, 204);
            this.txt_ProductSearch.Name = "txt_ProductSearch";
            this.txt_ProductSearch.Size = new System.Drawing.Size(192, 44);
            this.txt_ProductSearch.TabIndex = 8;
            // 
            // btn_PartsAdd
            // 
            this.btn_PartsAdd.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.btn_PartsAdd.Location = new System.Drawing.Point(445, 653);
            this.btn_PartsAdd.Name = "btn_PartsAdd";
            this.btn_PartsAdd.Size = new System.Drawing.Size(125, 50);
            this.btn_PartsAdd.TabIndex = 10;
            this.btn_PartsAdd.Text = "Add";
            this.btn_PartsAdd.UseVisualStyleBackColor = true;
            this.btn_PartsAdd.Click += new System.EventHandler(this.btn_AddPart_Click);
            // 
            // Btn_PartsModify
            // 
            this.Btn_PartsModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_PartsModify.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.Btn_PartsModify.Location = new System.Drawing.Point(576, 653);
            this.Btn_PartsModify.Name = "Btn_PartsModify";
            this.Btn_PartsModify.Size = new System.Drawing.Size(125, 50);
            this.Btn_PartsModify.TabIndex = 11;
            this.Btn_PartsModify.Text = "Modify";
            this.Btn_PartsModify.UseVisualStyleBackColor = true;
            this.Btn_PartsModify.Click += new System.EventHandler(this.Btn_PartsModify_Click);
            // 
            // Btn_PartsDelete
            // 
            this.Btn_PartsDelete.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.Btn_PartsDelete.Location = new System.Drawing.Point(707, 653);
            this.Btn_PartsDelete.Name = "Btn_PartsDelete";
            this.Btn_PartsDelete.Size = new System.Drawing.Size(125, 50);
            this.Btn_PartsDelete.TabIndex = 12;
            this.Btn_PartsDelete.Text = "Delete";
            this.Btn_PartsDelete.UseVisualStyleBackColor = true;
            this.Btn_PartsDelete.Click += new System.EventHandler(this.Btn_PartsDelete_Click);
            // 
            // btn_ProductsAdd
            // 
            this.btn_ProductsAdd.AutoSize = true;
            this.btn_ProductsAdd.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.btn_ProductsAdd.Location = new System.Drawing.Point(1294, 653);
            this.btn_ProductsAdd.Name = "btn_ProductsAdd";
            this.btn_ProductsAdd.Size = new System.Drawing.Size(125, 50);
            this.btn_ProductsAdd.TabIndex = 13;
            this.btn_ProductsAdd.Text = "Add";
            this.btn_ProductsAdd.UseVisualStyleBackColor = true;
            this.btn_ProductsAdd.Click += new System.EventHandler(this.btn_ProductsAdd_Click);
            // 
            // btn_ProductsModify
            // 
            this.btn_ProductsModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ProductsModify.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.btn_ProductsModify.Location = new System.Drawing.Point(1425, 653);
            this.btn_ProductsModify.Name = "btn_ProductsModify";
            this.btn_ProductsModify.Size = new System.Drawing.Size(125, 50);
            this.btn_ProductsModify.TabIndex = 14;
            this.btn_ProductsModify.Text = "Modify";
            this.btn_ProductsModify.UseVisualStyleBackColor = true;
            this.btn_ProductsModify.Click += new System.EventHandler(this.btn_ProductsModify_Click);
            // 
            // btn_ProductsDelete
            // 
            this.btn_ProductsDelete.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.btn_ProductsDelete.Location = new System.Drawing.Point(1556, 653);
            this.btn_ProductsDelete.Name = "btn_ProductsDelete";
            this.btn_ProductsDelete.Size = new System.Drawing.Size(125, 50);
            this.btn_ProductsDelete.TabIndex = 15;
            this.btn_ProductsDelete.Text = "Delete";
            this.btn_ProductsDelete.UseVisualStyleBackColor = true;
            this.btn_ProductsDelete.Click += new System.EventHandler(this.btn_ProductsDelete_Click);
            // 
            // btn_Main_Exit
            // 
            this.btn_Main_Exit.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.btn_Main_Exit.Location = new System.Drawing.Point(820, 787);
            this.btn_Main_Exit.Name = "btn_Main_Exit";
            this.btn_Main_Exit.Size = new System.Drawing.Size(125, 57);
            this.btn_Main_Exit.TabIndex = 16;
            this.btn_Main_Exit.Text = "Exit";
            this.btn_Main_Exit.UseVisualStyleBackColor = true;
            this.btn_Main_Exit.Click += new System.EventHandler(this.btn_Main_Exit_Click);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(WGU_C968_1_v001.Part);
            // 
            // partBindingSource1
            // 
            this.partBindingSource1.DataSource = typeof(WGU_C968_1_v001.Part);
            // 
            // partBindingSource2
            // 
            this.partBindingSource2.DataSource = typeof(WGU_C968_1_v001.Part);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.label1.Location = new System.Drawing.Point(1494, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Galen Forrest C968";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1728, 876);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Main_Exit);
            this.Controls.Add(this.btn_ProductsDelete);
            this.Controls.Add(this.btn_ProductsModify);
            this.Controls.Add(this.btn_ProductsAdd);
            this.Controls.Add(this.Btn_PartsDelete);
            this.Controls.Add(this.Btn_PartsModify);
            this.Controls.Add(this.btn_PartsAdd);
            this.Controls.Add(this.btn_ProductSearch);
            this.Controls.Add(this.txt_ProductSearch);
            this.Controls.Add(this.btn_PartSearch);
            this.Controls.Add(this.txt_PartSearch);
            this.Controls.Add(this.dgv_ProductsGrid);
            this.Controls.Add(this.dgv_PartsGrid);
            this.Controls.Add(this.lbl_MainTitle);
            this.Controls.Add(this.lbl_Products);
            this.Controls.Add(this.lbl_Parts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Text = "Inventory System";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Parts;
        private System.Windows.Forms.Label lbl_Products;
        private System.Windows.Forms.Label lbl_MainTitle;
        private System.Windows.Forms.DataGridView dgv_PartsGrid;
        private System.Windows.Forms.DataGridView dgv_ProductsGrid;
        private System.Windows.Forms.TextBox txt_PartSearch;
        private System.Windows.Forms.Button btn_PartSearch;
        private System.Windows.Forms.Button btn_ProductSearch;
        private System.Windows.Forms.TextBox txt_ProductSearch;
        private System.Windows.Forms.Button btn_PartsAdd;
        private System.Windows.Forms.Button Btn_PartsModify;
        private System.Windows.Forms.Button Btn_PartsDelete;
        private System.Windows.Forms.Button btn_ProductsAdd;
        private System.Windows.Forms.Button btn_ProductsModify;
        private System.Windows.Forms.Button btn_ProductsDelete;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource partBindingSource1;
        private System.Windows.Forms.BindingSource partBindingSource2;
        private System.Windows.Forms.BindingSource partBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Main_Exit;
        private System.Windows.Forms.Label label1;
    }
}

