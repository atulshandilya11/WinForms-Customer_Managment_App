namespace BusinessLogicCustomer
{
    public class Customer
    {
        public int CustomerID { get; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string ProductName { get; set; }
        public decimal BillAmount { get; set; }

        public Customer() {
            CustomerName = "";
            PhoneNumber = "";
            ProductName = "";
            BillAmount = 0;
        }

        public bool validate() {
            if (CustomerName.Length == 0) {throw new Exception("Customer Name is required"); }
            if (PhoneNumber.Length == 0) { throw new Exception("Phone Numebr is required"); }
            if (ProductName.Length == 0) { throw new Exception("Product Name is required");  }
            if (BillAmount == 0) { throw new Exception("Bill Amount is required"); }
            return true;
        }


    }
}
