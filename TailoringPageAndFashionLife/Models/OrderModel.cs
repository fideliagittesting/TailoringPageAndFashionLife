namespace TailoringPageAndFashionLife.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string GarmentType { get; set; }
        public List<MeasurementModel> Measurements { get; set; }
    }
}
