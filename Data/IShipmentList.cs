using Freightor.Models;

namespace Freightor.Data
{
    public interface IShipmentList
    {
        public List<Shipment> GetShipments();
    }
}