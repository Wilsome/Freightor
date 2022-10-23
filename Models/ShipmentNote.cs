namespace Freightor.Models
{
    public class ShipmentNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; }
        public string EnteredBy { get; set; }
    }
}
