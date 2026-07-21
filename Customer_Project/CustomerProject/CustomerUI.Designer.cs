namespace CustomerProject
{
    partial class CustomerUI
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
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            btnAdd = new Button();
            txtPhoneNumber = new TextBox();
            lblPhoneNumer = new Label();
            lblProductName = new Label();
            txtBillAmount = new TextBox();
            lblBillAmount = new Label();
            dtgCustomers = new DataGridView();
            lblId = new Label();
            txtId = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmbProduct = new ComboBox();
            btnSaveAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(12, 99);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(181, 32);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "CustomerName";
            lblCustomerName.Click += lblCustomerName_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(279, 92);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(458, 39);
            txtCustomerName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(279, 238);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(993, 30);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(458, 39);
            txtPhoneNumber.TabIndex = 4;
            // 
            // lblPhoneNumer
            // 
            lblPhoneNumer.AutoSize = true;
            lblPhoneNumer.Location = new Point(785, 30);
            lblPhoneNumer.Name = "lblPhoneNumer";
            lblPhoneNumer.Size = new Size(177, 32);
            lblPhoneNumer.TabIndex = 3;
            lblPhoneNumer.Text = "Phone Number";
            lblPhoneNumer.Click += lblPhoneNumer_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 167);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(167, 32);
            lblProductName.TabIndex = 5;
            lblProductName.Text = "Product Name";
            // 
            // txtBillAmount
            // 
            txtBillAmount.Location = new Point(993, 89);
            txtBillAmount.Name = "txtBillAmount";
            txtBillAmount.Size = new Size(458, 39);
            txtBillAmount.TabIndex = 8;
            txtBillAmount.Text = "0";
            // 
            // lblBillAmount
            // 
            lblBillAmount.AutoSize = true;
            lblBillAmount.Location = new Point(785, 95);
            lblBillAmount.Name = "lblBillAmount";
            lblBillAmount.Size = new Size(139, 32);
            lblBillAmount.TabIndex = 7;
            lblBillAmount.Text = "Bill Amount";
            lblBillAmount.Click += lblBillAmount_Click;
            // 
            // dtgCustomers
            // 
            dtgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomers.Location = new Point(-15, 416);
            dtgCustomers.Name = "dtgCustomers";
            dtgCustomers.RowHeadersWidth = 82;
            dtgCustomers.Size = new Size(1646, 584);
            dtgCustomers.TabIndex = 9;
            dtgCustomers.CellContentClick += dataGridView1_CellContentClick;
            dtgCustomers.RowEnter += dtgCustomers_RowEnter;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 32);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(279, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(458, 39);
            txtId.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(497, 238);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUPdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(709, 238);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(279, 159);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(242, 40);
            cmbProduct.TabIndex = 14;
            // 
            // btnSaveAll
            // 
            btnSaveAll.Location = new Point(1045, 238);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(150, 46);
            btnSaveAll.TabIndex = 15;
            btnSaveAll.Text = "Save ALL";
            btnSaveAll.UseVisualStyleBackColor = true;
            btnSaveAll.Click += button1_Click;
            // 
            // CustomerUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1638, 1012);
            Controls.Add(btnSaveAll);
            Controls.Add(cmbProduct);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dtgCustomers);
            Controls.Add(txtBillAmount);
            Controls.Add(lblBillAmount);
            Controls.Add(lblProductName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumer);
            Controls.Add(btnAdd);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Name = "CustomerUI";
            Text = "Customer Managment Application";
            Load += CustomerUI_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Button btnAdd;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumer;
        private Label lblProductName;
        private TextBox txtBillAmount;
        private Label lblBillAmount;
        private DataGridView dtgCustomers;
        private Label lblId;
        private TextBox txtId;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cmbProduct;
        private Button btnSaveAll;
    }
}
