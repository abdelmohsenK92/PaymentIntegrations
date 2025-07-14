using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentIntegrations.Core.Interfaces.Connection
{
    public interface IPaymentConnection
    {
        bool ConnectTerminal();
        bool DisconnectTerminal();

    }
}
