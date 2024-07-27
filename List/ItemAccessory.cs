namespace ListAssignment
{

    /// <summary>
    /// 악세서리
    /// </summary>
    public class Accessory : Item
    {
        public Accessory()
        {

        }
    }
    /// <summary>
    /// 반지
    /// </summary>
    public class Ring : Accessory
    {
        public Ring()
        {
            this.name = "반지";
            description = "손가락에 끼는겁니다";
        }
    }
    /// <summary>
    /// 목걸이
    /// </summary>
    public class Necklace : Accessory
    {
        public Necklace()
        {
            this.name = "목걸이";
            description = "목에 거는겁니다";
        }
    }
    /// <summary>
    /// 부적
    /// </summary>
    public class Charm : Accessory
    {
        public Charm()
        {
            this.name = "부적";
            description = "그냥 종이입니다";
        }
    }
    /// <summary>
    /// 브로치
    /// </summary>
    public class Brooch : Accessory
    {
        public Brooch()
        {
            this.name = "브로치";
            description = "반짝거립니다";
        }
    }
}