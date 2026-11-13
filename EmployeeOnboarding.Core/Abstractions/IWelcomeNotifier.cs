public interface IWelcomeNotifier
{
	Task SendAsync(string email, string employeeName, CancellationToken cancellationToken = default);
}