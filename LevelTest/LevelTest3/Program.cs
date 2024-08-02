namespace LevelTest3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> answer = Util.Set([1,1,2,2,4,4,5,3,3]);
            foreach (int i in answer) 
            {
                Console.Write($"[{i}] ");
            }
        }
    }
    public static class Util
    {
        public static List<int> Set(List<int> list)
        {
            List<int> answer = new List<int>();
            for(int i =0; i < list.Count; i++)
            {
                if (answer.Count == 0 || answer[answer.Count-1] != list[i])
                {
                    answer.Add(list[i]);
                }
            }
            return answer;
        }
    }
}
