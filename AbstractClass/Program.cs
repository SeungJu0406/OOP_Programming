using TrainerSystem;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer HanJiU = new Trainer();
            Console.WriteLine($"{HanJiU.monsters[0].name} {HanJiU.monsters[0].level}");
            HanJiU.monsters[0].BaseAttack();
        }
    }
}
