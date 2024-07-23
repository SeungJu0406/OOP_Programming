using HearthstoneHero;
using Boss;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero[] heroes =
            {
                new Jaina(12),
                new Garroshi(15),
                new Anduin(99)
            };
            foreach (Hero hero in heroes) 
            {
                hero.HeroInfo();
                hero.SpeakScript();
            }

            RaidBoss[] bosses =
            {
                new Marrowgar(),
                new Sindragosa(),
                new RichKing()
            };
            foreach(RaidBoss boss in bosses)
            {
                boss.BossInfo();
                boss.GetReward();
            }
        }
    }
}
