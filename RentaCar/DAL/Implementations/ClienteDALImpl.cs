﻿using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ClienteDALImpl : DALGenericoImpl<Cliente>, IClienteDAL
    {
        public ClienteDALImpl(RENTCARContext context) : base(context)
        {

        }
    }
}
