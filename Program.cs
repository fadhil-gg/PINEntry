int pin;


do
{
    Console.Write("Enter your pin(must be between 1000-9999): ");
    pin = int.Parse(Console.ReadLine());

   if (pin < 1000 || pin > 9999)
    {
        Console.WriteLine("Invalid pin. Please enter a 4-digit pin / between 1000 - 9999.");
    }
} while (pin < 1000 || pin > 9999);