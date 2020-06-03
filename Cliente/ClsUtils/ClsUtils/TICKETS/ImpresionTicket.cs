using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.CRM.DOCUMENTOS;
using System.Data;
using System.Collections;
using CLSBASE.CRM.PERSONAS;
using CLSBASE.CRM.RESERVAS;

namespace ClsUtils.TICKETS
{
    public enum TIPO_PLANTILLAS_TICKET
    {
        TICKET,
        RESERVA
    }

    public class ImpresionTicket
    {
        public static string[] PlantCab;
        public static string[] PlantTot;
        public static string[] PlantPie;

        private static string[] LeeLineasFich(string ruta)
        {
            try
            {
                return System.IO.File.ReadAllLines(ruta);
            }
            catch (Exception err)
            {
                return new string[] { "ERROR - " + err.Message };
            }

        }

        private static void GuardaLineasFich(string ruta, string[] lineas)
        {
            try
            {
                System.IO.File.WriteAllLines(ruta, lineas);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public static void CargaPlantilla(TIPO_PLANTILLAS_TICKET tipo)
        {
            string ruta="";
            switch (tipo)
            {
                case TIPO_PLANTILLAS_TICKET.TICKET:
                    ruta = AppDomain.CurrentDomain.BaseDirectory + @"\PLTICKET";
                    break;
                case TIPO_PLANTILLAS_TICKET.RESERVA:
                    ruta = AppDomain.CurrentDomain.BaseDirectory + @"\PLRESERVA";
                    break;
            }
            
            if (System.IO.Directory.Exists(ruta))
            {

                PlantCab = LeeLineasFich(ruta + @"\CAB_TICKET.TXT");
                PlantTot = LeeLineasFich(ruta + @"\TOT_TICKET.TXT");
                PlantPie = LeeLineasFich(ruta + @"\PIE_TICKET.TXT");

            }
            else
            {
                PlantCab = new string[] { "Empresa 1 - C.I.F: 00000000A",
                                          "C\\ Calle, nº 1, esc 1, 1ºA",
                                          "03640 - Monóvar",
                                          "Alicante",
                                          "=================================",
                                          "Ticket Nº: {NUM_DOC}",
                                          "Fecha Exp: {FECHA_DOC}",
                                          "================================="};
                PlantTot=new string[] {
                                         "TOTAL BRUTO:","{TOTAL_BRUTO}",
                                         "TOTAL IVA:","{TOTAL_IVA}",
                                         "IMPORTE:  ","{IMPORTE_TOTAL}"
                };
                PlantPie = new string[] { "TEXTO PIE 1",
                                          "TEXTO PIE 2",
                                          "TEXTO PIE 3"};
            }
        }

        public static void GuardaPlantilla(TIPO_PLANTILLAS_TICKET tipo)
        {
            string ruta = "";
            switch (tipo)
            {
                case TIPO_PLANTILLAS_TICKET.TICKET:
                    ruta = AppDomain.CurrentDomain.BaseDirectory + @"\PLTICKET";
                    break;
                case TIPO_PLANTILLAS_TICKET.RESERVA:
                    ruta = AppDomain.CurrentDomain.BaseDirectory + @"\PLRESERVA";
                    break;
            }
            if (!System.IO.Directory.Exists(ruta))
            {
                System.IO.Directory.CreateDirectory(ruta);
            }
             GuardaLineasFich(ruta + @"\CAB_TICKET.TXT",PlantCab);
             GuardaLineasFich(ruta + @"\TOT_TICKET.TXT", PlantTot);
             GuardaLineasFich(ruta + @"\PIE_TICKET.TXT",PlantPie);
        }

        public static void ImprimirTicket(string impresora, Documento doc, Persona cliente)
        {
            Ticket t = new Ticket();
            for (Int32 i = 0; i < PlantCab.Length; i++)
            {
                string linea = PlantCab[i];
                linea=linea.Replace("{NUM_DOC}", doc.datos["COD_TIDO"].ToString().PadLeft(2, ' ') + "-" + doc.datos["NUMERO_CADO"].ToString().PadLeft(10, '0') + "/" + doc.datos["ANYO_CADO"].ToString().PadLeft(4, '0'));
                DateTime fechadoc;
                DateTime.TryParse(doc.datos["FECHA_ENTRADA_CADO"].ToString(),out fechadoc);
                linea = linea.Replace("{FECHA_DOC}", fechadoc.ToString("dd/MM/yyyy HH:mm:ss"));
                t.AddHeaderLine(linea);
            }
            if (cliente!=null)
            {
                t.AddHeaderLine(new String('=', 35));
                t.AddHeaderLine("Datos Cliente:");
                t.AddHeaderLine(new String('-',35));
                t.AddHeaderLine(cliente.datos["NIF_PERS"].ToString() + " - " + cliente.datos["NOMBRE_PERS"].ToString()); ;
                t.AddHeaderLine(cliente.datos["DIRE_PERS"].ToString());
                t.AddHeaderLine(cliente.datos["CODPOSTAL_PERS"].ToString() + " " + cliente.datos["POBLACION_PERS"].ToString());
                t.AddHeaderLine(cliente.datos["PROVINCIA_PERS"].ToString());
                t.AddHeaderLine(new String('=', 35));
            }
            foreach (DataRow dr in doc.lineas.Rows)
            {
                t.AddItem(dr["CANTIDAD_LIDO"].ToString(), dr["TEXTO_LIDO"].ToString(), ((double)dr["TOTAL_LIDO"]).ToString("F2"));
            }
            Hashtable totales=doc.ObtenTotalesDocumento();
            for (Int32 i = 0; i < PlantTot.Length; i += 2)
            {
                string valor=PlantTot[i+1];
                valor=valor.Replace("{TOTAL_BRUTO}",((double)totales["PVB"]).ToString("F2"));
                valor = valor.Replace("{TOTAL_IVA}", ((double)totales["PIM"]).ToString("F2"));
                valor = valor.Replace("{IMPORTE_TOTAL}", ((double)totales["PVP"]).ToString("F2"));
                t.AddTotal(PlantTot[i], valor);
            }
            for (Int32 i = 0; i < PlantPie.Length; i++)
            {
                t.AddFooterLine(PlantPie[i]);
            }
            t.PrintTicket(impresora);
        }

        public static void ImprimirReserva(string impresora, Reserva res, Persona cliente)
        {
            Ticket t = new Ticket();
            for (Int32 i = 0; i < PlantCab.Length; i++)
            {
                string linea = PlantCab[i];
                linea = linea.Replace("{NUM_DOC}", res.datos["ID_ELEM"].ToString());
                DateTime fechadoc;
                DateTime.TryParse(res.datos["FECHA_GRABACION_CARE"].ToString(), out fechadoc);
                linea = linea.Replace("{FECHA_DOC}", fechadoc.ToString("dd/MM/yyyy HH:mm:ss"));
                t.AddHeaderLine(linea);
            }
            if (cliente != null)
            {
                t.AddHeaderLine(new String('=', 35));
                t.AddHeaderLine("Datos Cliente:");
                t.AddHeaderLine(new String('-', 35));
                t.AddHeaderLine(cliente.datos["NIF_PERS"].ToString() + " - " + cliente.datos["NOMBRE_PERS"].ToString()); ;
                t.AddHeaderLine(cliente.datos["DIRE_PERS"].ToString());
                t.AddHeaderLine(cliente.datos["CODPOSTAL_PERS"].ToString() + " " + cliente.datos["POBLACION_PERS"].ToString());
                t.AddHeaderLine(cliente.datos["PROVINCIA_PERS"].ToString());
                t.AddHeaderLine(new String('=', 35));
            }
            double total = 0;
            foreach (DataRow dr in res.lineas.Rows)
            {
                t.AddItem(dr["CANTIDAD_PROD"].ToString(), dr["DESCRIPCION_PROD"].ToString(), ((double)dr["TOTAL_LIRE"]).ToString("F2"));
                double auxt = 0;
                double.TryParse(dr["TOTAL_LIRE"].ToString(), out auxt);
                total += auxt;
            }
            for (Int32 i = 0; i < PlantTot.Length; i += 2)
            {
                string valor = PlantTot[i + 1];
                valor = valor.Replace("{TOTAL_BRUTO}", "0.00");
                valor = valor.Replace("{TOTAL_IVA}", "0.00");
                valor = valor.Replace("{IMPORTE_TOTAL}", total.ToString("F2"));
                t.AddTotal(PlantTot[i], valor);
            }
            for (Int32 i = 0; i < PlantPie.Length; i++)
            {
                t.AddFooterLine(PlantPie[i]);
            }
            t.AddFooterLine("La reserva tiene una validez de 15 días hábiles");
            t.PrintTicket(impresora);
        }

        public static void ImprimirLibre(string impresora, string[] cabecera, string CabLinea, string[][] lineas, string[] pie)
        {
            Ticket t = new Ticket();
            for (Int32 i = 0; i < cabecera.Length; i++)
            {
                t.AddHeaderLine(cabecera[i]);
            }
            t.CabLineaProd = CabLinea;
            //Añadimos lineas
            for (Int32 i = 0; i < lineas.Length; i++)
            {
                t.AddItem(lineas[i][0], lineas[i][1], lineas[i][2]);
            }
            //Añadimos el pie
            for (Int32 i = 0; i < pie.Length; i++)
            {
                t.AddFooterLine(pie[i]);
            }
            t.PrintTicket(impresora);
        }
    }
}
