
namespace FactoryPattern
{
    class UnitFactory
    {

        public Unit CreateUnit(Type type)
        {
            if (type == typeof(Tank))
            {
                return new Tank();
            }
            if (type == typeof(Soldier))
            {
                return new Soldier();
            }
            if (type == typeof(Mech))
            {
                return new Mech();
            }
            if (type == typeof(Drone))
            {
                return new Drone();
            }
            else
            {
                return new DefaultUnit();
            }
        }
    }
}
