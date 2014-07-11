using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySql.Web.Extension.MySql.Web.Security.Tables.Negocio
{
    [Table("Bancos")]
    public class Banco
    {
        public Banco() { }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar"), StringLength(256)]
        public string Nome { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}
