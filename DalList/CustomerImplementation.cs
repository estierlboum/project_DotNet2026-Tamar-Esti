using DalApi;
using DO;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        public int Create(Customer item)
        {
            Customer? oldCustomer = Read(item.Id);
            if (oldCustomer != null)
            {
                throw new DalAlreadyExistsException($"Customer with ID {item.Id} already exists.");
            }
            DataSource.Customers.Add(item);
            return item.Id;

        }

        public void Delete(int id)
        {
            Customer? customerToDelete = Read(id);
            if (customerToDelete == null)
            {
                throw new DalDoesNotExistException($"Customer with ID {id} not found.");
            }
            DataSource.Customers.Remove(customerToDelete);
        }

        public Customer? Read(int id)
        {
            foreach (Customer customer in DataSource.Customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }

            }
            return null;
        }

        public List<Customer> ReadAll()
        {
            return new List<Customer>(DataSource.Customers);
        }

        public void Update(Customer item)
        {
            Customer? oldCustomer = Read(item.Id);

            if (oldCustomer == null)
            {
                throw new DalDoesNotExistException($"Customer with ID {item.Id} not found.");
            }

            DataSource.Customers.Remove(oldCustomer);
            DataSource.Customers.Add(item);
        }
    }
}
