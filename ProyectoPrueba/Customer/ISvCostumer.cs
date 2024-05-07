using Entidades;

namespace Services.Customer
{
    public interface ISvCostumer
    {
        public Customer Addcustomer(Customer customer);

        public List<Customer> GetAllcustomer();

        public Customer GetCostumerById(int id);

        public Customer UpdateCustomer(int id, Customer customer);

        public Customer DeleteCustomer(int id);

        public bool SearchByEmail(string _email);
    }
}
