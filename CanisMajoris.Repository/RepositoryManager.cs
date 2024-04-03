using CanisMajoris.Contracts;

namespace CanisMajoris.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {

        #region Properties

        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<IEmployeeRepository> _employeeRepository;

        public ICompanyRepository Company => _companyRepository.Value;
        public IEmployeeRepository Employee => _employeeRepository.Value;

        #endregion

        #region Constructor

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(repositoryContext));
            _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(repositoryContext));
        }

        #endregion

        #region Public Methods

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();

        #endregion

    }
}
