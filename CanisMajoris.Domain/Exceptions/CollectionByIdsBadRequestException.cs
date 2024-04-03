using CanisMajoris.Domain.Exceptions;

namespace CanisMajoris.Entities.Exceptions
{
    public sealed class CollectionByIdsBadRequestException : BadRequestException
    {
        public CollectionByIdsBadRequestException() : base("Collection count mismatch comparing to ids.")
        {
            
        }
    }
}
