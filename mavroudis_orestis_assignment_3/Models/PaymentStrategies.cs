using mavroudis_orestis_assignment_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mavroudis_orestis_assignment_3.Models
{
    class CreditCardStrategy : IPaymentStrategy
    {
        decimal Price = 0m;
        public void Payment(Tshirt Tshirt)
        {
            switch (Tshirt.Fabric)
            {
                case Fabric.Wool:
                case Fabric.Cotton:
                    Price = 20m;
                    break;
                case Fabric.Polyester:
                case Fabric.Rayon:
                    Price = 15m;
                    break;
                case Fabric.Linen:
                case Fabric.Cashmere:
                case Fabric.Silk:
                    Price = 30m;
                    break;
            }

            switch (Tshirt.Size)
            {
                case Size.L:
                case Size.XL:
                case Size.XXL:
                case Size.XXXL:
                    Price += Price * 0.05m;
                    break;
            }

            Console.WriteLine($"The price of your Tshirt is: {Price:0.##}\u20ac");
        }
    }

    class BankTranserStrategy : IPaymentStrategy
    {
        decimal Price = 0m;

        public void Payment(Tshirt Tshirt)
        {
            switch (Tshirt.Fabric)
            {
                case Fabric.Wool:
                case Fabric.Cotton:
                    Price = 25m;
                    break;
                case Fabric.Polyester:
                case Fabric.Rayon:
                    Price = 20m;
                    break;
                case Fabric.Linen:
                case Fabric.Cashmere:
                case Fabric.Silk:
                    Price = 35m;
                    break;
            }

            switch (Tshirt.Size)
            {
                case Size.L:
                case Size.XL:
                case Size.XXL:
                case Size.XXXL:
                    Price += Price * 0.1m;
                    break;
            }

            Console.WriteLine($"The price of your Tshirt is: {Price:0.##}\u20ac");
        }
    }

    class CashStrategy : IPaymentStrategy
    {
        decimal Price = 0m;
        public void Payment(Tshirt Tshirt)
        {
            switch (Tshirt.Fabric)
            {
                case Fabric.Wool:
                case Fabric.Cotton:
                    Price = 20m;
                    break;
                case Fabric.Polyester:
                case Fabric.Rayon:
                    Price = 15m;
                    break;
                case Fabric.Linen:
                case Fabric.Cashmere:
                case Fabric.Silk:
                    Price = 30m;
                    break;
            }

            switch (Tshirt.Size)
            {
                case Size.L:
                case Size.XL:
                case Size.XXL:
                case Size.XXXL:
                    Price += Price * 0.1m;
                    break;
            }

            switch (Tshirt.Color)
            {
                case Color.Indigo:
                case Color.Violet:
                    Price += 2m;
                    break;
            }

            Console.WriteLine($"The price of your Tshirt is: {Price:0.##}\u20ac");
        }
    }
}
