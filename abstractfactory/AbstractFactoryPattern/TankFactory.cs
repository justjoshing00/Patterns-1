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
    public override Tank CreateUnit()
    {
        return new Tank();
    }
}class MediumTankfactory : TankFactory
{
    public override Tank CreateUnit()
    {
        return new Tank();
    }
}class HeavyTankfactory : TankFactory
{
    public override Tank CreateUnit()
    {
        return new Tank();
    }
}
