using System;

namespace CocinaFranCalmetXd
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerador refrigerador = new Refrigerador("LG", 100f, 6);
            OllaArrocera ollaArrocera = new OllaArrocera("LG", 100f);

            refrigerador.Guardar(new Comida("Brownies", Comida.Sabor.Dulce));
            refrigerador.Guardar(new Comida("Arroz", Comida.Sabor.Neutro));
            refrigerador.Guardar(new Comida("Agua", Comida.Sabor.Neutro));
            refrigerador.Guardar(new Comida("Papa Rellena", Comida.Sabor.Neutro));
            refrigerador.Guardar(new Comida("Limon", Comida.Sabor.Acido));
            refrigerador.Guardar(new Comida("Galletas", Comida.Sabor.Dulce));

            Comida agua = refrigerador.Sacar("Agua");

            Console.WriteLine("Usar: " + agua.nombre);

            if (agua != null)
            {
                ollaArrocera.CalentarAgua(agua);
            }

            Console.WriteLine("Conseguido: " + agua.nombre);

            Comida arroz = refrigerador.Sacar("Arroz");

            Console.WriteLine("Usar: " + arroz.nombre);

            if (arroz != null)
            {
                ollaArrocera.PrepararArroz(arroz);
            }

            Console.WriteLine("Conseguido: " + arroz.nombre);

            Console.ReadLine();
        }
    }
}
