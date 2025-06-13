namespace NorthWind.Modelos.Dtos
{
    public class OrdenDto
    {
        public int OrdenId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int CustomerId { get; set; }
    }
}
