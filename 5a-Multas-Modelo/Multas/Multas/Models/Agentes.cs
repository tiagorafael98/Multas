using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models {
   public class Agentes {

        // id, nome, esquadra, foto

        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Esquadra { get; set; }

        public string Fotografia { get; set; }

        // coleção de objetos do tipo Multas
        // lista de multas que um Agente passou
        public ICollection<Multas> ListaDasMultas { get; set; }
    }
}