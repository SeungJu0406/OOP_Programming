using TrainerSystem;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer HanJiU = new Trainer();
            HanJiU.GetPokeMon(1, MobType.Grass, "이상해씨");
            HanJiU.GetPokeMon(2, MobType.Water, "꼬부기");
            HanJiU.GetPokeMon(3, MobType.Electric, "라이츄");
            HanJiU.GetPokeMon(5, MobType.Fire, "파이리");
            HanJiU.GetPokeMon(40, MobType.Fire, "리자몽");
            HanJiU.GetPokeMon(5, MobType.Fire, "파이리");
            foreach (Monster monster in HanJiU.monsters)
            {
                Console.WriteLine($"{monster.level}레벨   {monster.name}  타입: {monster.type}");
            }
        }
    }
}
