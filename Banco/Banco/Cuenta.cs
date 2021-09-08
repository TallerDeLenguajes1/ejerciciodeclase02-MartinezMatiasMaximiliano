using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cuenta
    {
        public enum TipoDeExtraccion {CajeroHumano = 1, CajeroAutomatico = 2}

        private float cantidad;

        public float Cantidad { get => cantidad; set => cantidad = value; }

        public Cuenta() { }

        public void Insercion(int monto)
        {
            cantidad += monto;
        } 

        public void Extraccion(int monto,TipoDeExtraccion tipo)
        {

        }

    }

     
}
