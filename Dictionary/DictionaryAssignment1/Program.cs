namespace DictionaryAssignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MonsterData.SaveData();
            Monster mentis = new Monster("사마귀");
            Console.WriteLine($"{mentis.name}, {mentis.hp}");
        }
    }
    public static class MonsterData
    {
        public static Dictionary<string, Monster> monsterData;        
        public static void SaveData() 
        {
            monsterData = new Dictionary<string, Monster>();
            monsterData.Add("달팽이", new Monster("달팽이", 5));
            monsterData.Add("사마귀", new Monster("사마귀", 10));
            monsterData.Add("말벌", new Monster("말벌", 8));
            monsterData.Add("사슴벌레", new Monster("사슴벌레", 30));
            monsterData.Add("장수풍뎅이", new Monster("장수풍뎅이", 35));
        }
    }
    public class Monster 
    {
        public string name;
        public int hp;
        public Monster(string name)
        {
            Monster data = MonsterData.monsterData[name];
            this.name = data.name;
            this.hp = data.hp;
        }
        public Monster(string name , int hp)
        {
            this.name = name;
            this.hp = hp;
        }
    }
}
