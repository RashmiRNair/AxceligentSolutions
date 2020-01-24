namespace ConstructionGame
{
    public interface IHouseBuilder
    {
        IHouseBuilder AddKitchen();
        IHouseBuilder AddBedroom(string type);
        IHouseBuilder AddBalcony();
        IHouseBuilder Build();
        string Describe();
    }
}