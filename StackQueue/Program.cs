namespace StackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            // [,{,( 에서 스택에 추가 ),},]를 받고 괄호가 완성될때 스택에서 제거
            BracketTester tester = new BracketTester();
            tester.TestBracket("[[]]({}[])");
        }
    }
    public class BracketTester
    {
        Stack<char> brackets;
        public BracketTester()
        {
            brackets = new Stack<char>(10);
        }
        public void TestBracket(string bracketStr)
        {
            //string bracketStr = Console.ReadLine();
            bracketStack(bracketStr);
            if (brackets.Count == 0) 
                Console.WriteLine($"{bracketStr}: 완성"); // 스택을 모두 비웠을땐 완성
            else
                Console.WriteLine($"{bracketStr}: 미완성"); // 남아있으면 미완성
        }
        private void bracketStack(string bracketStr)
        {
            for (int i = 0; i < bracketStr.Length; i++)
            {
                // 각종 괄호일때만 가져옴
                if ((bracketStr[i] == '[') || (bracketStr[i] == '{') || (bracketStr[i] == '(')||(bracketStr[i] == ')') || (bracketStr[i] == '}') || (bracketStr[i] == ']'))
                {
                    // 스택에 뭔가 있을때, 그리고 전 스택과 현재 문자의 괄호가 서로 짝일 때 전 스택 뺌
                    if (brackets.Count!=0 && brackets.Peek() == '[' && bracketStr[i] == ']' )
                        brackets.Pop();
                    else if (brackets.Count != 0 && brackets.Peek() == '{' && bracketStr[i] == '}')
                        brackets.Pop();
                    else if (brackets.Count != 0 && brackets.Peek() == '(' && bracketStr[i] == ')')
                        brackets.Pop();
                    else
                        // 아니면 스택에 추가
                        brackets.Push(bracketStr[i]);
                }
            }
        }
    }


}
