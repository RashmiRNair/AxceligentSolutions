namespace ConstructionGame
{
    public class Balcony : INewHouseSpecification
    {
        public string Type { private get; set; }
        public Balcony()
        {
            Type = "balcony";
        }        
        public string GetSpecification()
        {
            return Type;
        }
    }
}