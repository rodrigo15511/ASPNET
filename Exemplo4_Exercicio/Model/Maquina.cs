using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exemplo4_Exercicio.Model
{
    [Table("maquina")]
    public class Maquina
    {
        [Column("id_maquina")]
        public int Id_Maquina { get; set; }

        [Column("tipo")]
        public string tipo { get; set; }

        [Column("velocidade")]
        public int velocidade { get; set; }

        [Column("harddisk")]
        public int harddisk { get; set; }

        [Column("placa_rede")]
        public string placarede { get; set; }

        [Column("memoria_ram")]
        public int memoriaram { get; set; }

        [ForeignKey("fk_usuario")]
        [Column("fk_usuario")]
        public int fk_usuario { get; set; }
    }
}