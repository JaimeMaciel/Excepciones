using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Pizza
    {

        private string tamaño;
        public string Tamaño
        {
            set
            {
                tamaño = value;
            }
            get
            {
                return tamaño;
            }
        }
        private string[] ingredientes = new string[7];
        public string[] Ingredientes
        {
            get
            {
                return ingredientes;
            }
        }
        int numIngredientes = 0;
        public void AgregarIngrediente(string ingrediente)
        {
            ingredientes[numIngredientes] = ingrediente;
            numIngredientes++;
        }
        private bool tieneQuesoExtra;
        public bool TieneQuesoExtra
        {
            set
            {
                tieneQuesoExtra = value;
            }
            get
            {
                return tieneQuesoExtra;
            }
        }
        private bool esMasaDelgada;
        public bool EsMasaDelgada
        {
            set
            {
                esMasaDelgada = value;
            }
            get
            {
                return esMasaDelgada;
            }
        }
        
        private decimal costo;
        public decimal Costo
        {
            get
            {
                 switch (tamaño.ToUpper())
                    {
                        case "INDIVIDUAL":
                            costo = 49;
                            break;
                        case "MEDIANA":
                            costo = 79;
                            break;
                        default:
                            costo = 149;
                            break;
                    }
                    costo += (numIngredientes > 1) ? (numIngredientes - 1) * 20 : 0;
                    costo += (tieneQuesoExtra) ? 15 : 0;
                    costo += (esMasaDelgada) ? 40 : 0;
                    return costo;
                
                }
        }
    

    }
}
