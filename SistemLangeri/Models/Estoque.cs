using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemLangeri.Models
{
    public class Estoque
    {
        public int EstoqueId { get; set; }
        
        public int QtdTotal { get; set; }
        public int QtdTotalConj { get; set; }
        public int QtdTotalCal { get; set; }
        public int QtdTotalSut { get; set; }
        public bool StatusInserirDados { get; set; }
        public DateTime DateEst { get; set; }
        public double ValorTotalBras { get; set; }
    }
}