namespace estructuraderepeticiónwhile.Class;
public class TareaWhile
{
    public void SumaYPromedio()
    {
        int contador = 0;
        int suma = 0;

        while (contador < 10)
        {
            Console.Write("Ingrese un valor: ");
            int valor = int.Parse(Console.ReadLine());
            suma += valor;
            contador++;
        }

        double promedio = suma / 10.0;
        Console.WriteLine($"La suma de los valores es: {suma} ");
        Console.WriteLine($"El promedio de los valores es: {promedio} ");
    }

    public void PiezasAptas()
    {
        Console.Write("Ingrese la cantidad de piezas a procesar: ");
        int cantidadPiezas = int.Parse(Console.ReadLine());
        int contador = 0;
        int piezasAptas = 0;

        while (contador < cantidadPiezas)
        {
            Console.Write("Ingrese la longitud de la pieza: ");
            double longitud = double.Parse(Console.ReadLine());

            if (longitud >= 1.20 && longitud <= 1.30)
            {
                piezasAptas++;
            }

            contador++;
        }

        Console.WriteLine($"La cantidad de piezas aptas es: {piezasAptas}");
    }

    public void NotasDeAlumnos()
    {
        int contador = 0;
        int notasMayoresIguales7 = 0;
        int notasMenores7 = 0;

        while (contador < 10)
        {
            Console.Write("Ingrese una nota: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                notasMayoresIguales7++;
            }
            else
            {
                notasMenores7++;
            }

            contador++;
        }

        Console.WriteLine($"Cantidad de notas mayores o iguales a 7: {notasMayoresIguales7}");
        Console.WriteLine($"Cantidad de notas menores a 7: {notasMenores7}");
    }

    public void SueldosDeEmpleados()
    {
        Console.Write("Ingrese la cantidad de empleados: ");
        int cantidadEmpleados = int.Parse(Console.ReadLine());
        int contador = 0;
        int sueldosEntre100y300 = 0;
        int sueldosMayores300 = 0;
        double sumaSueldos = 0;

        while (contador < cantidadEmpleados)
        {
            Console.Write("Ingrese el sueldo del empleado: ");
            double sueldo = double.Parse(Console.ReadLine());
            sumaSueldos += sueldo;

            if (sueldo >= 100 && sueldo <= 300)
            {
                sueldosEntre100y300++;
            }
            else if (sueldo > 300)
            {
                sueldosMayores300++;
            }

            contador++;
        }

        Console.WriteLine($"Cantidad de empleados que cobran entre $100 y $300: {sueldosEntre100y300}");
        Console.WriteLine($"Cantidad de empleados que cobran más de $300: {sueldosMayores300}");
        Console.WriteLine($"Importe total que gasta la empresa en sueldos: {sumaSueldos}");
    }
}
