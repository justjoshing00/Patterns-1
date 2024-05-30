class SoldierFactory
{
    IUnitFactoryInterface IUnit;
    virtual public IUnitFactoryInterface CreateUnit()
    {
        return IUnit;
    }
}

class LightSoldierfactory : SoldierFactory
{
    
    public override Soldier CreateUnit()
    {
        return new Soldier();
    }
}
class MediumSoldierfactory : SoldierFactory
{
    
    public override Soldier CreateUnit()
    {
        return new Soldier();
    }
}
class HeavySoldierfactory : SoldierFactory
{
    
    public override Soldier CreateUnit()
    {
        return new Soldier();
    }
}