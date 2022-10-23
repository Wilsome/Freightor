using Freightor.Models;

namespace Freightor.Data
{
    public class ShipmentList : IShipmentList
    {

        List<Shipment> _shipments;

        public ShipmentList()
        {
            _shipments = new List<Shipment>

            {
                new Shipment
                {
                    Id = 1,
                    Carrier = "LandStar",
                    Cost = 500.00m,
                    Date = DateTime.Now,
                    Description = "Magic cards",
                    EnteredBy = "Dispatch 003",
                    Pieces = 22,
                    QuotedAmount = 750.00m,
                    TrackingNumber = "123-4567890",
                    Weight = 40000,
                    Status = "Booked",
                    Shipper = new Point
                    {
                        Id = 1,
                        BusinessName = "Forte Logistics",
                        City = "Fife",
                        State = "WA",
                        Zip = "98424",
                        Unit = "Suite 200",
                        Street = "301 54th ave east",
                        Contacts = new List<Contact>
                        { new Contact {Id = 1, FirstName="Tony", LastName="Stark",
                            CellPhone = "555-123-4567", Email = "Thee.IronMan3001@google.mcu", Phone ="206-555-5555" } },
                        PointNotes = new List<PointNote>
                        { new PointNote {Id = 0, Date = DateTime.Now,EnteredBy ="Pepper Pots",
                            Note ="Shipping hours 0800-1600"} }
                    },
                    Consignee = new Point
                    {
                        Id = 2,
                        BusinessName = "Stark Towers",
                        City = "New York",
                        State = "NY",
                        Zip = "11765",
                        Unit = "N/A",
                        Street = "123 East Main street",
                        Contacts = new List<Contact>
                            { new Contact {Id = 2, FirstName ="Peter", LastName = "Parker",
                                CellPhone = "555-321-4242", Email ="PParker@gmail.com", Phone ="253-555-9999"} },
                        PointNotes = new List<PointNote>
                            { new PointNote {Id = 1, Date = DateTime.Now, EnteredBy = "Temp",
                                Note ="All deliveries require lift gates"} }
                    },
                    ShipmentNotes = new List<ShipmentNote>
                        { new ShipmentNote {Id = 2, Created = DateTime.Now,
                            EnteredBy = "Customer service", Note = "Freight delay by weather"},
                        new ShipmentNote{Id = 3, Created = DateTime.Now, EnteredBy="Sales associate", Note ="At destination dock." }
                    }
                },
                new Shipment
                {
                    Id = 2,
                    Carrier = "Fedex Freight",
                    Cost = 100.00m,
                    Date = DateTime.Now,
                    Description = "Shoes",
                    EnteredBy = "Dispatch 005",
                    Pieces = 567,
                    QuotedAmount = 374.33m,
                    TrackingNumber = "123-0987654",
                    Weight = 22345,
                    Status = "Quote",
                    Shipper = new Point
                    {
                        Id = 3,
                        BusinessName = "Amazon",
                        City = "Seattle",
                        State = "WA",
                        Zip = "98201",
                        Unit = "Building 4",
                        Street = "4 12 South mercer",
                        Contacts = new List<Contact> { new Contact {Id = 3, FirstName="Bob", LastName="Parr",
                     CellPhone = "555-123-7880", Email = "BParr8080@Live.com", Phone ="206-555-5432" } },
                        PointNotes = new List<PointNote> { new PointNote {Id = 3, Date = DateTime.Now,
                     EnteredBy ="Helen Parr", Note ="offsite warehouse, call 30min before delivery"} }
                    },
                    Consignee = new Point
                    {
                        Id = 4,
                        BusinessName = "Metro City Plaza",
                        City = "Metro City",
                        State = "UT",
                        Zip = "87603",
                        Unit = "B-12",
                        Street = "19227 106th Ave SE",
                        Contacts = new List<Contact> { new Contact {Id = 4, FirstName ="Lois", LastName = "Lane",
                        CellPhone = "888-212-9988", Email ="LoisL@gmail.com", Phone ="253-555-9999"} },
                        PointNotes = new List<PointNote> { new PointNote {Id = 4, Date = DateTime.Now, EnteredBy = "Reciving",
                        Note ="Deliveries after 1700, around back of building."} }
                    },
                    ShipmentNotes = new List<ShipmentNote> { new ShipmentNote {Id = 4, Created = DateTime.Now,
                       EnteredBy = "Customer service", Note = "Shipment is ontime."}
                    }
                }


            };
        }

        public List<Shipment> GetShipments() 
        {
            return _shipments;
        }
    }
}
