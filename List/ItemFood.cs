namespace ListAssignment
{
    /// <summary>
    /// 음식
    /// </summary>
    public class Food : Item
    {
        public Food()
        {

        }
    }
    /// <summary>
    /// 치킨
    /// </summary>
    public class Chicken : Food
    {
        public Chicken()
        {
            this.name = "치킨";
            description = "맛있습니다";
        }
    }
    /// <summary>
    /// 스테이크
    /// </summary>
    public class Stake : Food
    {
        public Stake()
        {
            this.name = "스테이크";
            description = "맛있습니다";
        }
    }
    public class Fish : Food
    {
        public Fish()
        {
            this.name = "생선구이";
            description = "탔습니다";
        }
    }
    /// <summary>
    /// 샐러드
    /// </summary>
    public class Salad : Food
    {
        public Salad()
        {
            this.name = "샐러드";
            description = "배가 조금 찹니다";
        }
    }
}
