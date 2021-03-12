using System;

namespace Pizza_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            Pizza newPizza, newPizza2;
            string userInput;

            Console.WriteLine("This is the Pizza Factory program.\nHere is an object creation of 2 Pizzas.\n\n");

            newPizza = new Pizza("M", 5, "wheat");
            newPizza2 = new Pizza("L", 1, "white");

            Console.WriteLine("Two Pizzas have been created. These foods inherit the food class, allowing access to parental functionality, such as the GetNutrition method.\n\n");

            // Inherited method coming from the parent class Food.
            newPizza.GetNutrition();
            newPizza2.GetNutrition();

            Console.WriteLine("Method isSoftOrSolid() is an abstract method from the IFood interface." +
                " This method has not been defined yet, so when called, it will throw an Exception.\n" +
                "Enter 1 to enter the exception, or any other key to continue.\n\n");

            //Take user input
            userInput = Console.ReadLine();

            //add TryCatch here to validate user input
            try
            {
                if (Convert.ToInt32(userInput) == 1)
                {
                    newPizza.IsSoftOrSolid();
                }
            } catch (Exception e)
            {
                Console.WriteLine("You entered a non-numeric entry. Please try again.\n" + e.Message + "\n");
            }

            Console.WriteLine("Temperature is an abstract property, implemented from the IFood interface." +
                " This property is defined in the Pizza class, and is currently: " + "j" + "\n");

            //newPizza.temp;

            //add TryCatch here to validate second user input
            Console.WriteLine("Add toppings to the pizza.");
            userInput = Console.ReadLine();
            newPizza.AddToppings(userInput);


        /*    Console.Write("To attempt to add these toppings w/o first converting the returned string value to an integer " +
                "(due to C# requires that every non-null value have a well-defined type associated with it," +
                "thus causing an unhandled exception to occur, press 1." +
                "\nPress any other key to first do the parsing and properly add the toppings to the numberOfToppings property.");

            userInput = Console.ReadLine();

            if (userInput.Equals(1))
            {
                Console.WriteLine("Adding ");
            } 
            newPizza.addToppings(int.Parse(userInput));
        */
        }
    }
}
