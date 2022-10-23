using Freightor.Data;
using Freightor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Freightor.Controllers
{
    public class ShipmentController : Controller
    {
        private List<Shipment> _shipments;

        public ShipmentController(IShipmentList list)
        {
            _shipments = list.GetShipments();
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Shipment> activeList = _shipments.Where(s => s.Delete == false);
            return View(activeList);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            //validate id
            if (id <= 0)
            {
                return NotFound();
            }
            //pull shipment from the list
            Shipment model = _shipments.SingleOrDefault(s => s.Id == id);
            //test if model is valid
            if (model == null)
            {
                return NotFound();
            }
            //serve up view 
            return View(model);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //check id valid
            if (id <= 0) 
            {
                return NotFound();
            }

            //pull shipment from list
            Shipment model = _shipments.SingleOrDefault(s => s.Id == id);

            //check model valid
            if (model == null) 
            {
                return NotFound();
            }
            //serve model up to view
            return View(model);
            
        }
        [HttpPost]
        public IActionResult Edit(Shipment model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            //pull Shipment from list
            Shipment shipment = _shipments.SingleOrDefault(s =>s.Id == model.Id);
            //check if shipment is valid
            if (shipment == null) 
            {
                return NotFound();
            }

            //update new shiment values
            //shipper
            shipment.Shipper.BusinessName = model.Shipper.BusinessName;
            shipment.Shipper.Street = model.Shipper.Street;
            shipment.Shipper.City = model.Shipper.City;
            shipment.Shipper.State = model.Shipper.State;
            shipment.Shipper.Zip = model.Shipper.Zip;
            shipment.Shipper.Unit = model.Shipper.Unit;
            shipment.Shipper.Contacts = model.Shipper.Contacts;
            shipment.Shipper.PointNotes = model.Shipper.PointNotes;
            //consigneee
            shipment.Consignee.BusinessName = model.Consignee.BusinessName;
            shipment.Consignee.Street = model.Consignee.Street;
            shipment.Consignee.City = model.Consignee.City;
            shipment.Consignee.State = model.Consignee.State;
            shipment.Consignee.Zip = model.Consignee.Zip;
            shipment.Consignee.Unit = model.Consignee.Unit;
            shipment.Consignee.Contacts = model.Consignee.Contacts;
            shipment.Consignee.PointNotes = model.Consignee.PointNotes;
            //shipment
            shipment.TrackingNumber = model.TrackingNumber;
            shipment.Status = model.Status;
            shipment.Carrier = model.Carrier;
            shipment.ShipmentNotes = model.ShipmentNotes; //make sense? 
            shipment.Cost = model.Cost;
            shipment.QuotedAmount = model.QuotedAmount;
            shipment.Pieces = model.Pieces;
            shipment.Weight = model.Weight;
            shipment.Description = model.Description;

            //save changes

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            //validate id
            if (id <= 0) 
            {
                return NotFound();
            }
            //pull shipment from list
            Shipment model = _shipments.SingleOrDefault(s =>s.Id ==id);
            //validate model
            if (model == null) 
            {
                return NotFound();
            }

            //serve up view to user
            return View(model);
            
        }
        [HttpPost]
        public IActionResult Delete(Shipment model) 
        {
         
            //pull shipment from list
            Shipment shipment = _shipments.SingleOrDefault(s => s.Id == model.Id);
            if (shipment == null) 
            {
                return NotFound();
            }
            //update shipment delete property
            shipment.Delete = true;

            return RedirectToAction("Index");
        }
    }
}
