using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CLSBASE.INTERFACES;

namespace CLSBASE.CRM.PRODUCTOS
{
    public class IVA:IMaestro
    {
        private const string _SQL = "select * from tiva_tipos_iva";

        private IVA()
        {
            this.refrescar();
        }

        #region "Miembros clase singleton"
        private static IVA _instancia;

        public static IVA ObtenInstancia()
        {
            if (IVA._instancia == null)
            {
                IVA._instancia = new IVA();
            }
            else
            {
                IVA._instancia.refrescar();
            }
            return IVA._instancia;
        }
        #endregion

        private DataTable _datos;
        public DataTable Datos
        {
            set
            {
                this._datos = value;
            }
            get
            {
                return this._datos;
            }
        }

        public void guardar()
        {
            IGlobal.guardar_datos(_SQL, ref this._datos);
        }

        public void refrescar()
        {
            if (this._datos != null)
            {
                this.guardar();
            }
            IGlobal.rellenar_datos(_SQL, ref this._datos);
        }

        public double AplicarIva(Double valor, string tipo)
        {   
            double res=valor;
            DataRow[] tipos=this._datos.Select("COD_TIVA='"+tipo+"'");
            if (tipos.Length > 0)
            {
                if (tipos.Length == 1)
                {
                    res = Math.Round(valor * Convert.ToDouble((tipos[0]["POR_IVA"] != null ? tipos[0]["POR_IVA"].ToString() : "1")), 2, MidpointRounding.AwayFromZero);                    
                }
                else
                {
                    DataRow tipoVigente = null;
                    foreach (DataRow t in tipos)
                    {
                        if (t["VIGENTE_IVA"].ToString() == "S")
                        {
                            tipoVigente = t;
                        }
                    }
                    if (tipoVigente != null)
                    {
                        res= Math.Round(valor * Convert.ToDouble((tipoVigente["POR_IVA"] != null ? tipoVigente["POR_IVA"].ToString() : "1")), 2, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        res= valor * 1;
                    }
                }
            }
            else
            {
                res= valor * 1;
            }
            return res;
        }

        public double QuitaIva(Double valor, string tipo)
        {
            DataRow[] tipos = this._datos.Select("COD_TIVA='" + tipo + "'");
            double res = valor;
            try
            {
                if (tipos.Length > 0)
                {
                    if (tipos.Length == 1)
                    {
                        res= Math.Round(valor / Convert.ToDouble((tipos[0]["POR_IVA"] != null ? tipos[0]["POR_IVA"].ToString() : "1")), 2, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        DataRow tipoVigente = null;
                        foreach (DataRow t in tipos)
                        {
                            if (t["VIGENTE_IVA"].ToString() == "S")
                            {
                                tipoVigente = t;
                            }
                        }
                        if (tipoVigente != null)
                        {
                            res = Math.Round(valor / Convert.ToDouble((tipoVigente["POR_IVA"] != null ? tipoVigente["POR_IVA"].ToString() : "1")), 2, MidpointRounding.AwayFromZero);
                        }
                        else
                        {
                            res = valor / 1;
                        }
                    }
                }
                else
                {
                    res = valor / 1;
                }
            }
            catch (DivideByZeroException err)
            {
                res = 0;
            }
            return res;
        }

        public double ObtenPorcentajer(string tipo)
        {
            double res = 1;
            DataRow[] tipos = this._datos.Select("COD_TIVA='" + tipo + "'");
            if (tipos.Length > 0)
            {
                if (tipos.Length == 1)
                {
                    res = Math.Round(Convert.ToDouble((tipos[0]["POR_IVA"] != null ? tipos[0]["POR_IVA"].ToString() : "1")), 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    DataRow tipoVigente = null;
                    foreach (DataRow t in tipos)
                    {
                        if (t["VIGENTE_IVA"].ToString() == "S")
                        {
                            tipoVigente = t;
                        }
                    }
                    if (tipoVigente != null)
                    {
                        res = Math.Round(Convert.ToDouble((tipoVigente["POR_IVA"] != null ? tipoVigente["POR_IVA"].ToString() : "1")), 2, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        res = 1;
                    }
                }
            }
            else
            {
                res = 1;
            }
            return res;
        }

        public static Int32 AplicaTipoIvaProds(string tipoInicial, string tipoFinal, bool AplicarPVP)
        {
            string sql = "select distinct prod.ID_ELEM from prod_productos prod inner join prpr_precios_producto prpr on prpr.COD_TIVA='"+tipoInicial+"' where prpr.VIGENTE_PRECIO='S'";
            DataTable prodAfectados=null;
            IGlobal.rellenar_datos(sql, ref prodAfectados);
            Productos lst=Productos.ObtenInstancia();
            IVA lsti=IVA.ObtenInstancia();
            foreach (DataRow reg in prodAfectados.Rows)
            {
                Producto p = lst.Buscar((Int64)reg["ID_ELEM"]);
                p.precio["COD_TIVA"] = tipoFinal;
                p.precio["PORC_IVA"] = lsti.ObtenPorcentajer(tipoFinal);
                if (AplicarPVP)
                {
                    p.precio["PRECIO_VENTA"] = lsti.AplicarIva((double)p.precio["PRECIO_BRUTO"], tipoFinal);
                }
                else
                {
                    p.precio["PRECIO_BRUTO"] = lsti.QuitaIva((double)p.precio["PRECIO_VENTA"], tipoFinal);
                }
                p.Guardar();
            }
            return prodAfectados.Rows.Count;
        }
    }
}
