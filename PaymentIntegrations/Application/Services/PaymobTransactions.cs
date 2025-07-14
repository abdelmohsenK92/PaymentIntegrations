using PaymentIntegrations.Core.Interfaces.Connection;
using PaymentIntegrations.Core.Interfaces.Request;
using PaymentIntegrations.Core.Interfaces.Response;
using PaymentIntegrations.Core.Interfaces.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentIntegrations.Application.Services
{
    public class PaymobTransactionsService : IPaymobTransaction
    {
        

        public IPaymentResponse Purchase(IPaymentRequest request)
        {
            throw new NotImplementedException();
        }

        public IPaymentResponse Refund(IPaymentRequest request)
        {
            throw new NotImplementedException();
        }

        public IPaymentResponse Void(IPaymentRequest request)
        {
            throw new NotImplementedException();
        }
    }
    public class FawryTransaction : IFawryTransaction
    {
        public IPaymentResponse Purchase(IPaymentRequest request)
        {
            throw new NotImplementedException();
        }

        public IPaymentResponse Refund(IPaymentRequest request)
        {
            throw new NotImplementedException();
        }

        public IPaymentResponse Void(IPaymentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
