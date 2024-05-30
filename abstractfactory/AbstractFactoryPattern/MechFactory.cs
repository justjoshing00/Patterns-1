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
    private Mech LightMech;
    public override Mech CreateUnit()
    {
        return LightMech = new();
    }
}
class MediumMechfactory : MechFactory
{
    private Mech MediumMech;
    public override Mech CreateUnit()
    {
        return MediumMech = new();
    }
}
class HeavyMechfactory : MechFactory
{
    private Mech HeavyMech;
    public override Mech CreateUnit()
    {
        return HeavyMech = new();
    }
}