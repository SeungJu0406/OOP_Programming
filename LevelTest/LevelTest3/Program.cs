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
            int index = 0;
            for(int i =0; i < list.Count; i++)
            {
                // answer에 저장한 데이터가 없을때 에러남을 방지
                if (answer.Count == 0 || answer[index - 1] != list[i])
                {
                    answer.Add(list[i]);
                    index++;
                    continue;
                }
            }
            return answer;
        }
    }
}
