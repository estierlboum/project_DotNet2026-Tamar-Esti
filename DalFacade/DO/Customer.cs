using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    /// <summary>
    /// מייצג לקוח בחנות הבגדים.
    /// </summary>
    /// <param name="Id">מספר הזהות של הלקוח.</param>
    /// <param name="Name">השם המלא של הלקוח.</param>
    /// <param name="Address">כתובת המגורים של הלקוח.</param>
    /// <param name="Phone">מספר הטלפון של הלקוח.</param>
    public record Customer(
        int Id,
        string Name,
        string Address,
        string Phone)
    {

        public Customer() : this(0, "", "", "")
        {
        }
    }
}