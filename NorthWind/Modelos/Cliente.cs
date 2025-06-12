using System.ComponentModel.DataAnnotations;

namespace NorthWind.Modelos
{
    public class Cliente
    {
        [Key] 
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
