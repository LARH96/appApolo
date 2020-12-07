﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IDALMinisterioHacienda
    {
        bool CreateMinisterioHacienda(MinisterioHacienda pMinisterioHacienda);
        int GetNextNumeroConsecutivo();
        int GetCurrentNumeroConsecutivo();
    }
}
