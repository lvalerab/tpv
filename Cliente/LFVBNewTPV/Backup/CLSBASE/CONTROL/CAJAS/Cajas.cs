using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;

namespace CLSBASE.CONTROL.CAJAS
{
    public class Cajas:IElementos
    {
        #region Miembros de IElementos

        public void Guardar(ref MySql.Data.MySqlClient.MySqlConnection cn, ref MySql.Data.MySqlClient.MySqlTransaction tr)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Guardar()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Refrescar()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
