using OrderProcessing.Core.Models;

public interface IPaymentService
{
	Task<PaymentResult> ChargeAsync(
		string paymentMethodToken,
		decimal amount,
		Guid orderId,
		CancellationToken cancellationToken = default);
}
