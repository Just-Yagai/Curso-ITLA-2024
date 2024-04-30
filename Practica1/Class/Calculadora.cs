namespace Practica1.Class
{
    public class Calculadora
    {
        public void CalculadoraProducto()
        {
            //Variables
            int num1 = 0;
            int num2 = 0;
            decimal suma = 0;
            decimal producto = 0;

            try
            {
                Console.WriteLine("Digite un numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite un numero: ");
                num2 = int.Parse(Console.ReadLine());

                suma = (num1 + num2);
                producto = (num1 * num2);

                Console.WriteLine($"La suma de los dos numeros es: {suma} y su producto es {producto}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguente error: {ex.Message}");
            }
        }
    }
}
