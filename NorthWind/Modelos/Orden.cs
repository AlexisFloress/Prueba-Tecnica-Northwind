using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.Modelos
{
    public class Orden
    {
        [Key]
        public int OrdenId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }

        //Foreing Key

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Cliente Cliente { get; set; }


    }
}
