
namespace SalesWinApp
{
    partial class frmProducts
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
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProId = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtStock = new System.Windows.Forms.MaskedTextBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchIDAndName = new System.Windows.Forms.Button();
            this.btnSearchPrice = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaxStock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(15, 191);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(1017, 247);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID";
            // 
            // txtProId
            // 
            this.txtProId.Location = new System.Drawing.Point(106, 7);
            this.txtProId.Name = "txtProId";
            this.txtProId.Size = new System.Drawing.Size(100, 23);
            this.txtProId.TabIndex = 2;
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(106, 45);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(100, 23);
            this.txtProName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(106, 88);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 23);
            this.txtCategory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category ID";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(320, 7);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 23);
            this.txtWeight.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(230, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(230, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(230, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Units In Stock ";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(15, 126);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(131, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(320, 45);
            this.txtPrice.Mask = "0000000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 17;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(320, 88);
            this.txtStock.Mask = "0000";
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 18;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(515, 7);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(130, 23);
            this.txtSearchID.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(449, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Search ID";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(749, 7);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(130, 23);
            this.txtSearchName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(665, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Search Name";
            // 
            // btnSearchIDAndName
            // 
            this.btnSearchIDAndName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchIDAndName.Location = new System.Drawing.Point(902, 6);
            this.btnSearchIDAndName.Name = "btnSearchIDAndName";
            this.btnSearchIDAndName.Size = new System.Drawing.Size(130, 23);
            this.btnSearchIDAndName.TabIndex = 25;
            this.btnSearchIDAndName.Text = "Search ID and Name";
            this.btnSearchIDAndName.UseVisualStyleBackColor = true;
            this.btnSearchIDAndName.Click += new System.EventHandler(this.btnSearchIDAndName_Click);
            // 
            // btnSearchPrice
            // 
            this.btnSearchPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchPrice.Location = new System.Drawing.Point(902, 44);
            this.btnSearchPrice.Name = "btnSearchPrice";
            this.btnSearchPrice.Size = new System.Drawing.Size(130, 23);
            this.btnSearchPrice.TabIndex = 30;
            this.btnSearchPrice.Text = "Search Price";
            this.btnSearchPrice.UseVisualStyleBackColor = true;
            this.btnSearchPrice.Click += new System.EventHandler(this.btnSearchPrice_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(665, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Max Price";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(749, 45);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(130, 23);
            this.txtMax.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(449, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Min Price";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(515, 45);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(130, 23);
            this.txtMin.TabIndex = 26;
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchStock.Location = new System.Drawing.Point(902, 87);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(130, 23);
            this.btnSearchStock.TabIndex = 35;
            this.btnSearchStock.Text = "Search In Stock";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            this.btnSearchStock.Click += new System.EventHandler(this.btnSearchStock_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(665, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Max Stock";
            // 
            // txtMaxStock
            // 
            this.txtMaxStock.Location = new System.Drawing.Point(749, 88);
            this.txtMaxStock.Name = "txtMaxStock";
            this.txtMaxStock.Size = new System.Drawing.Size(130, 23);
            this.txtMaxStock.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(449, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Min Stock";
            // 
            // txtMinStock
            // 
            this.txtMinStock.Location = new System.Drawing.Point(515, 88);
            this.txtMinStock.Name = "txtMinStock";
            this.txtMinStock.Size = new System.Drawing.Size(130, 23);
            this.txtMinStock.TabIndex = 31;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.btnSearchStock);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaxStock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMinStock);
            this.Controls.Add(this.btnSearchPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.btnSearchIDAndName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductList);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProId;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtStock;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchIDAndName;
        private System.Windows.Forms.Button btnSearchPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaxStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMinStock;
    }
}

