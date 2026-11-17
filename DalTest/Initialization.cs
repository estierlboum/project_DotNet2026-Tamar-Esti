
namespace DalTest;
using DO;
using DalApi;
public static class Initialization
{
    private static IDal s_dal;

    private static void createProducts()
    {
        s_dal.Product.Create(new Product(0, "חולצה", Category.Shirts, 50.0, 20));
           
        s_dal.Product.Create(new Product(0, "שמלה", Category.Dresses, 120.0, 10));

        s_dal.Product.Create(new Product(0, "מכנסיים", Category.Pants, 90.0, 15));

        s_dal.Product.Create(new Product(0, "גרביים", Category.Socks, 15.0, 50));

        s_dal.Product.Create(new Product(0, "פיג'מה", Category.Pajamas, 80.0, 12));

    }
    private static void createCustomers()
    {
        s_dal.Customer.Create(new Customer(
            123456789, "דנה כהן", "הרצל 10, תל אביב", "0501234567"));

        s_dal.Customer.Create(new Customer(
            987654321, "נועה לוי", "ויצמן 5, רמת גן", "0521234567"));

        s_dal.Customer.Create(new Customer(
            123123123, "יוסי ישראלי", "ביאליק 8, חולון", "0541234567"));
    }
    private static void createSales()
    {
        s_dal.Sale.Create(new Sale(0, 100000, 2, 80.0, false, new DateTime(2026, 1, 1), new DateTime(2026, 12, 31)));
        s_dal.Sale.Create(new Sale(0, 100001, 3, 300.0, true, new DateTime(2026, 1, 1), new DateTime(2026, 12, 31)));
        s_dal.Sale.Create(new Sale(0, 100002, 2, 150.0, false, new DateTime(2026, 1, 1), new DateTime(2026, 12, 31)));
    }
    public static void Initialize(IDal dal)
    {
        s_dal = dal;

        createProducts();
        createCustomers();
        createSales();
    }
}
