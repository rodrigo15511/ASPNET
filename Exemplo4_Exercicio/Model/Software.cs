using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Exemplo4_Exercicio.Model
{
    public class Software
    {
       [Column("id_software")]
        public int id_software { get; set; }

        [Column("produto")]
        public string produto { get; set; }

        [Column("harddisk")]
        public int harddisk { get; set; }
       
        [Column("memoria_ram")]
        public int memoriaram { get; set; }

        [ForeignKey("id_maquina")]
        [Column("id_maquina")]
        public int id_maquina { get; set; } 
    }
}