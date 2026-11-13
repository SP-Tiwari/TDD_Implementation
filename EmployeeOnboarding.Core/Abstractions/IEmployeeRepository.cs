using EmployeeOnboarding.Core.Models;

public interface IEmployeeRepository
{
	Task<int> AddAsync(EmployeeInput input, CancellationToken cancellationToken = default);
}
