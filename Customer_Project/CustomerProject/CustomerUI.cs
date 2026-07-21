using BusinessLogicCustomer;
using Dal;
using System.Data;
using System.Configuration;

namespace CustomerProject

{

    public partial class CustomerUI : Form
    {
        private List<Customer> customers = new List<Customer>();
        private Customer selectedCustomer = new Customer();
        public CustomerUI()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            try
            {
                CustomerDal dal = new CustomerDal();
                customers = dal.Read();
                dtgCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadGridInMemory()
        {
            try
            {
                dtgCustomers.DataSource = null;

                dtgCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumer_Click(object sender, EventArgs e)
        {

        }

        private void lblBillAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer custobj = new Customer();
                custobj.CustomerName = txtCustomerName.Text;
                custobj.PhoneNumber = txtPhoneNumber.Text;
                custobj.ProductId = Convert.ToInt16(cmbProduct.SelectedValue);
                custobj.BillAmount = Convert.ToDecimal(txtBillAmount.Text);
                if (custobj.validate())
                {
                    customers.Add(custobj);
                }
                LoadGridInMemory(); ClearUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerUI_Load(object sender, EventArgs e)

        {
            this.Text = ConfigurationManager.AppSettings["NameOfTheApp"].ToString();
            btnAdd.Text = ConfigurationManager.AppSettings["AddButton"].ToString();
            btnUpdate.Text = ConfigurationManager.AppSettings["UpdateButton"].ToString();
            btnDelete.Text = ConfigurationManager.AppSettings["DeleteButton"].ToString();


            LoadGrid();
            FillProducts();
        }

        private void FillProducts()
        {
            CustomerDal dal = new CustomerDal();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductId";
            cmbProduct.DataSource = dal.ReadProducts().Tables[0];
        }

        private void dtgCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowselected = e.RowIndex;
            selectedCustomer = customers[rowselected];
            LoadCustomer();
            //txtId.Text = dtgCustomers.Rows[rowselected].Cells[0].Value.ToString();
            //txtCustomerName.Text = dtgCustomers.Rows[rowselected].Cells[1].Value.ToString();
            //txtPhoneNumber.Text = dtgCustomers.Rows[rowselected].Cells[2].Value.ToString();
            //txtBillAmount.Text = dtgCustomers.Rows[rowselected].Cells[3].Value.ToString();
            //cmbProduct.Text = dtgCustomers.Rows[rowselected].Cells[4].Value.ToString();

        }

        private void LoadCustomer()
        {
            txtId.Text = selectedCustomer.CustomerId.ToString();
            txtCustomerName.Text = selectedCustomer.CustomerName;
            txtPhoneNumber.Text = selectedCustomer.PhoneNumber;
            txtBillAmount.Text = selectedCustomer.BillAmount.ToString();
            cmbProduct.Text = selectedCustomer.ProductName;

        }

        private void btnUPdate_Click(object sender, EventArgs e)
        {
            // Loading the values from UI
            Customer updatedCustomer = new Customer();
            //updatedCustomer.CustomerId = (int)Convert.ToDecimal(txtId.Text);
            selectedCustomer.CustomerName = txtCustomerName.Text;
            selectedCustomer.PhoneNumber = txtPhoneNumber.Text;
            selectedCustomer.ProductId = Convert.ToInt16(cmbProduct.SelectedValue);
            selectedCustomer.BillAmount = Convert.ToDecimal(txtBillAmount.Text);

            // Refreshing the grid
            LoadGridInMemory();

            ClearUI();
        }
        private void ClearUI()
        {
            txtId.Text = "";
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            txtBillAmount.Text = "";
            cmbProduct.SelectedIndex = -1;
            selectedCustomer = new Customer();



        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach( var tem in customers)
            {
                if ( selectedCustomer.CustomerId == tem.CustomerId)
                {
                    tem.IsDeleted = true;
                    return;
                }
            }
            customers.Remove(selectedCustomer);
            LoadGridInMemory(); ClearUI();
            //CustomerDal dal = new CustomerDal();
            //dal.Delete(Convert.ToInt16(txtId.Text));
            //LoadGrid(); ClearUI();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDal dal = new CustomerDal();
                dal.SaveAll(customers);
            LoadGrid();
        }
    }
}
