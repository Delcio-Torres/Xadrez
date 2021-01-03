using System.Drawing;

namespace Xadrez.Entities {
   class Position {
      public static int CELL_SIZE = 56;

      public Point Location { get; set; }
      public int X { get; set; }
      public int Y { get; set; }

      public Position(int x, int y) {
         Location = new Point(x * CELL_SIZE, (7 - y) * CELL_SIZE);
         Y = y;
         X = x;
      }

      public bool isEven() {
         return (X + Y) % 2 == 0;
      }
   }
}
