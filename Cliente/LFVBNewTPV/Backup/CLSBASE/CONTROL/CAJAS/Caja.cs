using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;

namespace CLSBASE.CONTROL.CAJAS
{
    public class Caja:IElemento
    {
        #region Miembros de IElemento

        public bool Validar(ref string textoerr)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Guardar()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
