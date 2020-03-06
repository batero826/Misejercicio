using System;

class Program
{
    static void Main(string[] args)
    {
        aprendiz apSena = new aprendiz();
        apSena.Nombre = "camilo humberto ";
        apSena.apellidos = "batero cuellar";
        apSena.DepartamentodeResidencia = " Huila ";
        apSena.Municipioderesidencia = "Pitalito ";
        apSena.direccion = "carrera 5 # 11-53 ";
        apSena.genero = "masculino"
        saludo(apSena);

    }
    private static void saludo(aprendiz apSena)
    {
        Console.WriteLine("Bienvenido,sr(a)" + apSena.Nombre + apSena.apellidos );
        Console.WriteLine("tu ciudad es: " + apSena.DepartamentodeResidencia);
        Console.WriteLine("tu municipio es: " + apSena.Municipioderesidencia);
        Console.WriteLine("tu dirección es: " + apSena.direccion);
        Console.ReadLine();
    }
}
