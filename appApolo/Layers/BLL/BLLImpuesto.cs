using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.DAL;

namespace UTN.Winforms.Apolo.Layers.BLL
{
    class BLLImpuesto : IBLLImpuesto
    {
        public Impuesto GetImpuesto()
        {
            IDALImpuesto _DALImpuesto = new DALImpuesto();

            return _DALImpuesto.GetImpuesto();
        }
    }
}
