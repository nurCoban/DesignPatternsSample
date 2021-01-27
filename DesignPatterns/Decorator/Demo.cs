using System;

namespace Decorator
{
    class Demo
    {
        static void Main(string[] args)
        {
            IIceCream iceCream;

            var vanillaIceCream = new VanillaIceCream();

            Console.WriteLine("Do you want any flavour?(Y/N)");

            var answer = Console.ReadLine();

            if(answer.ToUpper() == "Y")
            {
                Console.WriteLine("Which flavour do you want?\n1.Honey\n2.Almond\n3.Both");

                var flavourOptions = Console.ReadLine();

                if(flavourOptions == "1")
                {
                    iceCream = new HoneyDecorator(vanillaIceCream);
                }
                else if(flavourOptions == "2")
                {
                    iceCream = new AlmondDecorator(vanillaIceCream);
                }
                else if (flavourOptions == "3")
                {
                    iceCream = new HoneyDecorator(new AlmondDecorator(vanillaIceCream));
                }
                else
                {
                    throw new Exception("Wrong flavour choice");
                }
            }
            else
            {
                iceCream = vanillaIceCream;
            }

            Console.WriteLine("Here is your order!");

            iceCream.Make();            
        }
    }
}
