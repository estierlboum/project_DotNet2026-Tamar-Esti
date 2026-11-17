using DalApi;
using DO;
using System.Collections.Generic;
namespace Dal
{
    internal class SaleImplementation : ISale
    {
        public int Create(Sale item)
        {
            int newId = DataSource.Config.NextSaleId;
            Sale newSale = item with { Id = newId };
            DataSource.Sales.Add(newSale);
            return newId;
        }
        public void Delete(int id)
        {
            Sale? saleToDelete = Read(id);
            if (saleToDelete == null)
            {
                throw new DalDoesNotExistException($"Sale with ID {id} not found.");
            }
            DataSource.Sales.Remove(saleToDelete);
        }

        public Sale? Read(int id)
        {
            foreach (Sale sale in DataSource.Sales)
            {
                if (sale.Id == id)
                {
                    return sale;
                }

            }
            return null;
        }

        public List<Sale> ReadAll()
        {
            return new List<Sale>(DataSource.Sales);
        }

        public void Update(Sale item)
        {
            Sale? oldSale = Read(item.Id);

            if (oldSale == null)
            {
                throw new DalDoesNotExistException($"Sale with ID {item.Id} not found.");
            }

            DataSource.Sales.Remove(oldSale);
            DataSource.Sales.Add(item);
        }
    }
}


    