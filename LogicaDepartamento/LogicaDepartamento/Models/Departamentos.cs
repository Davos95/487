using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDepartamento.Models
{
    [Table("DEPT")]
    [DataContract]
    public class Departamentos
    {
        [Key]
        [Column("DEPT_NO")]
        [DataMember]
        public int Numero { get; set; }

        [Column("DNOMBRE")]
        [DataMember]
        public String Nombre { get; set; }

        [Column("LOC")]
        [DataMember]
        public String Localidad { get; set; }

    }
}
