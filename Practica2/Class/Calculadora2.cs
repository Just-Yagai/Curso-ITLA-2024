using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Class
{
    public class Calculadora2
    {
        public void calcularNumMayor()
        {
            //Variables
            int num1 = 0;
            int num2 = 0;

            try
            {
                Console.WriteLine("Digite un numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite un numero: ");
                num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    var suma = num1 + num2;
                    var diferencia = num1 - num2;

                    Console.WriteLine($"El primer numero es mayor, La suma es {suma} y su deferencia es {diferencia}");
                } 
                else
                {
                    var producto = num1 * num2;
                    var division = num1 / num2;

                    Console.WriteLine($"El segundo numero es mayor o igual, El producto es {producto} y su division es {division}");
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguente error: {ex.Message}");
            }
        }

        public void calcularPromedio()
        {
            //Variables
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            decimal promedio = 0;

            try
            {
                Console.WriteLine("Digite la primera nota: ");
                nota1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la segunda nota: ");
                nota2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la tercera nota: ");
                nota3 = int.Parse(Console.ReadLine());

                promedio = (nota1 + nota2 + nota3) / 3;

                if (promedio >= 7)
                {
                    Console.WriteLine("Promocionado");
                }
                else
                {
                    Console.WriteLine("El promedio no alcanza para la promoción");
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguente error: {ex.Message}");
            }
        }

        public void calcularPromedioConMensaje()
        {
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;

            decimal promedio = 0;

            try
            {
                Console.WriteLine("Digite la primera nota: ");
                nota1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la segunda nota: ");
                nota2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la tercera nota: ");
                nota3 = int.Parse(Console.ReadLine());

                promedio = (nota1 + nota2 + nota3) / 3;

                if (promedio >= 7)
                {
                    Console.WriteLine("Promocionado");
                } 
                else if (promedio >= 4 & promedio < 7)
                {
                    Console.WriteLine("Regular");
                } 
                else if (promedio < 4)
                {
                    Console.WriteLine("Reprobado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguente error: {ex.Message}");
            }
        }
    }
}
