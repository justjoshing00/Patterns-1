//the problem i have with this is that I dont have different kinds of mechs and different kinds of drones.
//I have mechs that are built differently and drones that are build differently

interface AbstractFactory
{
    ITank CreateTank();
    ISoldier CreateSoldier();
    IDrone CreateDrone();
    IMech CreateMech();
}