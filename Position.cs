namespace Tetris
{
    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; } 

        public Position(int x, int y)
        {
            Row = x;
            Column = y;
        }
    }
}
