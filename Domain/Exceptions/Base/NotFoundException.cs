namespace Domain.Exceptions.Base
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string meesage)
            : base(meesage) 
        { 
        }

        protected NotFoundException()
        {     
        }
    }
}
