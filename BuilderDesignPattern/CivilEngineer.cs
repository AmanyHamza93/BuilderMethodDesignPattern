namespace BuilderDesignPattern
{
    public class CivilEngineer
    {
        private IHouseBuilder houseBuilder;

        public CivilEngineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public House GetHouse()
        {
            return houseBuilder.GetHouse();
        }

        public void ConstructHouse()
        {
            houseBuilder.BuildBasement();
            houseBuilder.BuildStructure();
            houseBuilder.BuildRoof();
            houseBuilder.BuildInterior();
        }
    }
}
