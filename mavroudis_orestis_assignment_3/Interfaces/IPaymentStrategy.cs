using mavroudis_orestis_assignment_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mavroudis_orestis_assignment_3.Interfaces
{
    interface IPaymentStrategy
    {
        void Payment(Tshirt Tshirt);
    }
}
