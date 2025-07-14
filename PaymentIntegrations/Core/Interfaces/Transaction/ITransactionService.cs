using PaymentIntegrations.Core.Interfaces.Connection;
using PaymentIntegrations.Core.Interfaces.Request;
using PaymentIntegrations.Core.Interfaces.Response;

namespace PaymentIntegrations.Core.Interfaces.Transaction
{
    public interface ITransactionService
    {
        IPaymentResponse Purchase(IPaymentRequest request);
        IPaymentResponse Void(IPaymentRequest request);
        IPaymentResponse Refund(IPaymentRequest request);
    }
}
