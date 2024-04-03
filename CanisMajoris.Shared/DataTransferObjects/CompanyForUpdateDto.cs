using Shared.DataTransferObjects;

namespace CanisMajoris.Shared.DataTransferObjects
{
    public record CompanyForUpdateDto : CompanyForManipulationDto
    {
        public IEnumerable<EmployeeForCreationDto>? Employees { get; init; }
    }
}
