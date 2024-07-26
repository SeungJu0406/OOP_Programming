namespace ListAssignment
{

    public class Accessory : Item
    {

    }

    public class Ring : Accessory
    {
        public Ring()
        {
            this.name = "반지";
            description = "손가락에 끼는겁니다";
        }
    }
    public class Necklace : Accessory
    {
        public Necklace()
        {
            this.name = "목걸이";
            description = "목에 거는겁니다";
        }
    }
    public class Charm : Accessory
    {
        public Charm()
        {
            this.name = "부적";
            description = "그냥 종이입니다";
        }

        public class Brooch : Accessory
        {
            public Brooch()
            {
                this.name = "브로치";
                description = "반짝거립니다";
            }
        }
    }
}
