namespace _06_RectanglePosition
{
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        //public int Bottom => Top - Height;
        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }

        //public int Area => Width* Height;

        //public int Area() 
        //{ 
        //    return Width* Height;
        //}
    }
}
