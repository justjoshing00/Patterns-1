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
    private Drone LightDrone;
    public override Drone CreateUnit()
    {
        return LightDrone = new();
    }
}
class MediumDronefactory : DroneFactory
{
    private Drone MediumDrone;
    public override Drone CreateUnit()
    {
        return MediumDrone = new();
    }
}
class HeavyDronefactory : DroneFactory
{
    private Drone HeavyDrone;
    public override Drone CreateUnit()
    {
        return HeavyDrone = new();
    }
}