namespace CanisMajoris.Shared.DataTransferObjects
{
    public record EmployeeDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public int Age { get; set; }
        public string? Position { get; init; }
    }
}
