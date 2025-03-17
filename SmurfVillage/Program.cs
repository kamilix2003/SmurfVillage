namespace SmurfVillage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smurf s1 = new Smurf(0xff0000, "Papa smurf", 500, "Village");
            Cat c1 = new Cat(0xeb8f34, "plain", "Azreal", 5, "Gargamels hut");
            Building b1 = new Building(50, 2, "Brick", 20, "Forest");
            NaturalStructure n1 = new NaturalStructure(false, "Water", 1000, "Forest");
        }
    }
}