namespace BusinessLogicCustomer
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string ProductNmae { get; set; }
        public decimal BillAmount { get; set; }

        public Customer() {
            CustomerName = "";
            PhoneNumber = "";
            ProductNmae = "";
            BillAmount = 0;
        }

        public void validate() {
            if (CustomerName.Length == 0) {throw new Exception("Customer Name is required"); }
            if (PhoneNumber.Length == 0) { throw new Exception("Phone Numebr is required"); }
            if (ProductNmae.Length == 0) { throw new Exception("Product Name is required");  }
            if (BillAmount == 0) { throw new Exception("Bill Amount is required"); }
        }


    }
}
