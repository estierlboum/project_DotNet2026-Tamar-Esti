using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    /// <summary>
    /// מייצג מבצע על מוצר בחנות הבגדים.
    /// </summary>
    /// <param name="Id">מספר מזהה ייחודי של המבצע.</param>
    /// <param name="ProductId">המזהה של המוצר שעליו חל המבצע.</param>
    /// <param name="RequiredQuantity">הכמות הנדרשת לרכישה כדי לקבל את המבצע.</param>
    /// <param name="SalePrice">המחיר הכולל לתשלום במסגרת המבצע.</param>
    /// <param name="IsForClubMembersOnly">מציין האם המבצע מיועד לחברי מועדון בלבד.</param>
    /// <param name="StartDate">תאריך תחילת המבצע.</param>
    /// <param name="EndDate">תאריך סיום המבצע.</param>
    public record Sale(
        int Id,
        int ProductId,
        int RequiredQuantity,
        double SalePrice,
        bool IsForClubMembersOnly,
        DateTime StartDate,
        DateTime EndDate)
    {
     
        public Sale() : this(0, 0, 0, 0.0, false, DateTime.MinValue, DateTime.MinValue)
        {
        }
    }
}
