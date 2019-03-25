using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWebJob.Models
{
    [Table("TITULARES")]
    public class Noticia
    {
        [Key]
        [Column("IDTITULAR")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTitular { get; set; }
        [Column("TITULO")]
        public String Titular { get; set; }
        [Column("ENLACE")]
        public String Enlace { get; set; }
        [Column("DESCRIPCION")]
        public String Descripcion { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }

    }
}
