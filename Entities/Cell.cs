using System.Windows.Forms;
using System.Drawing;
using Xadrez.Properties;

namespace Xadrez.Entities {
   class Cell : PictureBox {
      private static Image BLACK = Resources.square_black;
      private static Image WHITE = Resources.square_white;

      public Position Position { get; set; }

      public Cell(Position position) {
         this.Image = position.isEven() ? BLACK : WHITE;
         this.Location = position.Location;
         this.Width = Position.CELL_SIZE;
         this.Height = Position.CELL_SIZE;
         this.SizeMode = PictureBoxSizeMode.StretchImage;
      }
   }
}
