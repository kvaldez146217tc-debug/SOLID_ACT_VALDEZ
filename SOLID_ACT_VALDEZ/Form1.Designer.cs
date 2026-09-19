 namespace SOLID_ACT_VALDEZ
{
    partial class Form1
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
            txtCustomerEmail = new TextBox();
            dgvItems = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            cmbDiscountType = new ComboBox();
            btnCalculate = new Button();
            btnSaveOrder = new Button();
            btnEmailnvoice = new Button();
            btnPrint = new Button();
            txtDiscountType = new Label();
            label1 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(285, 55);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(281, 31);
            txtCustomerEmail.TabIndex = 0;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Qty });
            dgvItems.Location = new Point(151, 109);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(513, 175);
            dgvItems.TabIndex = 1;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 8;
            Product.Name = "Product";
            Product.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // Qty
            // 
            Qty.HeaderText = "Quantity";
            Qty.MinimumWidth = 8;
            Qty.Name = "Qty";
            Qty.Width = 150;
            // 
            // cmbDiscountType
            // 
            cmbDiscountType.FormattingEnabled = true;
            cmbDiscountType.Items.AddRange(new object[] { "None", "Student", "Senior", "Blackfriday" });
            cmbDiscountType.Location = new Point(285, 326);
            cmbDiscountType.Name = "cmbDiscountType";
            cmbDiscountType.Size = new Size(263, 33);
            cmbDiscountType.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(101, 395);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(230, 395);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(162, 34);
            btnSaveOrder.TabIndex = 4;
            btnSaveOrder.Text = "SAVE ORDER";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnEmailnvoice
            // 
            btnEmailnvoice.Location = new Point(412, 395);
            btnEmailnvoice.Name = "btnEmailnvoice";
            btnEmailnvoice.Size = new Size(177, 34);
            btnEmailnvoice.TabIndex = 5;
            btnEmailnvoice.Text = "EMAIL  INVOICE";
            btnEmailnvoice.UseVisualStyleBackColor = true;
            btnEmailnvoice.Click += btnEmailInvoice_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(607, 395);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // txtDiscountType
            // 
            txtDiscountType.AutoSize = true;
            txtDiscountType.Location = new Point(141, 329);
            txtDiscountType.Name = "txtDiscountType";
            txtDiscountType.Size = new Size(138, 25);
            txtDiscountType.TabIndex = 7;
            txtDiscountType.Text = "Discount Type : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 58);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 8;
            label1.Text = "Customer Email :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(101, 466);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(96, 30);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "TOTAL : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(824, 556);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(txtDiscountType);
            Controls.Add(btnPrint);
            Controls.Add(btnEmailnvoice);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnCalculate);
            Controls.Add(cmbDiscountType);
            Controls.Add(dgvItems);
            Controls.Add(txtCustomerEmail);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerEmail;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
        private ComboBox cmbDiscountType;
        private Button btnCalculate;
        private Button btnSaveOrder;
        private Button btnEmailnvoice;
        private Button btnPrint;
        private Label txtDiscountType;
        private Label label1;
        private Label lblTotal;
    }
}
