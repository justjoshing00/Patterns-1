
namespace FactoryMethodPattern
{
    class UnitFactory
    {
        public virtual Unit CreateUnit()
        {
            return new DefaultUnit();
        }
    }
    class Mechfactory:UnitFactory
    {
        public override Mech CreateUnit()
        {
            return new Mech();
        }
    }
    class Tankfactory:UnitFactory
    {
        public override Tank CreateUnit()
        {
            return new Tank();
        }
    }
    class DroneFactory:UnitFactory
    {
        public override Drone CreateUnit()
        {
            return new Drone();
        }
    }
    class SoldierFactory:UnitFactory
    {
        public override Soldier CreateUnit()
        {
            return new Soldier();
        }
    }
}
