namespace EstructurasCondicionales.Class
{
    public class Programa1
    {
        public void CalcularPerimetro()
        {
            int lado = 0;
            int perimetro = 0;

            try
            {
                Console.WriteLine("Digite la longitud del lado del cuadrado: ");
                lado = int.Parse(Console.ReadLine());

                perimetro = lado * 4;

                Console.WriteLine($"El perimetro del cuadrado es: { perimetro }");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguente error: {ex.Message}");
            }
        }
    }
}
