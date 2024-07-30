namespace QueueAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            ScheduleCalc scheduleCalc = new ScheduleCalc();
            scheduleCalc.CreateSchedule([17,20,30]);

        }
    }
    public class ScheduleCalc
    {
        Queue<int> workload;
        Queue<int> schedule;
        public ScheduleCalc()
        {
            workload = new Queue<int>();
            schedule = new Queue<int>();
        }
        public void CreateSchedule(List<int> work)
        {
            foreach (int i in work)
            {
                Console.Write($"[{i}]\t");
                workload.Enqueue(i); // 리스트를 큐로 변환               
            }
            Console.WriteLine();
            int temp = 0;
            int todayWork = 0;
            int nowWork = 0;
            int dayCount = 1;
            while (true)
            {
                if (temp == 0 && nowWork == 0) // 일을 다끝내면 새로운 일감 가져옴
                {
                    temp = workload.Peek();
                }

                if (temp > 8) // 일이 8시간 초과일시 8시간만 가져오고 나머지는 저장
                {
                    temp -= 8;
                    todayWork += 8;
                    nowWork += 8;
                }
                else // 8시간 미만일시 나머지 일을 가져오고 일을 마침
                {
                    todayWork += temp;
                    nowWork += temp;
                    temp = 0;
                }

                if (nowWork == workload.Peek()) // 현재 작업량이, 이번 일감 분량과 일치시, 해당 일감 제거
                {
                    if (todayWork <= 8)
                    {
                        workload.Dequeue();
                        schedule.Enqueue(dayCount); // 스케줄표에 일차 작성
                        nowWork = 0;
                    }
                }

                if (todayWork >= 8) // 오늘 일한 양이 8시간 초과일 시 하루 추가
                {
                    dayCount++;
                    todayWork -= 8;
                }

                if (work.Count == schedule.Count)
                    break;
            }
            foreach (int i in schedule)
            {
                Console.Write($"[{i}]\t");
            }
        }
    }
}
