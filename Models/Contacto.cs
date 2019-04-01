using System;

namespace contactos.Models
{
    public class Contacto {
        public long? id {set; get;}
        public string nombre {set; get;}
        public string email {set; get;}
        public DateTime? nace {set; get;}
        public string mensaje {set; get;}
    }
}