using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Logs
{
    public class clsEvento
    {
        public clsEvento(string mensaje, string tipo)
        {
            try
            {
                EventLogs evento = new EventLogs();
                evento.Origen = "SISSODINA";           //Nombre de la aplicación o servicio que genera el evento
                evento.TipoOrigen = "APPLICATION";   //Origen del evento (Application/System/Nombre personalizado)
                evento.Evento = "Errores";           //Nombre del evento a auditar
                evento.Mensaje = mensaje;
                evento.TipoEntrada = tipo;   // 1=Error/2=FailureAudit/3=Information/4=SuccessAudit/5=Warning
                evento.Archivo = "";


                escribirMensajeLog(evento);

                //Añade la anotación en la lista

            }
            catch (Exception)
            { }
        }
        
        public void escribirMensajeLog(EventLogs evento)
        {
            try
            {
                EventLog miLog = new EventLog(evento.TipoOrigen, ".", evento.Origen);
                //Comprobamos si existe el registro de sucesos
                if (!EventLog.SourceExists(evento.Origen))
                {
                    //Si no existe el registro de sucesos, lo creamos
                    EventLog.CreateEventSource(evento.Origen, evento.TipoOrigen);
                }
                else
                {
                    // Recupera el registro de sucesos correspondiente del origen.
                    evento.TipoOrigen = EventLog.LogNameFromSourceName(evento.Origen, ".");
                }

                miLog.Source = evento.Origen;
                miLog.Log = evento.TipoOrigen;

                //Comprobamos el tipo de anotación y grabamos el evento
                switch (evento.TipoEntrada)
                {
                    case "1":
                        miLog.WriteEntry(evento.Mensaje, EventLogEntryType.Error);
                        break;
                    case "2":
                        miLog.WriteEntry(evento.Mensaje, EventLogEntryType.FailureAudit);
                        break;
                    case "3":
                        miLog.WriteEntry(evento.Mensaje, EventLogEntryType.Information);
                        break;
                    case "4":
                        miLog.WriteEntry(evento.Mensaje, EventLogEntryType.SuccessAudit);
                        break;
                    case "5":
                        miLog.WriteEntry(evento.Mensaje, EventLogEntryType.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
