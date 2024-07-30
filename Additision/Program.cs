using System.Runtime.CompilerServices;

namespace Additision
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("아이디를 입력하세요 : ");
            string id = Console.ReadLine();

            if (id.IsAllowedID())
            {
                Console.WriteLine("ID가 유효합니다.");
            }
            else
            {
                Console.WriteLine("ID에 허용되지 않는 특수문자가 있습니다.");
            }
        }
        public static bool IsAllowedID(this string id) 
        {
            foreach(char c in id)
            {
                // 아스키코드로 변환해서 숫자랑 알파벳에 해당되지 않으면 반환값 false
                //if (!((48 <= (int)c && (int)c <= 57) || (65 <= (int)c && (int)c <= 90) || (97 <= (int)c && (int)c <= 122))) 
                if(!(char.IsLetterOrDigit(c))) // char.IsLetterOrDigit(c): c안의 값이 문자값 혹은 숫자값이면 true
                    return false;
            }
            return true;
        }
    }
}
