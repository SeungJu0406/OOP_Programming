namespace _240722
{
    public class Program
    {
        public class Character
        {
            protected int level;
            protected int hp;
            protected int speed;
            protected int power;
            void MoveForward()
            {
                Console.WriteLine("전진하였습니다");
            }
            void MoveBackUp()
            {
                Console.WriteLine("후진하였습니다");
            }
            void MoveLeft()
            {
                Console.WriteLine("왼쪽으로 꺾었습니다");
            }
            void MoveRight()
            {
                Console.WriteLine("오른쪽으로 꺾었습니다");
            }
            void Attack()
            {
                Console.WriteLine("공격 하였습니다");
            }
            void Gethit()
            {
                Console.WriteLine("피격 당했습니다");
            }
        }
        public class Monster : Character
        {

        }
        public class PlayerCharacter : Character
        {

        }

        static void Main(string[] args)
        {

        }
    }
}
