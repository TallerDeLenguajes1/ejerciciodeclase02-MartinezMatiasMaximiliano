using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CorrientePesos : Cuenta
    {
        public void Extraccion(int monto, TipoDeExtraccion tipo)
        {
            float insertado = Convert.ToInt32(Console.ReadLine());
            if (tipo == TipoDeExtraccion.CajeroAutomatico)
            {
                if (insertado > 20000)
                {
                    Console.WriteLine("no se puede retirar mas de 20000 por cajero automatico");
                }
                else
                {
                    this.Cantidad -= monto;
                }
            }
            else{
                this.Cantidad -= monto;
            }
        }
    }
}
