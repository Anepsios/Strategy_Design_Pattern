using mavroudis_orestis_assignment_3.Interfaces;
using mavroudis_orestis_assignment_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mavroudis_orestis_assignment_3
{
    enum Color
    {
        Red, Orange, Yellow, Green, Blue, Indigo, Violet
    }
    enum Size
    {
        XS, S, M, L, XL, XXL, XXXL
    }
    enum Fabric
    {
        Wool, Cotton, Polyester, Rayon, Linen, Cashmere, Silk
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Tshirt> selection = new List<Tshirt>
            {
                new Tshirt(Color.Blue, Size.XS, Fabric.Cashmere),
                new Tshirt(Color.Indigo, Size.XXXL, Fabric.Polyester),
                new Tshirt(Color.Violet, Size.XL, Fabric.Silk),
                new Tshirt(Color.Yellow, Size.L, Fabric.Cotton),
                new Tshirt(Color.Green, Size.XXL, Fabric.Wool),
                new Tshirt(Color.Blue, Size.M, Fabric.Cashmere),
                new Tshirt(Color.Green, Size.S, Fabric.Polyester),
                new Tshirt(Color.Orange, Size.XXL, Fabric.Linen),
                new Tshirt(Color.Violet, Size.XS, Fabric.Cotton),
                new Tshirt(Color.Red, Size.S, Fabric.Wool),
                new Tshirt(Color.Yellow, Size.L, Fabric.Rayon),
                new Tshirt(Color.Indigo, Size.XL, Fabric.Polyester),
                new Tshirt(Color.Red, Size.M, Fabric.Silk),
                new Tshirt(Color.Yellow, Size.XL, Fabric.Cotton),
            };

            Console.WriteLine("Look at our beautiful selection. Pick one.");
            int i = 0;
            foreach (var item in selection)
            {
                i++;
                Console.WriteLine(i + ") " + item.Size + " " + item.Color + " T-shirt made from " + item.Fabric);
            }

            string selected = "";
            int selectednum = 0;

            do
            {
                selected = Console.ReadLine();
                if (int.TryParse(selected, out selectednum))
                    continue;
            } while (selectednum <= 0 || selectednum > selection.Count);

            Tshirt tshirt = selection[selectednum - 1];

            IPaymentStrategy paymentMethod;

            Console.WriteLine("What payment method do you want?\n1)Credit Card\n2)Bank Transfer\n3)Cash");
            string answer = Console.ReadLine();
            if (answer.Equals("1"))
                paymentMethod = new CreditCardStrategy();
            else if (answer.Equals("2"))
                paymentMethod = new BankTranserStrategy();
            else if (answer.Equals("3"))
                paymentMethod = new CashStrategy();
            else
                paymentMethod = null;

            if (paymentMethod == null)
                Console.WriteLine("Guess you dont want ur tshirt then");
            else
            {
                tshirt.SetPayment(paymentMethod);
                paymentMethod.Payment(tshirt);
            }
        }
    }
}