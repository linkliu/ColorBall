namespace ColorBall.Data
{
    // 双色球颜色
    public enum BallColor:int
    {
        RED = 1,
        BLUE = 2
    }


    public class Ball
    {
        private BallColor color;
        private int number;
        public Ball(int number, BallColor color)
        {
            this.Color = color;
            this.Number = number;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public BallColor Color
        {
            get {return color; }
            set {color = value; }
        }
    }
}
