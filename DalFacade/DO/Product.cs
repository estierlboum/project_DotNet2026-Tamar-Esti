namespace DO
{
    /// <summary>
    /// מייצג מוצר הנמכר בחנות הבגדים.
    /// </summary>
    /// <param name="Id">מספר מזהה ייחודי של המוצר.</param>
    /// <param name="Name">שם המוצר.</param>
    /// <param name="Category">הקטגוריה שאליה שייך המוצר.</param>
    /// <param name="Price">מחיר המוצר.</param>
    /// <param name="Quantity">כמות היחידות של המוצר במלאי.</param>
    public record Product(
    int Id,
    string Name,
    Category Category,
    double Price,
    int Quantity)
    {
    
    public Product() : this(0, "", Category.Shirts, 0.0, 0)
        {
        }
    }

}
