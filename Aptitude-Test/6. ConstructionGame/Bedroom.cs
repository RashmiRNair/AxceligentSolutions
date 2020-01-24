using System.Text;

namespace ConstructionGame
{
    public class Bedroom : INewHouseSpecification
    {
        public string Type { private get; set; }
        public Bedroom() {
            Type = "bedroom";
        }      
        public string GetSpecification()
        {
            return $"{Type} room";
        }
    }
}