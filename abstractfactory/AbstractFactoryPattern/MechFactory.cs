class MechFactory
{
    IUnitFactoryInterface IUnit;
    virtual public IUnitFactoryInterface CreateUnit()
    {
        return IUnit;
    }
}

class LightMechfactory : MechFactory
{
    
    public override Mech CreateUnit()
    {
        return new Mech();
    }
}
class MediumMechfactory : MechFactory
{
    
    public override Mech CreateUnit()
    {
        return new Mech();
    }
}
class HeavyMechfactory : MechFactory
{
    
    public override Mech CreateUnit()
    {
        return new Mech();
    }
}