

namespace Dal;

internal static class DataSource
{
    /// רשימת כל המוצרים במערכת
    internal static List<DO.Product?> Products = new();
    /// רשימת כל הלקוחות במערכת
    internal static List<DO.Customer?> Customers = new();
    /// רשימת כל המבצעים במערכת
    internal static List<DO.Sale?> Sales = new();
 
    internal static class Config
    {
        // --- הגדרות מספר רץ עבור מוצר (Product) ---

        /// המספר המזהה ההתחלתי (המינימלי) עבור מוצר - לפחות 6 ספרות
        internal const int startProductId = 100000;


        /// שדה סטטי השומר את המספר הרץ הבא עבור מוצר
        private static int nextProductId = startProductId;


        /// מאפיין המחזיר את המספר הרץ הבא עבור מוצר ומקדם אותו אוטומטית ב-1
        internal static int NextProductId => nextProductId++;


        // --- הגדרות מספר רץ עבור מבצע (Sale) ---

        /// המספר המזהה ההתחלתי (המינימלי) עבור מבצע
        internal const int _startSaleId = 1;

        /// שדה סטטי השומר את המספר הרץ הבא עבור מבצע
        private static int _nextSaleId = _startSaleId;


        /// מאפיין המחזיר את המספר הרץ הבא עבור מבצע ומקדם אותו אוטומטית ב-1
        internal static int NextSaleId => _nextSaleId++;
    }
}
    
