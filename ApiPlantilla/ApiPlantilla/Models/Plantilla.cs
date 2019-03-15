using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiPlantilla.Models
{
    [Table("PLANTILLA")]
    public class Plantilla
    {
        [Column("HOSPITAL_COD")]
        public int HospitalCod { get; set; }
        [Key]
        [Column("EMPLEADO_NO")]
        public int Empno { get; set; }
        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [Column("FUNCION")]
        public String Funcion { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }

    }
}