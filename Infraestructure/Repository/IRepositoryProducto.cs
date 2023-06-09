﻿using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryProducto
    {
        IEnumerable<producto> ListadoProducto();
        producto ObtenerProductoID(int id);
        producto Save(producto plan, string[] selectProvedores);

    }
}
