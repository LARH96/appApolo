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
    class BLLMinisterioHacienda : IBLLMinisterioHacienda
    {
        public bool CreateMinisterioHacienda(MinisterioHacienda pMinisterioHacienda)
        {
            IDALMinisterioHacienda _IDALMinisterioHacienda = new DALMinisterioHacienda();
            return _IDALMinisterioHacienda.CreateMinisterioHacienda(pMinisterioHacienda);
        }

        public int GetCurrentNumeroConsecutivo()
        {
            IDALMinisterioHacienda _IDALMinisterioHacienda = new DALMinisterioHacienda();
            return _IDALMinisterioHacienda.GetCurrentNumeroConsecutivo();
        }

        public int GetNextNumeroConsecutivo()
        {
            IDALMinisterioHacienda _IDALMinisterioHacienda = new DALMinisterioHacienda();
            return _IDALMinisterioHacienda.GetNextNumeroConsecutivo();
        }
    }
}
