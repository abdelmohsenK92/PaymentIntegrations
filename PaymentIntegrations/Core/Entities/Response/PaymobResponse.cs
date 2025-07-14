using PaymentIntegrations.Core.Interfaces.Response;

namespace PaymentIntegrations.Core.Entities.Response
{
    public class PaymobResponse : IPaymentResponse
    {
        public bool IsSuccess { get; set; }
    }
}
