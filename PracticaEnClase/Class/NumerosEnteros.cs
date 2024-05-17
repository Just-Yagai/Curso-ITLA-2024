namespace PracticaEnClase.Class
{
    public class NumerosEnteros
    {
        public void numEnteros()
        {
            int numerosEnteros = 0;
            int multipleDe3 = 0;
            int multipleDe5 = 0;

            Console.WriteLine("Digite la cantidad de numeros que desee: ");
            numerosEnteros = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numerosEnteros; i++)
            {
                Console.WriteLine($"Digite el numero: {i}");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 3 == 0) { multipleDe3++; }

                if (numero % 5 == 0) { multipleDe5++; }
            }

            Console.WriteLine($"Cantidad de numeros multiple de 3 son: {multipleDe3}");
            Console.WriteLine($"Cantidad de numeros multiple de 5 son: {multipleDe5}");
        }
    }
}
