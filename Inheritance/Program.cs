using HearthstoneHero;
using Boss;
using HearthstoneCard;

namespace Inheritance
{
    // 
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
                Console.WriteLine();
            }
            Console.WriteLine("=========================================");
            RaidBoss[] bosses =
            {
                new Marrowgar(),
                new Sindragosa(),
                new RichKing()
            };
            foreach (RaidBoss boss in bosses)
            {
                boss.BossInfo();
                boss.GetReward();
                Console.WriteLine();
            }
            Console.WriteLine("=========================================");
            Card[] cards =
            {
                new Shieldbearer(),
                new AzureDrake(),
                new MoltenGiant(),
                new LeeroyJenkins()
            };
            foreach (Card card in cards)
            {
                card.CardInfo();
                card.PrintEffect();
                card.PrintGoldenEffect();
                Console.WriteLine();
            }
        }
    }
}
