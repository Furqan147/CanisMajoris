using Shared.DataTransferObjects;

namespace CanisMajoris.Shared.DataTransferObjects
{
    public record class CompanyForCreationDto : CompanyForManipulationDto
    {
        public IEnumerable<EmployeeForCreationDto>? Employees { get; init; }
    }
}
