using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models {
   public class Agentes {

        // id, nome, esquadra, foto

        public int ID { get; set; }

        [Required(ErrorMessage ="Por favor, escreva o Nome do Agente.")]
        [RegularExpression("[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûäëïöüãõç]+(( |'|-| dos | da | de | e | d')[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûäëïöüãõç]+){1,3}",
           ErrorMessage = "O {0} apenas pode conter letras e espaços em branco. Cada palavra começa por uma maiúscula, seguida de minúsculas...")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Não se esqueça de indicar a Esquadra onde o agente trabalha, por favor.")]
        [RegularExpression("(Tomar|Ourém|Torres Novas|Lisboa|Leiria)")]
        public string Esquadra { get; set; }

        public string Fotografia { get; set; }

        // coleção de objetos do tipo Multas
        // lista de multas que um Agente passou
        public ICollection<Multas> ListaDasMultas { get; set; }
    }
}