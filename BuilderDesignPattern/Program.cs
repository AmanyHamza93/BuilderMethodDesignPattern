using BuilderDesignPattern;

IHouseBuilder iglooBuilder = new IglooHouseBuilder();
CivilEngineer engineer = new CivilEngineer(iglooBuilder);

engineer.ConstructHouse();

House house = engineer.GetHouse();

Console.WriteLine($"Builder constructed: {house}");