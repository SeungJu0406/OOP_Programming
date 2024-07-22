namespace Constructor
{
    internal class Program
    {
        class Trainer
        {
            public string name;
            public Monster[] monsters;
            public Trainer(string name)
            {
                this.name = name;
                this.monsters = new Monster[6];
            }
        }
        class Monster
        {
            public string name;
            public int hp;
            public Monster(string name, int hp) 
            { 
                this.name = name;
                this.hp = hp;
            }
        }
        static void Main(string[] args)
        {
            Trainer hanJiU = new Trainer("한지우");
            hanJiU.monsters[0] = new Monster("피카츄", 35);
            hanJiU.monsters[1] = new Monster("망나뇽", 91);
            hanJiU.monsters[2] = new Monster("루카리오", 70);
            hanJiU.monsters[3] = new Monster("창파나이트", 62);
            hanJiU.monsters[4] = new Monster("팬텀", 60);
            hanJiU.monsters[5] = new Monster("어래곤", 90);

            Console.WriteLine($"트레이너: {hanJiU.name}");
            for (int i = 0; i < hanJiU.monsters.Length; i++)
            {
                Console.WriteLine($"{i}. {hanJiU.monsters[i].name,-5}   {hanJiU.monsters[i].hp}");
            }
        }
    }
}
