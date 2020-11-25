using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IBLLTarjeta
    {
        List<Tarjeta> GetAllTarjeta();
        Tarjeta GetTarjetaById(string pIdTarjeta);
        Tarjeta SaveTarjeta(Tarjeta pTarjeta);
        bool DeleteTarjeta(int pId);
    }
}
