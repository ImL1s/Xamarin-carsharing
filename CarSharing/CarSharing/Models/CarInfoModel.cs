namespace CarSharing.Models
{
    public class CarInfoModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ProduceYear { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }

        public CarInfoModel()
        {

        }

        public override string ToString()
        {
            return "GG";
            //return string.Format("[CarInfoModel: Brand={0}, Model={1}, ProduceYear={2}, Type={3}, Price={4}]", Brand, Model, ProduceYear, Type, Price);
            //return Brand;
        }
    }
}