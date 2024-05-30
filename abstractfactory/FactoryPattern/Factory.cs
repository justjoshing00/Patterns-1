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
    
    public override Mech CreateUnit()
    {
        return new Mech();
    }
}
class Dronefactory : UnitFactory
{
    
    public override Drone CreateUnit()
    {
        return new Drone();
    }
}
class Tankfactory : UnitFactory
{
    
    public override Tank CreateUnit()
    {
        return new Tank();
    }
}
class Soldierfactory : UnitFactory
{
    
    public override Soldier CreateUnit()
    {
        return new Soldier();
    }
}
