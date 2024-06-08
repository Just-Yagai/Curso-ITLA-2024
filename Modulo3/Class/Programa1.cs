namespace Modulo3.Class
{
    public class Programa1
    {
        public void Calculadora()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int diferencia = 0;
            int producto = 0;
            int division = 0;

            try
            {
                Console.WriteLine("Ingrese el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    suma = (num1 + num2);
                    diferencia = (num1 - num2);

                    Console.WriteLine($"El primer numero es mayor que el segundo..");
                    Console.WriteLine($"La suma es {suma}");
                    Console.WriteLine($"La diferencia es {diferencia}");
                }
                else
                {
                    producto = (num1 * num2);
                    division = (num1 / num2); ;
                    Console.WriteLine($"El primer numero no es mayor que el segundo..");
                    Console.WriteLine($"El producto es {producto}");
                    Console.WriteLine($"La division es {division}");
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }
        }
        
        public void NotaAlumno()
        {
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int promedio = 0;

            try
            {
                Console.WriteLine("Ingrese la primera nota: ");
                nota1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la segunda nota: ");
                nota2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la tercera nota: ");
                nota3 = Convert.ToInt32(Console.ReadLine());

                promedio = (nota1 + nota2 + nota3) / 3;

                if (promedio >=  7)
                {
                    Console.WriteLine("Promocionado");
                } else
                {
                    Console.WriteLine("Reprobado");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }
        }
        
        public void numeroPositivo()
        {
            int numero = 0;

            try
            {
                Console.WriteLine("Ingrese un numero positivo de uno o dos digitdos: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 1 && numero <= 99)
                {
                    if (numero < 10)
                    {
                        Console.WriteLine("El número tiene un dígito..");
                    }
                    else
                    {
                        Console.WriteLine("El número tiene dos dígitos..");
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }
        }
    }
}
