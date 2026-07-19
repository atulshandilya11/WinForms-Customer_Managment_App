using BusinessLogicCustomer;
namespace CustomerUIForSuperUser
{
    class Program
    {
      static void Main (string[] args)
        {
            try
            {
                Customer obj = new Customer();
                obj.CustomerName = Console.ReadLine();
               

                obj.validate();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }

}
