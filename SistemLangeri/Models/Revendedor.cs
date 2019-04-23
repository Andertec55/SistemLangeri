using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemLangeri.Models
{


    public class Revendedor
    {
        public int RevendedorId { get; set; }
        public DateTime DateRev { get; set; }
        public int QtdObtida { get; set; }
        public int QtdDeConjuntos { get; set; }
        public int QtdDeAvulsos { get; set; }
        public int QtdVendConj { get; set; }
        public int QtdVendAvul { get; set; }
        public double ValorTotal { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}