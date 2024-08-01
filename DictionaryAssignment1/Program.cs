namespace DictionaryAssignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MonsterData monsterData = new MonsterData();
            Monster mantis = new Monster(monsterData, "사마귀");
            Console.WriteLine($"{mantis.name}: {mantis.hp}");

        }
    }
    public class MonsterData
    {
        public Dictionary<string, MonsterData> monsterData;
        public string name {  get; set; }
        public int hp { get; set; }
        
        public MonsterData()
        {
            monsterData = new Dictionary<string, MonsterData>();
            SaveData();
        }
        private MonsterData(string name, int hp) 
        {
            this.name = name;
            this.hp = hp;
        }
        private void SaveData() 
        {
            monsterData.Add("달팽이", new MonsterData("달팽이",5));
            monsterData.Add("사마귀", new MonsterData("사마귀", 10));
            monsterData.Add("말벌", new MonsterData("말벌", 8));
            monsterData.Add("사슴벌레", new MonsterData("사슴벌레", 30));
            monsterData.Add("장수풍뎅이", new MonsterData("장수풍뎅이", 35));
        }
    }
    public class Monster 
    {
        public string name;
        public int hp; 
        public Monster(MonsterData data, string key)
        {
            this.name = data.monsterData[key].name;
            this.hp = data.monsterData[key].hp;
        }
    }
}
