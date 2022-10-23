namespace Freightor.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public Point Shipper { get; set; }
        public Point Consignee { get; set; }
        public string TrackingNumber { get; set; }
        public string Status { get; set; }
        public string Carrier { get; set; }
        public IEnumerable<ShipmentNote> ShipmentNotes { get; set; }
        public decimal Cost { get; set; }
        public decimal QuotedAmount { get; set; }
        public int Pieces { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
        public string EnteredBy { get; set; }
        public DateTime Date { get; set; }
        public bool Delete { get; set; } = false;

    }
}
