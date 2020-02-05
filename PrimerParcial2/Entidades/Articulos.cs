using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial2.Entidades
{
    public class Articulos
    {
        [Key]

        public int ArticulosId { get; set; }

        public DateTime Fecha { get; set; }

        [Required(ErrorMessage ="No puede estar vacio")]
        public string Descripcion{ get; set; }

        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum:1,maximum:1000000,ErrorMessage ="No puede pasar los limites")]
        public decimal Costo { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 1000000, ErrorMessage = "No puede pasar los limites")]
        public decimal Ganancia{ get; set; }
       
        public decimal Precio { get; set; }

        public Articulos()
        {
            ArticulosId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
        }
    }
}
