namespace AbstractFactoryPattern
{
    interface AbstractFactory
    {
        ITank CreateTank();
        ISoldier CreateSoldier();
        IDrone CreateDrone();
        IMech CreateMech();
    }
}