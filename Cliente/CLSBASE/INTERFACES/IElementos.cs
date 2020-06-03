using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace CLSBASE.INTERFACES
{
    public interface IElementos
    {   
        void Guardar(ref MySqlConnection cn, ref MySqlTransaction tr);
        void Guardar();
        void Refrescar();
    }
}
