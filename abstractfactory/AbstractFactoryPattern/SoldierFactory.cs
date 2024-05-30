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
    private Soldier LightSoldier;
    public override Soldier CreateUnit()
    {
        return LightSoldier = new();
    }
}
class MediumSoldierfactory : SoldierFactory
{
    private Soldier MediumSoldier;
    public override Soldier CreateUnit()
    {
        return MediumSoldier = new();
    }
}
class HeavySoldierfactory : SoldierFactory
{
    private Soldier HeavySoldier;
    public override Soldier CreateUnit()
    {
        return HeavySoldier = new();
    }
}