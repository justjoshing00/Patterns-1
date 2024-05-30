//I cant actually use the factory pattern to solve the problem I have, because in the game my Units also have unit-specific behavior and I can't use
//the IUnit interface to call those behaviors.

class UnitFactory
{
    IUnitFactoryInterface IUnit;
    virtual public IUnitFactoryInterface CreateUnit()
    {
        return IUnit;
    }
}
class Mechfactory : UnitFactory
{
    private Mech mech;
    public override Mech CreateUnit()
    {
        return mech = new();
    }
}
class Dronefactory : UnitFactory
{
    private Drone drone;
    public override Drone CreateUnit()
    {
        return drone = new();
    }
}
class Tankfactory : UnitFactory
{
    private Tank tank;
    public override Tank CreateUnit()
    {
        return tank = new();
    }
}
class Soldierfactory : UnitFactory
{
    private Soldier soldier;
    public override Soldier CreateUnit()
    {
        return soldier = new();
    }
}
