namespace ECRAdmin.ProductsModule.Models
{
    public class GeneralSpecifications
    {
        public decimal Weight { get; set; }
        public ThreeDDimensions Dimensions { get; set; }
        public string ImagePath { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }

    public class ThreeDDimensions
    {
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
    }
}
