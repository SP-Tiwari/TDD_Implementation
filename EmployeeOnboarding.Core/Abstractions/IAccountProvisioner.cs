public interface IAccountProvisioner
{
	Task ProvisionAsync(string email, CancellationToken cancellationToken = default);
}
