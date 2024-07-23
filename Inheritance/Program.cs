using HearthstoneHero;
using Boss;
using HearthstoneCard;

namespace Inheritance
{
    /* 추상클래스: 미완성된 클래스, 자식 클래스에서 공유할 수 있도록 추상 클래스(부모 클래스)의 공통적인 정의를 제공하는 것
     *      특징 1. new 연산자를 이용하여 인스턴스 생성 불가
     *      특징 2. 오직 자식 클래스에서 상속을 통해서만 구현 가능
     *      특징 3. 추상 메소드와 추상 프로퍼티를 가질 수 있음
     *      추상 메서드 특징 : 1. 암시적으로 가상 메서드
     *                        2. 선언은 오직 추상 클래스에서만 가능
     *                        3. 선언할 때 staic or virtual 키워드 사용 불가
     *                        4. 실제 구현을 제공하지 않기 때문에 메서드 본문이 없음
     *                      
     * 오버로딩: 하나의 메서드에 여러가지로 구현하는 것. 같은 메서드의 이름으로 매개변수의 개수 또는 타입을 다르게 정의.
     *      메소드 이름을 새롭게 지을 필요가 없기 때문에 코드의 일관성을 유지해줌
     *      
     * 오버라이딩: 부모클래스에서 물려받은 메서드를 자식클래스에서 재정의 하는 것.
     *          오버라이딩 시 부모클래스 메서드 보다 자식클래스 메서드가 더 우선시 됨
     *          다형성을 구현하기 위하여 오버라이딩 사용
     *              다형성: 객체가 여러가지 형태를 가지는 성질
    */
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
