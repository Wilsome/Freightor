namespace Freightor.Models
{
    public class Point
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string Street { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<PointNote> PointNotes { get; set; }
    }
}
