class DroneFactory
{
    IUnitFactoryInterface IUnit;
    virtual public IUnitFactoryInterface CreateUnit()
    {
        return IUnit;
    }
}

class LightDronefactory : DroneFactory
{
    public override Drone CreateUnit()
    {
        return new Drone();
    }
}
class MediumDronefactory : DroneFactory
{
   
    public override Drone CreateUnit()
    {
        return new Drone();
    }
}
class HeavyDronefactory : DroneFactory
{
    
    public override Drone CreateUnit()
    {
        return new Drone();
    }
}