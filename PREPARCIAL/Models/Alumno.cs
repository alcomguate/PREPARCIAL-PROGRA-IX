//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PREPARCIAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Alumno
    {
        public string carne { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string tercer_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime fec_nacimiento { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string tel_celular { get; set; }
        public string tel_domicilio { get; set; }
    }
}
