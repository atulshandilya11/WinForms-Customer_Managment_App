using BusinessLogicCustomer;
using Dal;
using System.Data;
using System.Configuration;

namespace CustomerProject

{
    public partial class CustomerUI : Form
    {


        public CustomerUI()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            try
            {
                CustomerDal dal = new CustomerDal();
                DataSet Customers = dal.Read();
                dtgCustomers.DataSource = Customers.Tables[0];
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
                    CustomerDal dal = new CustomerDal();
                    dal.Add(custobj);
                }
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
            txtId.Text = dtgCustomers.Rows[rowselected].Cells[0].Value.ToString();
            txtCustomerName.Text = dtgCustomers.Rows[rowselected].Cells[1].Value.ToString();
            txtPhoneNumber.Text = dtgCustomers.Rows[rowselected].Cells[2].Value.ToString();
            txtBillAmount.Text = dtgCustomers.Rows[rowselected].Cells[3].Value.ToString();
            cmbProduct.Text = dtgCustomers.Rows[rowselected].Cells[4].Value.ToString();

        }

        private void btnUPdate_Click(object sender, EventArgs e)
        {
            // Loading the values from UI
            Customer updatedCustomer = new Customer();
            //updatedCustomer.CustomerId = (int)Convert.ToDecimal(txtId.Text);
            updatedCustomer.CustomerName = txtCustomerName.Text;
            updatedCustomer.PhoneNumber =  txtPhoneNumber.Text;
            updatedCustomer.ProductId = Convert.ToInt16(cmbProduct.SelectedValue);
            updatedCustomer.BillAmount =   Convert.ToDecimal(txtBillAmount.Text);
            // Updating the server
            CustomerDal dal = new CustomerDal();
            dal.Update(updatedCustomer, Convert.ToInt16(txtId.Text));
            // Refreshing the grid
            LoadGrid();

            ClearUI();
        }
        private void ClearUI()
        {
            txtId.Text = "";
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            txtBillAmount.Text = "";
            cmbProduct.SelectedIndex = -1;
            txtCustomerName.Text = "";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerDal dal = new CustomerDal();
            dal.Delete(Convert.ToInt16(txtId.Text));
            LoadGrid(); ClearUI();
               
        }
    }
}
