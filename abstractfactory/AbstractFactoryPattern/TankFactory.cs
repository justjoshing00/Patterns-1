class TankFactory
{
    IUnitFactoryInterface IUnit;
    virtual public IUnitFactoryInterface CreateUnit()
    {
        return IUnit;
    }
}

class LightTankfactory : TankFactory
{
    private Tank LightTank;
    public override Tank CreateUnit()
    {
        return LightTank = new();
    }
}class MediumTankfactory : TankFactory
{
    private Tank MediumTank;
    public override Tank CreateUnit()
    {
        return MediumTank = new();
    }
}class HeavyTankfactory : TankFactory
{
    private Tank HeavyTank;
    public override Tank CreateUnit()
    {
        return HeavyTank = new();
    }
}
