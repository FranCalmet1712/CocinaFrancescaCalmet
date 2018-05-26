using System;
using System.Collections.Generic;
using System.Text;

namespace CocinaFranCalmetXd
{
    class Refrigerador : Electrodomesticos
    {
        public int espacio;
        public Comida[] inventario;

        public Refrigerador(string marca_, float energia_, int espacio_)
        {
            marca = marca_;
            energia = energia_;
            espacio = espacio_;
            inventario = new Comida[espacio];
        }

        public void Guardar (Comida _Alimentos)
        {
            for (int i = 0; i < espacio; i++) {
                if (inventario[i] == null)
                {
                    inventario[i] = _Alimentos;
                    Console.WriteLine("Guardado: " + _Alimentos.nombre);
                    return;
                }
            }
            Console.WriteLine("Refrigerador lleno!");
        }

        public Comida Buscar (string nombre_) {
            for (int i = 0; i < espacio; i++) {
                if (inventario[i] != null) {
                    if (inventario[i].nombre == nombre_) {
                        Console.WriteLine("Encontrado: " + nombre_);
                        return inventario[i];
                    }
                }
            }
            Console.WriteLine("No se encontró: " + nombre_);
            return null;
        }

        public Comida Sacar (string nombre_)
        {
            Comida comida;
            for (int i = 0; i < espacio; i++)
            {
                if (inventario[i] != null)
                {
                    if (inventario[i].nombre == nombre_)
                    {
                        comida = inventario[i];
                        inventario[i] = null;
                        return comida;
                    }
                }
            }
            Console.WriteLine("No se encontró: " + nombre_);
            return null;

        }

    }
}
