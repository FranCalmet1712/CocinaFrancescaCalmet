using System;
using System.Collections.Generic;
using System.Text;

namespace CocinaFranCalmetXd
{
    class OllaArrocera : Electrodomesticos
    {
        private Comida aguaCaliente;

        public OllaArrocera(string marca_, float energia_)
        {
            marca = marca_;
            energia = energia_;
        }

        public void CalentarAgua(Comida agua) {
            if (agua.nombre == "Agua") {
                agua.Calentar();
                aguaCaliente = agua;
                return;
            }
            Console.WriteLine("No se puede usar " + agua.nombre);
        }

        public void PrepararArroz(Comida arroz)
        {
            if (aguaCaliente != null)
            {
                if (arroz.nombre == "Arroz")
                {
                    arroz.Calentar();
                }
            }
        }
    }
}
