using mavroudis_orestis_assignment_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mavroudis_orestis_assignment_3.Models
{
    class Tshirt
    {
        private IPaymentStrategy _paymentmethod;
        public Color Color { get; set; } 
        public Size Size { get; set; } 
        public Fabric Fabric { get; set; }
        public Tshirt(Color Color, Size Size, Fabric Fabric)
        {
            this.Color = Color;
            this.Size = Size;
            this.Fabric = Fabric;
        }
        public Tshirt(Color Color, Size Size, Fabric Fabric, IPaymentStrategy paymentMethod) : this(Color, Size, Fabric)
        {
            SetPayment(paymentMethod);
        }
        public void SetPayment(IPaymentStrategy paymentMethod)
        {
            if (paymentMethod == null)
                throw new ArgumentNullException(nameof(paymentMethod));
            this._paymentmethod = paymentMethod;
        }

        public void Pay()
        {
            this._paymentmethod.Payment(this);
        }
    }
}
