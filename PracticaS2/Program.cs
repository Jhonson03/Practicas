using PracticaS2.Entidades;
using PracticaS2.Negocio;

Nota nota = new Nota();
ClsNota clsNota = new ClsNota();

Console.WriteLine("Ingrese tu nota final para ver si usted aprobó o desaprobó");
nota.dat = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(clsNota.Verificador(nota));