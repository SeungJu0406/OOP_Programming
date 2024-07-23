using TrainerSystem;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer HanJiU = new Trainer();
            HanJiU.GetPokeMon(5, MobType.Fire, "파이리");
            foreach(Monster monster in HanJiU.monsters)
            {
                Console.WriteLine($"{monster.level}레벨   {monster.name}  타입: {monster.type}");
            }
        }
    }
}
