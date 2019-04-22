using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemLangeri.Models
{

    public class Client 
    {
        
        
        public int QtdDeCompUnit { get; set; }
        public int QtdDeCompUnitCalc { get; set; }
        public int QtdDeCompUnitSut { get; set; }
        public int QtdDeCompUnitConj { get; set; }
        public DateTime DateCli { get; set; }
        public virtual Pessoa Pessoa { get; set; }

    }
}
