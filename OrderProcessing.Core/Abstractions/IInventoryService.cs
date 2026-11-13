public interface IInventoryService
{
	Task<bool> ReserveAsync(
		string productId,
		int quantity,
		Guid orderId,
		CancellationToken cancellationToken = default);

	Task ReleaseAsync(
		string productId,
		int quantity,
		Guid orderId,
		CancellationToken cancellationToken = default);
}
