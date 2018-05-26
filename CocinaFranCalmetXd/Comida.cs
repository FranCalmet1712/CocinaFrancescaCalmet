using System;
using System.Collections.Generic;
using System.Text;

namespace CocinaFranCalmetXd
{
    
    class Comida
    {
        public string nombre;
        public enum Sabor
        {
            Acido,
            Dulce,
            Salado,
            Neutro,
        }
        public Sabor sabor;

        public Comida (string nombre_, Sabor sabor_)
        {
            nombre = nombre_;
            sabor = sabor_;
        }

        public void Calentar () {
            nombre = nombre + " Caliente";
        }
    }
}
