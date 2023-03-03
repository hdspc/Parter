namespace WGU_C968_1_v001
{
    partial class AddProduct
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
            this.txt_AddProduct_ID = new System.Windows.Forms.TextBox();
            this.lbl_AddProduct_ID = new System.Windows.Forms.Label();
            this.lbl_AddProduct_Name = new System.Windows.Forms.Label();
            this.lbl_AddProduct_Inventory = new System.Windows.Forms.Label();
            this.lbl_AddProduct_Price = new System.Windows.Forms.Label();
            this.lbl_AddProduct_Max = new System.Windows.Forms.Label();
            this.lbl_AddProduct_Min = new System.Windows.Forms.Label();
            this.txt_AddProduct_Name = new System.Windows.Forms.TextBox();
            this.txt_AddProduct_Inventory = new System.Windows.Forms.TextBox();
            this.txt_AddProduct_Price = new System.Windows.Forms.TextBox();
            this.txt_AddProduct_Max = new System.Windows.Forms.TextBox();
            this.txt_NewPart_Min = new System.Windows.Forms.TextBox();
            this.btn_AddProduct_Save = new System.Windows.Forms.Button();
            this.btn_AddProduct_Cancel = new System.Windows.Forms.Button();
            this.lbl_AddProduct_CandidateParts = new System.Windows.Forms.Label();
            this.lbl_AddProduct_PartsAssociated = new System.Windows.Forms.Label();
            this.btn_AddProduct_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddProduct_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_AddProduct_Title = new System.Windows.Forms.Label();
            this.btn_AddProduct_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_AddProduct_ID
            // 
            this.txt_AddProduct_ID.Location = new System.Drawing.Point(303, 206);
            this.txt_AddProduct_ID.Name = "txt_AddProduct_ID";
            this.txt_AddProduct_ID.Size = new System.Drawing.Size(188, 31);
            this.txt_AddProduct_ID.TabIndex = 2;
            // 
            // lbl_AddProduct_ID
            // 
            this.lbl_AddProduct_ID.AutoSize = true;
            this.lbl_AddProduct_ID.Location = new System.Drawing.Point(175, 209);
            this.lbl_AddProduct_ID.Name = "lbl_AddProduct_ID";
            this.lbl_AddProduct_ID.Size = new System.Drawing.Size(32, 25);
            this.lbl_AddProduct_ID.TabIndex = 3;
            this.lbl_AddProduct_ID.Text = "ID";
            this.lbl_AddProduct_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_AddProduct_Name
            // 
            this.lbl_AddProduct_Name.AutoSize = true;
            this.lbl_AddProduct_Name.Location = new System.Drawing.Point(175, 285);
            this.lbl_AddProduct_Name.Name = "lbl_AddProduct_Name";
            this.lbl_AddProduct_Name.Size = new System.Drawing.Size(68, 25);
            this.lbl_AddProduct_Name.TabIndex = 4;
            this.lbl_AddProduct_Name.Text = "Name";
            // 
            // lbl_AddProduct_Inventory
            // 
            this.lbl_AddProduct_Inventory.AutoSize = true;
            this.lbl_AddProduct_Inventory.Location = new System.Drawing.Point(175, 363);
            this.lbl_AddProduct_Inventory.Name = "lbl_AddProduct_Inventory";
            this.lbl_AddProduct_Inventory.Size = new System.Drawing.Size(100, 25);
            this.lbl_AddProduct_Inventory.TabIndex = 5;
            this.lbl_AddProduct_Inventory.Text = "Inventory";
            this.lbl_AddProduct_Inventory.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_AddProduct_Price
            // 
            this.lbl_AddProduct_Price.AutoSize = true;
            this.lbl_AddProduct_Price.Location = new System.Drawing.Point(175, 441);
            this.lbl_AddProduct_Price.Name = "lbl_AddProduct_Price";
            this.lbl_AddProduct_Price.Size = new System.Drawing.Size(111, 25);
            this.lbl_AddProduct_Price.TabIndex = 6;
            this.lbl_AddProduct_Price.Text = "Price/Cost";
            // 
            // lbl_AddProduct_Max
            // 
            this.lbl_AddProduct_Max.AutoSize = true;
            this.lbl_AddProduct_Max.Location = new System.Drawing.Point(175, 537);
            this.lbl_AddProduct_Max.Name = "lbl_AddProduct_Max";
            this.lbl_AddProduct_Max.Size = new System.Drawing.Size(53, 25);
            this.lbl_AddProduct_Max.TabIndex = 7;
            this.lbl_AddProduct_Max.Text = "Max";
            // 
            // lbl_AddProduct_Min
            // 
            this.lbl_AddProduct_Min.AutoSize = true;
            this.lbl_AddProduct_Min.Location = new System.Drawing.Point(524, 537);
            this.lbl_AddProduct_Min.Name = "lbl_AddProduct_Min";
            this.lbl_AddProduct_Min.Size = new System.Drawing.Size(47, 25);
            this.lbl_AddProduct_Min.TabIndex = 8;
            this.lbl_AddProduct_Min.Text = "Min";
            // 
            // txt_AddProduct_Name
            // 
            this.txt_AddProduct_Name.Location = new System.Drawing.Point(303, 285);
            this.txt_AddProduct_Name.Name = "txt_AddProduct_Name";
            this.txt_AddProduct_Name.Size = new System.Drawing.Size(188, 31);
            this.txt_AddProduct_Name.TabIndex = 11;
            // 
            // txt_AddProduct_Inventory
            // 
            this.txt_AddProduct_Inventory.Location = new System.Drawing.Point(303, 363);
            this.txt_AddProduct_Inventory.Name = "txt_AddProduct_Inventory";
            this.txt_AddProduct_Inventory.Size = new System.Drawing.Size(188, 31);
            this.txt_AddProduct_Inventory.TabIndex = 12;
            // 
            // txt_AddProduct_Price
            // 
            this.txt_AddProduct_Price.Location = new System.Drawing.Point(303, 435);
            this.txt_AddProduct_Price.Name = "txt_AddProduct_Price";
            this.txt_AddProduct_Price.Size = new System.Drawing.Size(188, 31);
            this.txt_AddProduct_Price.TabIndex = 13;
            // 
            // txt_AddProduct_Max
            // 
            this.txt_AddProduct_Max.Location = new System.Drawing.Point(303, 537);
            this.txt_AddProduct_Max.Name = "txt_AddProduct_Max";
            this.txt_AddProduct_Max.Size = new System.Drawing.Size(188, 31);
            this.txt_AddProduct_Max.TabIndex = 14;
            // 
            // txt_NewPart_Min
            // 
            this.txt_NewPart_Min.Location = new System.Drawing.Point(577, 537);
            this.txt_NewPart_Min.Name = "txt_NewPart_Min";
            this.txt_NewPart_Min.Size = new System.Drawing.Size(188, 31);
            this.txt_NewPart_Min.TabIndex = 15;
            // 
            // btn_AddProduct_Save
            // 
            this.btn_AddProduct_Save.Location = new System.Drawing.Point(1322, 870);
            this.btn_AddProduct_Save.Name = "btn_AddProduct_Save";
            this.btn_AddProduct_Save.Size = new System.Drawing.Size(177, 65);
            this.btn_AddProduct_Save.TabIndex = 17;
            this.btn_AddProduct_Save.Text = "Save";
            this.btn_AddProduct_Save.UseVisualStyleBackColor = true;
            // 
            // btn_AddProduct_Cancel
            // 
            this.btn_AddProduct_Cancel.Location = new System.Drawing.Point(1532, 870);
            this.btn_AddProduct_Cancel.Name = "btn_AddProduct_Cancel";
            this.btn_AddProduct_Cancel.Size = new System.Drawing.Size(177, 65);
            this.btn_AddProduct_Cancel.TabIndex = 18;
            this.btn_AddProduct_Cancel.Text = "Cancel";
            this.btn_AddProduct_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_AddProduct_CandidateParts
            // 
            this.lbl_AddProduct_CandidateParts.AutoSize = true;
            this.lbl_AddProduct_CandidateParts.Location = new System.Drawing.Point(986, 135);
            this.lbl_AddProduct_CandidateParts.Name = "lbl_AddProduct_CandidateParts";
            this.lbl_AddProduct_CandidateParts.Size = new System.Drawing.Size(190, 25);
            this.lbl_AddProduct_CandidateParts.TabIndex = 19;
            this.lbl_AddProduct_CandidateParts.Text = "All candidate parts";
            // 
            // lbl_AddProduct_PartsAssociated
            // 
            this.lbl_AddProduct_PartsAssociated.AutoSize = true;
            this.lbl_AddProduct_PartsAssociated.Location = new System.Drawing.Point(986, 441);
            this.lbl_AddProduct_PartsAssociated.Name = "lbl_AddProduct_PartsAssociated";
            this.lbl_AddProduct_PartsAssociated.Size = new System.Drawing.Size(334, 25);
            this.lbl_AddProduct_PartsAssociated.TabIndex = 20;
            this.lbl_AddProduct_PartsAssociated.Text = "Parts associated with this product";
            // 
            // btn_AddProduct_Delete
            // 
            this.btn_AddProduct_Delete.Location = new System.Drawing.Point(1532, 761);
            this.btn_AddProduct_Delete.Name = "btn_AddProduct_Delete";
            this.btn_AddProduct_Delete.Size = new System.Drawing.Size(177, 65);
            this.btn_AddProduct_Delete.TabIndex = 21;
            this.btn_AddProduct_Delete.Text = "Delete";
            this.btn_AddProduct_Delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(991, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(694, 150);
            this.dataGridView1.TabIndex = 22;
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
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(991, 515);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(694, 150);
            this.dataGridView2.TabIndex = 23;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // btn_AddProduct_Search
            // 
            this.btn_AddProduct_Search.Location = new System.Drawing.Point(9, 28);
            this.btn_AddProduct_Search.Name = "btn_AddProduct_Search";
            this.btn_AddProduct_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_AddProduct_Search.Size = new System.Drawing.Size(108, 45);
            this.btn_AddProduct_Search.TabIndex = 24;
            this.btn_AddProduct_Search.Text = "Search";
            this.btn_AddProduct_Search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 45);
            this.textBox1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_AddProduct_Search);
            this.groupBox1.Location = new System.Drawing.Point(1298, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 79);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lbl_AddProduct_Title
            // 
            this.lbl_AddProduct_Title.AutoSize = true;
            this.lbl_AddProduct_Title.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddProduct_Title.Location = new System.Drawing.Point(172, 53);
            this.lbl_AddProduct_Title.Name = "lbl_AddProduct_Title";
            this.lbl_AddProduct_Title.Size = new System.Drawing.Size(241, 48);
            this.lbl_AddProduct_Title.TabIndex = 27;
            this.lbl_AddProduct_Title.Text = "Add Product";
            // 
            // btn_AddProduct_Add
            // 
            this.btn_AddProduct_Add.Location = new System.Drawing.Point(1508, 418);
            this.btn_AddProduct_Add.Name = "btn_AddProduct_Add";
            this.btn_AddProduct_Add.Size = new System.Drawing.Size(177, 65);
            this.btn_AddProduct_Add.TabIndex = 28;
            this.btn_AddProduct_Add.Text = "Add";
            this.btn_AddProduct_Add.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 988);
            this.Controls.Add(this.btn_AddProduct_Add);
            this.Controls.Add(this.lbl_AddProduct_Title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_AddProduct_Delete);
            this.Controls.Add(this.lbl_AddProduct_PartsAssociated);
            this.Controls.Add(this.lbl_AddProduct_CandidateParts);
            this.Controls.Add(this.btn_AddProduct_Cancel);
            this.Controls.Add(this.btn_AddProduct_Save);
            this.Controls.Add(this.txt_NewPart_Min);
            this.Controls.Add(this.txt_AddProduct_Max);
            this.Controls.Add(this.txt_AddProduct_Price);
            this.Controls.Add(this.txt_AddProduct_Inventory);
            this.Controls.Add(this.txt_AddProduct_Name);
            this.Controls.Add(this.lbl_AddProduct_Min);
            this.Controls.Add(this.lbl_AddProduct_Max);
            this.Controls.Add(this.lbl_AddProduct_Price);
            this.Controls.Add(this.lbl_AddProduct_Inventory);
            this.Controls.Add(this.lbl_AddProduct_Name);
            this.Controls.Add(this.lbl_AddProduct_ID);
            this.Controls.Add(this.txt_AddProduct_ID);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_AddProduct_ID;
        private System.Windows.Forms.Label lbl_AddProduct_ID;
        private System.Windows.Forms.Label lbl_AddProduct_Name;
        private System.Windows.Forms.Label lbl_AddProduct_Inventory;
        private System.Windows.Forms.Label lbl_AddProduct_Price;
        private System.Windows.Forms.Label lbl_AddProduct_Max;
        private System.Windows.Forms.Label lbl_AddProduct_Min;
        private System.Windows.Forms.TextBox txt_AddProduct_Name;
        private System.Windows.Forms.TextBox txt_AddProduct_Inventory;
        private System.Windows.Forms.TextBox txt_AddProduct_Price;
        private System.Windows.Forms.TextBox txt_AddProduct_Max;
        private System.Windows.Forms.TextBox txt_NewPart_Min;
        private System.Windows.Forms.Button btn_AddProduct_Save;
        private System.Windows.Forms.Button btn_AddProduct_Cancel;
        private System.Windows.Forms.Label lbl_AddProduct_CandidateParts;
        private System.Windows.Forms.Label lbl_AddProduct_PartsAssociated;
        private System.Windows.Forms.Button btn_AddProduct_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_AddProduct_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_AddProduct_Title;
        private System.Windows.Forms.Button btn_AddProduct_Add;
    }
}