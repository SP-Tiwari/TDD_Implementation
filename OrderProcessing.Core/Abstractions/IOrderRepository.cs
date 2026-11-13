using OrderProcessing.Core.Models;

public interface IOrderRepository
{
	Task SaveConfirmedAsync(
		Guid orderId,
		string customerId,
		IReadOnlyList<OrderItem> items,
		decimal total,
		string transactionId,
		CancellationToken cancellationToken = default);
}
