public interface IOrderNotificationService
{
	Task SendConfirmationAsync(
		Guid orderId,
		string customerId,
		decimal total,
		CancellationToken cancellationToken = default);
}