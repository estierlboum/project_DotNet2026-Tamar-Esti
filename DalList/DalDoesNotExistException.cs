using System;



namespace Dal
{
    public class DalDoesNotExistException : Exception
    {
        public DalDoesNotExistException(string message)
            : base(message)
        {
        }
    }
}