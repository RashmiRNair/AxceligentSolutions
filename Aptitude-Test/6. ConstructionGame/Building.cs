using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructionGame
{
    public class Building : IHouseBuilder
    {
        private List<INewHouseSpecification> houseSpecifications = new List<INewHouseSpecification>();
        private StringBuilder houseDescription;

        public Building()
        {
            houseSpecifications = new List<INewHouseSpecification>();
            houseDescription = new StringBuilder();
        }

        public IHouseBuilder AddBalcony()
        {
            houseSpecifications.Add(new Balcony());
            return this;
        }

        public IHouseBuilder AddBedroom(string type)
        {
            houseSpecifications.Add(new Bedroom() { Type = type });
            return this;
        }

        public IHouseBuilder AddKitchen()
        {
            houseSpecifications.Add(new Kitchen());
            return this;
        }

        public IHouseBuilder Build()
        {
            houseDescription.Clear();
            houseDescription.AppendJoin(", ", from item in houseSpecifications select item.GetSpecification());
            return this;
        }

        public string Describe()
        {
            return houseDescription.ToString();
        }
    }
}