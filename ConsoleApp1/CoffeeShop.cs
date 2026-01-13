using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCSharp {
    
    class CoffeeShop {

        List<String> coffeeName = new List<String>();
        List<int> coffeePrice = new List<int>();
        List<int> quantity = new List<int>();
        char yn;

        public void menu() {

            do {
                Console.Clear(); // Clear Console
                // Defualt Menu Items for Coffee Shop System
                Console.WriteLine("\n --------------- Coffee Shop System --------------- ");
                Console.WriteLine("          Menu              Prices (Pesos) ");
                Console.WriteLine("     1. Caramel Macchiato         130");
                Console.WriteLine("     2. Caffee Mocha              120");
                Console.WriteLine("     3. Caffee Latte              110");
                Console.WriteLine("     4. Cappuccino                110");
                Console.WriteLine("     5. Chocolate Cappuccino      125");
                Console.WriteLine("     6. Brewed Coffee              80");
                Console.WriteLine("     7. Espresso (single shot)     70");
                Console.WriteLine("     8. Espresso Macchiato         90");
                Console.WriteLine("     9. White Mocha               130");
                Console.WriteLine("     10. Signature Hot Chocolate  115");
                Console.WriteLine(" -------------------------------------------------- ");

                Console.Write("\n Enter your order: ");
                int order = Convert.ToInt32(Console.ReadLine());

                Console.Write(" How Many?: ");
                int many = Convert.ToInt32(Console.ReadLine());

                switch (order) {
                    case 1:
                        coffeeName.Add("Caramel Macchiato       ");
                        coffeePrice.Add(130);
                        quantity.Add(many);
                        break;
                    case 2:
                        coffeeName.Add("Caffee Mocha            ");
                        coffeePrice.Add(120);
                        quantity.Add(many);
                        break;
                    case 3:
                        coffeeName.Add("Caffee Latte            ");
                        coffeePrice.Add(110);
                        quantity.Add(many);
                        break;
                    case 4:
                        coffeeName.Add("Cappuccino              ");
                        coffeePrice.Add(110);
                        quantity.Add(many);
                        break;
                    case 5:
                        coffeeName.Add("Chocolate Cappuccino    ");
                        coffeePrice.Add(125);
                        quantity.Add(many);
                        break;
                    case 6:
                        coffeeName.Add("Brewed Coffee           ");
                        coffeePrice.Add(80);
                        quantity.Add(many);
                        break;
                    case 7:
                        coffeeName.Add("Espresso (Single Shot)  ");
                        coffeePrice.Add(70);
                        quantity.Add(many);
                        break;
                    case 8:
                        coffeeName.Add("Espresso Macchiato      ");
                        coffeePrice.Add(90);
                        quantity.Add(many);
                        break;
                    case 9:
                        coffeeName.Add("White Mocha             ");
                        coffeePrice.Add(130);
                        quantity.Add(many);
                        break;
                    case 10:
                        coffeeName.Add("Signature Hot Chocolate");
                        coffeePrice.Add(115);
                        quantity.Add(many);
                        break;
                }

                Console.Write("\n Do you want to order again? [y/n]: ");
                yn = Console.ReadLine()[0];

            } while (yn == 'y' || yn == 'Y');

            if (yn == 'n' || yn == 'N') {
                viewOrder();
            }
            
        }

        public void viewOrder() {

            Console.Clear(); // Clear Console
            Console.WriteLine("\n -------------------- View Order -------------------");

            Console.WriteLine("\n  Coffee Name\t\tQuantity\tTotal \n");

            int total = 0;

            for (int x = 0; x < coffeeName.Count; x++) {

                total = coffeePrice[x] * quantity[x];

                Console.WriteLine($" {x + 1}. {coffeeName[x]} {quantity[x]}\t\t {total}");

            }
            Console.WriteLine(" ----------------------------------------------------");

            Console.Write("\n Enter Payment: ");
            int payment = Convert.ToInt32(Console.ReadLine());

            int change = payment - total;

            if (payment < total) Console.WriteLine($"\n Not Enough Payment...");
            else if (payment > total) Console.WriteLine($"\n Your Change is: {change}\n Thank you for coming!");
            else Console.WriteLine("\n Thank you for coming!");
        }
    }
}
