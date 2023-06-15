using Microsoft.AspNetCore.Mvc;

namespace TailorPageAndFashionLife.Controllers
{
    public class TailorController : Controller
    {
        // GET: /Tailor/Index
        public IActionResult Index()
        {
            // Logic to retrieve tailor information from the model
            var tailorName = "MarkTessy's Tailor Shop";
            var address = "12 Tower Arc Main St";
            var phoneNumber = "0805526-1234";

            // Pass tailor data to the view
            ViewBag.TailorName = tailorName;
            ViewBag.Address = address;
            ViewBag.PhoneNumber = phoneNumber;

            return View();
        }

        // GET: /Tailor/Orders
        public ActionResult Orders()
        {
            // Logic to retrieve orders from the model

            // Prepare and pass order data to the view

            return View();
        }

        // POST: /Tailor/SaveOrder
        [HttpPost]
        public ActionResult SaveOrder(OrderModel order)
        {
            // Logic to save the order to the model

            // Redirect to a success page or perform other actions

            return RedirectToAction("Index");
        }

        // GET: /Tailor/Measurements
        public ActionResult Measurements()
        {
            // Logic to retrieve measurements from the model

            // Prepare and pass measurement data to the view

            return View();
        }

        // POST: /Tailor/SaveMeasurement
        [HttpPost]
        public ActionResult SaveMeasurement(MeasurementModel measurement)
        {
            // Logic to save the measurement to the model

            // Redirect to a success page or perform other actions

            return RedirectToAction("Index");
        }

        // Add more actions and methods as needed

    }
}
//{
//    [Route("[Controller]")]
//    [ApiController]
//    public class CarDealershipController : ControllerBase
//    {
//        public CarDealershipController()
//        {
//        }

//        [HttpPost]
//        [Route("AddCar")]
//        public ActionResult AddCar([FromBody] CarDto c)
//        {
//            Car newcar = new Car(c.Make, c.Color, c.Year.ToString(), c.PlateNumber);
//            CarDealership.AddCar(newcar);
//            return Ok();
//        }

//        [HttpGet]
//        [Route("GetAllCars")]
//        public ActionResult GetAllCars()
//        {
//            var cars = CarDealership.GetAllCars();
//            return Ok(cars);
//        }

//        [HttpGet]
//        [Route("FindCarByPlateNumber")]
//        public ActionResult FindCarByPlateNumber(string plateNumber)
//        {
//            var car = CarDealership.GetCarByPlateNumber(plateNumber);
//            if (car == null)
//            {
//                return NotFound();
//            }

//            return Ok(car);
//        }

//        [HttpGet]
//        [Route("SeedDealership")]
//        public ActionResult SeedDealership()
//        {
//            var fleet = CarDealership.SeedFleet();
//            return Ok(fleet);
//        }
//    }
//}qa