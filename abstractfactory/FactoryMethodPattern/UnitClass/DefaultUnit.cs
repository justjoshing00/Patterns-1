namespace FactoryMethodPattern
{ 
    class DefaultUnit: Unit
    {
        public DefaultUnit()
        {
            Console.WriteLine("failed to create unit");
        }
        public override void Move()
        {

        }
        public override void Action()
        {

        }

    }
}