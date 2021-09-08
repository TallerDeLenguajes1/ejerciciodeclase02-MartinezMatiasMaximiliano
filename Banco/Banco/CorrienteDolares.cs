using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CorrienteDolares : Cuenta
    {
        public void Extraccion(int monto, TipoDeExtraccion tipo)
        {
            float insertado = Convert.ToInt32(Console.ReadLine());
            if (tipo == TipoDeExtraccion.CajeroAutomatico)
            {
                if (insertado > 200)
                {
                    Console.WriteLine("no se puede retirar mas de 200 por cajero automatico");
                }
                else
                {
                    this.Cantidad -= monto;
                }
            }
            else
            {
                this.Cantidad -= monto;
            }
        }
    }
}
