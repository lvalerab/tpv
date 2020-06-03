using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace CLSBASE.INTERFACES
{
    public interface IElemento
    {
        bool Validar(ref string textoerr);        
        void Guardar();
    }
}
