using System;
using System.Collections.Generic;
using System.Text;

namespace BlockStock.COMMON.Entidades
{
   public class vale:Base
    {
        public DateTime FechaHoraSolicitud 
        { get; set; }
        public DateTime FechaEntrega { get; 
            set; }
        public DateTime? FechaEntregaReal { get; 
            set; }
        public List <Material> 
            MaterialesPrestados { get; set; }
        public empleado solicitante { get; 
            set; }
        public empleado Encargadodeblockstock { get; 
            set; }

    }
}
