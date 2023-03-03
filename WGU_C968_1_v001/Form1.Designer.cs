namespace WGU_C968_1_v001
{
    partial class Inventory
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
            this.lbl_Parts = new System.Windows.Forms.Label();
            this.lbl_Products = new System.Windows.Forms.Label();
            this.lbl_MainTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Parts
            // 
            this.lbl_Parts.AutoSize = true;
            this.lbl_Parts.Font = new System.Drawing.Font("Bahnschrift SemiBold", 17.875F);
            this.lbl_Parts.Location = new System.Drawing.Point(22, 193);
            this.lbl_Parts.Name = "lbl_Parts";
            this.lbl_Parts.Size = new System.Drawing.Size(141, 58);
            this.lbl_Parts.TabIndex = 1;
            this.lbl_Parts.Text = "Parts";
            this.lbl_Parts.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Products
            // 
            this.lbl_Products.AutoSize = true;
            this.lbl_Products.Font = new System.Drawing.Font("Bahnschrift SemiBold", 17.875F);
            this.lbl_Products.Location = new System.Drawing.Point(869, 199);
            this.lbl_Products.Name = "lbl_Products";
            this.lbl_Products.Size = new System.Drawing.Size(218, 58);
            this.lbl_Products.TabIndex = 2;
            this.lbl_Products.Text = "Products";
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.AutoSize = true;
            this.lbl_MainTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.875F);
            this.lbl_MainTitle.Location = new System.Drawing.Point(677, 45);
            this.lbl_MainTitle.Name = "lbl_MainTitle";
            this.lbl_MainTitle.Size = new System.Drawing.Size(292, 42);
            this.lbl_MainTitle.TabIndex = 3;
            this.lbl_MainTitle.Text = "Inventory System";
            this.lbl_MainTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(32, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(802, 327);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(879, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(802, 327);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // txt_PartSearch
            // 
            this.txt_PartSearch.Location = new System.Drawing.Point(649, 210);
            this.txt_PartSearch.Name = "txt_PartSearch";
            this.txt_PartSearch.Size = new System.Drawing.Size(185, 31);
            this.txt_PartSearch.TabIndex = 6;
            // 
            // btn_PartSearch
            // 
            this.btn_PartSearch.Location = new System.Drawing.Point(522, 204);
            this.btn_PartSearch.Name = "btn_PartSearch";
            this.btn_PartSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btn_PartSearch.Size = new System.Drawing.Size(121, 48);
            this.btn_PartSearch.TabIndex = 7;
            this.btn_PartSearch.Text = "Search";
            this.btn_PartSearch.UseVisualStyleBackColor = true;
            // 
            // btn_ProductSearch
            // 
            this.btn_ProductSearch.Location = new System.Drawing.Point(1356, 193);
            this.btn_ProductSearch.Name = "btn_ProductSearch";
            this.btn_ProductSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btn_ProductSearch.Size = new System.Drawing.Size(121, 48);
            this.btn_ProductSearch.TabIndex = 9;
            this.btn_ProductSearch.Text = "Search";
            this.btn_ProductSearch.UseVisualStyleBackColor = true;
            // 
            // txt_ProductSearch
            // 
            this.txt_ProductSearch.Location = new System.Drawing.Point(1483, 199);
            this.txt_ProductSearch.Name = "txt_ProductSearch";
            this.txt_ProductSearch.Size = new System.Drawing.Size(185, 31);
            this.txt_ProductSearch.TabIndex = 8;
            // 
            // btn_PartsAdd
            // 
            this.btn_PartsAdd.Location = new System.Drawing.Point(447, 640);
            this.btn_PartsAdd.Name = "btn_PartsAdd";
            this.btn_PartsAdd.Size = new System.Drawing.Size(125, 50);
            this.btn_PartsAdd.TabIndex = 10;
            this.btn_PartsAdd.Text = "Add";
            this.btn_PartsAdd.UseVisualStyleBackColor = true;
            // 
            // Btn_PartsModify
            // 
            this.Btn_PartsModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_PartsModify.Location = new System.Drawing.Point(578, 640);
            this.Btn_PartsModify.Name = "Btn_PartsModify";
            this.Btn_PartsModify.Size = new System.Drawing.Size(125, 50);
            this.Btn_PartsModify.TabIndex = 11;
            this.Btn_PartsModify.Text = "Modify";
            this.Btn_PartsModify.UseVisualStyleBackColor = true;
            // 
            // Btn_PartsDelete
            // 
            this.Btn_PartsDelete.Location = new System.Drawing.Point(709, 640);
            this.Btn_PartsDelete.Name = "Btn_PartsDelete";
            this.Btn_PartsDelete.Size = new System.Drawing.Size(125, 50);
            this.Btn_PartsDelete.TabIndex = 12;
            this.Btn_PartsDelete.Text = "Delete";
            this.Btn_PartsDelete.UseVisualStyleBackColor = true;
            // 
            // btn_ProductsAdd
            // 
            this.btn_ProductsAdd.Location = new System.Drawing.Point(1294, 640);
            this.btn_ProductsAdd.Name = "btn_ProductsAdd";
            this.btn_ProductsAdd.Size = new System.Drawing.Size(125, 50);
            this.btn_ProductsAdd.TabIndex = 13;
            this.btn_ProductsAdd.Text = "Add";
            this.btn_ProductsAdd.UseVisualStyleBackColor = true;
            // 
            // btn_ProductsModify
            // 
            this.btn_ProductsModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ProductsModify.Location = new System.Drawing.Point(1425, 640);
            this.btn_ProductsModify.Name = "btn_ProductsModify";
            this.btn_ProductsModify.Size = new System.Drawing.Size(125, 50);
            this.btn_ProductsModify.TabIndex = 14;
            this.btn_ProductsModify.Text = "Modify";
            this.btn_ProductsModify.UseVisualStyleBackColor = true;
            // 
            // btn_ProductsDelete
            // 
            this.btn_ProductsDelete.Location = new System.Drawing.Point(1556, 640);
            this.btn_ProductsDelete.Name = "btn_ProductsDelete";
            this.btn_ProductsDelete.Size = new System.Drawing.Size(125, 50);
            this.btn_ProductsDelete.TabIndex = 15;
            this.btn_ProductsDelete.Text = "Delete";
            this.btn_ProductsDelete.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 876);
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
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_MainTitle);
            this.Controls.Add(this.lbl_Products);
            this.Controls.Add(this.lbl_Parts);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Inventory System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Parts;
        private System.Windows.Forms.Label lbl_Products;
        private System.Windows.Forms.Label lbl_MainTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
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
    }
}

