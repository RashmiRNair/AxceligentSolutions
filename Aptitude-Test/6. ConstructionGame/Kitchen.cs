using System.Text;

namespace ConstructionGame
{
    public class Kitchen : INewHouseSpecification
    {
        public string Type { private get; set; }
        public Kitchen()
        {
            Type = "kitchen";
        }      
        public string GetSpecification()
        {
            return Type;
        }
    }
}