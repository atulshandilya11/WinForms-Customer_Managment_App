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
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtBillAmount = new TextBox();
            lblBillAmount = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(12, 30);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(181, 32);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "CustomerName";
            lblCustomerName.Click += lblCustomerName_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(279, 23);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(458, 39);
            txtCustomerName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(711, 162);
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
            // txtProductName
            // 
            txtProductName.Location = new Point(279, 92);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(458, 39);
            txtProductName.TabIndex = 6;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 92);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-15, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1646, 712);
            dataGridView1.TabIndex = 9;
            // 
            // CustomerUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1638, 1012);
            Controls.Add(dataGridView1);
            Controls.Add(txtBillAmount);
            Controls.Add(lblBillAmount);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumer);
            Controls.Add(btnAdd);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Name = "CustomerUI";
            Text = "Customer Managment Application";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Button btnAdd;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumer;
        private TextBox txtProductName;
        private Label lblProductName;
        private TextBox txtBillAmount;
        private Label lblBillAmount;
        private DataGridView dataGridView1;
    }
}
