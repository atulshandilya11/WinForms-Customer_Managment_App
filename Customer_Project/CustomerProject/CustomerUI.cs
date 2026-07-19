using BusinessLogicCustomer;
using Dal;
namespace CustomerProject

{
    public partial class CustomerUI : Form
    {

        
        public CustomerUI()
        {
            InitializeComponent();
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
                custobj.ProductName = txtProductName.Text;
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
    }
}
