namespace Boss
{
    public abstract class RaidBoss
    {
        protected int hp;
        protected int order;
        protected Name name;
        protected enum Name { Marrowgar , Sindragosa , RichKing}
        public abstract void GetReward();
        public void BossInfo()
        {
            Console.WriteLine($"{order}번 보스: {name}  체력:{hp}");
        }
    }
    public class Sindragosa : RaidBoss 
    {
        public Sindragosa()
        {
            hp = 90000;
            order = 11;
            name = Name.Sindragosa;
        }
        public override void GetReward()
        {
            Console.WriteLine("푸른용군단의 잃어버린 파비스");
        }
    }
    public class RichKing : RaidBoss
    {
        public RichKing()
        {
            hp = 100000;
            order = 12;
            name = Name.RichKing;
        }
        public override void GetReward()
        {
            Console.WriteLine("테레나스 2세의 왕실 홀");
        }
    }
    public class Marrowgar : RaidBoss
    {
        public Marrowgar()
        {
            hp = 10000;
            order = 1;
            name = Name.Marrowgar;
        }
        public override void GetReward()
        {
            Console.WriteLine("매로우가르의 그러모은 목걸이");
        }
    }
}
