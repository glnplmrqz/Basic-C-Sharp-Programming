using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCSharp {
    class BurgerMenu {

        // Lists
        List<string> listFood = new List<string>();
        List<int> quantity = new List<int>();
        List<double> cost = new List<double>();

        // Global Variables
        char yn; // For Repeating
        char nextMenu;

        public void loadingScreen() {
            int loadingDot;

            Console.Write("\n\n\n\n\n\n\n\n\n\t\t\t\t\tLoading");

            for (loadingDot = 0; loadingDot < 6; loadingDot++) {
                Console.Write(" . ");
                System.Threading.Thread.Sleep(250);
            }

            Console.WriteLine("\n\n\n\t\t\t\t\tTHANK YOU FOR WAITING!");

            for (loadingDot = 0; loadingDot < 6; loadingDot++) {
                System.Threading.Thread.Sleep(100);
            }

            Console.Clear();

            // Automatically Calling Menu Function
            menu();
        }

        public void menu() {

            // Beef Burger Menu
            Console.WriteLine("\n ===================== Beef Burgers Menu =====================\n");
            Console.WriteLine("                     Lists        Price \n");
            Console.WriteLine("         1. Beef Burger           120 ");
            Console.WriteLine("         2. Cheese Burger         130 ");
            Console.WriteLine("         3. Beef Bacon            140 ");
            Console.WriteLine("         4. Creamy Mushroom       100 ");
            Console.WriteLine("         5. Hawaiian Burger       110 ");
            Console.WriteLine("\n ============================================================= ");

            // Chicken Burger Menu
            Console.WriteLine("\n ===================== Chicken Burgers Menu ================== \n");
            Console.WriteLine("                     Lists        Price \n");
            Console.WriteLine("         1. Spicy Tandoori        100 ");
            Console.WriteLine("         2. Spicy Buffalo         100 ");
            Console.WriteLine("         3. BBQ Chicken            99 ");
            Console.WriteLine("         4. Crispy Chicken        160 ");
            Console.WriteLine("         5. Chicken Paradise      190 ");
            Console.WriteLine("\n ============================================================= ");

            // User Input 
            Console.Write("\n Press B for Beef Burger, Press C for Chicken Burger: ");
            char burgerSelection = Console.ReadLine()[0];

            if(char.ToLower(burgerSelection) == 'b') {
                beefBurger();
            } else if(char.ToLower(burgerSelection) == 'c'){
                chickenBurger();
            }
        }

        // Beef Burger Menu Function
        public void beefBurger() {

            do {
                // Automatically Clear the Console
                Console.Clear();

                // Beef Burger Menu
                Console.WriteLine("\n ===================== Beef Burgers Menu =====================\n");
                Console.WriteLine("                     Lists        Price \n");
                Console.WriteLine("         1. Beef Burger           120 ");
                Console.WriteLine("         2. Cheese Burger         130 ");
                Console.WriteLine("         3. Beef Bacon            140 ");
                Console.WriteLine("         4. Creamy Mushroom       100 ");
                Console.WriteLine("         5. Hawaiian Burger       110 ");
                Console.WriteLine("\n ============================================================= ");

                // Pick your Order
                Console.Write("\n Enter your order: ");
                int order = Convert.ToInt32(Console.ReadLine());

                // Number of Order
                Console.Write(" How many: ");
                int manyOrder = Convert.ToInt32(Console.ReadLine());

                switch (order) {
                    case 1:
                        listFood.Add("Beef Burger    ");
                        quantity.Add(manyOrder);
                        cost.Add(120);
                        break;
                    case 2:
                        listFood.Add("Cheese Burger  ");
                        quantity.Add(manyOrder);
                        cost.Add(130);
                        break;
                    case 3:
                        listFood.Add("Beef Bacon     ");
                        quantity.Add(manyOrder);
                        cost.Add(140);
                        break;
                    case 4:
                        listFood.Add("Creamy Mushroom");
                        quantity.Add(manyOrder);
                        cost.Add(100);
                        break;
                    case 5:
                        listFood.Add("Hawaiian Burger");
                        quantity.Add(manyOrder);
                        cost.Add(110);
                        break;
                }

                Console.Write("\n Do you want to order again? [y/n]: ");
                yn = Console.ReadLine()[0];

            } while (char.ToLower(yn) == 'y');

            if (char.ToLower(yn) == 'n') {
                Console.Write("\n Do you want to order in Chicken Burger? [y/n]: ");
                nextMenu = Console.ReadLine()[0];

                if (char.ToLower(nextMenu) == 'y') {
                    chickenBurger();
                }

                // For Drinks
                Console.Write("\n Do you want to add drinks? [y/n]: ");
                nextMenu = Console.ReadLine()[0];

                if (char.ToLower(nextMenu) == 'y') {
                    availableDrinks();
                } else if (char.ToLower(nextMenu) == 'n') {
                    displayOrder(); // Calling Display Order Function
                }
            }
        }

        // Chicken Burger Menu Function
        public void chickenBurger() {

            do {
                // Automatically Clear the Console
                Console.Clear();

                // Chicken Burger Menu
                Console.WriteLine("\n ===================== Chicken Burgers Menu ================== \n");
                Console.WriteLine("                     Lists        Price \n");
                Console.WriteLine("         1. Spicy Tandoori        100 ");
                Console.WriteLine("         2. Spicy Buffalo         100 ");
                Console.WriteLine("         3. BBQ Chicken            99 ");
                Console.WriteLine("         4. Crispy Chicken        160 ");
                Console.WriteLine("         5. Chicken Paradise      190 ");
                Console.WriteLine("\n ============================================================= ");

                // Pick your Order
                Console.Write("\n Enter your order: ");
                int order = Convert.ToInt32(Console.ReadLine());

                // Number of Order
                Console.Write(" How many: ");
                int manyOrder = Convert.ToInt32(Console.ReadLine());

                switch (order) {
                    case 1:
                        listFood.Add("Spicy Tandoori  ");
                        quantity.Add(manyOrder);
                        cost.Add(100);
                        break;
                    case 2:
                        listFood.Add("Spicy Buffalo   ");
                        quantity.Add(manyOrder);
                        cost.Add(100);
                        break;
                    case 3:
                        listFood.Add("BBQ Chicken     ");
                        quantity.Add(manyOrder);
                        cost.Add(99);
                        break;
                    case 4:
                        listFood.Add("Crispy Chicken  ");
                        quantity.Add(manyOrder);
                        cost.Add(160);
                        break;
                    case 5:
                        listFood.Add("Chicken Paradise");
                        quantity.Add(manyOrder);
                        cost.Add(190);
                        break;
                }

                Console.Write("\n Do you want to order again? [y/n]: ");
                yn = Console.ReadLine()[0];

            } while (char.ToLower(yn) == 'y');

            if (char.ToLower(yn) == 'n') {
                Console.Write("\n Do you want to order in Beef Burger? [y/n]: ");
                nextMenu = Console.ReadLine()[0];

                if (char.ToLower(nextMenu) == 'y') {
                    chickenBurger();
                }

                // For Drinks
                Console.Write("\n Do you want to add drinks? [y/n]: ");
                nextMenu = Console.ReadLine()[0];

                if (char.ToLower(nextMenu) == 'y') {
                    availableDrinks();
                } else if (char.ToLower(nextMenu) == 'n') {
                    displayOrder(); // Calling Display Order Function
                }
            }
        }

        public void availableDrinks() {

            do {
                // Automatically Clear the Screen
                Console.Clear();

                Console.WriteLine("\n ==================== DRINKS ==================== \n");
                Console.WriteLine("            Lists             Price                 \n");
                Console.WriteLine("          1. Coke             29.99                   ");
                Console.WriteLine("          2. Sprite           27.35                   ");
                Console.WriteLine("          3. Royal            25.00                   ");
                Console.WriteLine("          4. Mountain Dew     30.00                   ");
                Console.WriteLine("          5. Pepsi Blue       35.00                   ");
                Console.WriteLine("\n ================================================   ");

                // Drinks
                Console.Write("\n Enter your Drinks: ");
                int drinks = Convert.ToInt32(Console.ReadLine());

                // Number of Drinks
                Console.Write(" How many? ");
                int manyOrder = Convert.ToInt32(Console.ReadLine());

                switch (drinks) {
                    case 1:
                        listFood.Add("Coke           ");
                        quantity.Add(manyOrder);
                        cost.Add(29.99);
                        break;
                    case 2:
                        listFood.Add("Sprite     ");
                        quantity.Add(manyOrder);
                        cost.Add(27.35);
                        break;
                    case 3:
                        listFood.Add("Royal           ");
                        quantity.Add(manyOrder);
                        cost.Add(25.00);
                        break;
                    case 4:
                        listFood.Add("Mountain Dew    ");
                        quantity.Add(manyOrder);
                        cost.Add(30.00);
                        break;
                    case 5:
                        listFood.Add("Pepsi Blue    ");
                        quantity.Add(manyOrder);
                        cost.Add(35.00);
                        break;
                }

                Console.Write("\n Do you want to order again? [y/n]: ");
                yn = Console.ReadLine()[0];

            } while (char.ToLower(yn) == 'y');

            if (char.ToLower(yn) == 'n') {
                displayOrder();
            }
        }

        // For Displaying Order
        public void displayOrder() {
            // Automatically Clear the Screen
            Console.Clear();

            Console.WriteLine("\n ===> List of Order <===");
            Console.WriteLine("\n      List\t\t   Quantity\t\t\t     Price\n");

            for (int i = 0; i < listFood.Count; i++) {
                Console.WriteLine($" {i + 1}. {listFood[i]} \t       {quantity[i]}\t\t\t      {cost[i]}");
            }
            // Display Total Order
            Console.WriteLine($"\n Total Order is: {orderTotal()}");

            // Enter Payment
            Console.Write("\n Enter Payment: ");
            int payment = Convert.ToInt32(Console.ReadLine());

            if (payment < orderTotal()) {
                Console.WriteLine("\n Insufficient Payment");
            } else if(payment > orderTotal()){
                double change = payment - orderTotal();
                Console.WriteLine($"\n Here's your change: {change}");
                Console.WriteLine(" Thank You! Come Again! ");
                Console.WriteLine(" ----------------------------------- ");
            }else if (payment == orderTotal()) {
                Console.WriteLine("\n Thank You! Come Again! ");
                Console.WriteLine(" ----------------------------------- ");
            }
        }

        public double orderTotal() {

            double total = 0;

            for (int i = 0; i < listFood.Count; i++) {
                total += cost[i] * quantity[i];
            }
            return total;
        }

    }
}
