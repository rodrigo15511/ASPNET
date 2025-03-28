using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exemplo4_Exercicio.Model
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Column("id_usuario")]
        public int id {get; set;}
        [Column("password")]
        public string nome {get; set;}
        [Column("nome_usuario")]
        public string nomeusuario {get; set;}
        [Column("ramal")]
        public string email {get; set;}
        [Column("especialidade")]
        public string especialidade {get; set;}
    }
}