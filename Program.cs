int numberEntered;
int intento = 0;
int[] numbersR = new int[10];
int otherN;

Random random = new Random();

List<int> numbers = new List<int>();

for (int i = 0; i <= 100; i++)
{
    numbers.Add(i);
}

for (int i = 0; i < numbersR.Length; i++)
{
    int randomNumber = random.Next(numbers.Count);
    numbersR[i] = numbers[randomNumber];
}

otherN = numbersR.Last();
int[] nuevoArray = numbersR.Take(numbersR.Length - 1).ToArray();

Console.WriteLine("\n********** Adivina el numero oculto **********");
Console.WriteLine("\nA continuacion verás un total de 9 números deberas de adivinar el décimo");
foreach (int r in nuevoArray)
{
    Console.Write("{0} ", r);
}

Console.WriteLine(" Cuál es el número?");

do
{
    intento++;
    numberEntered = Convert.ToInt32(Console.ReadLine());

    if (numberEntered < otherN)
    {
        Console.WriteLine("Mas alto!");
    }
    if (numberEntered > otherN)
    {
        Console.WriteLine("Mas bajo!");
    }

} while (otherN != numberEntered);

Console.WriteLine("Ganaste!!!  te tomó {0} intentos", intento);
Console.ReadKey();