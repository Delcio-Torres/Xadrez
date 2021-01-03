using System.Drawing;
using System.Windows.Forms;

namespace Xadrez.Entities {
   abstract class Piece : PictureBox {

      public Cell FirstCell { get; set; }
      public Cell Cell { get; set; }
      public Color Color { get; set; }

      public Piece(Cell firstCell, Color color) {
         FirstCell = firstCell;
         Color = color;

         this.Location = firstCell.Location;
         this.Width = Position.CELL_SIZE;
         this.Height = Position.CELL_SIZE;
         this.SizeMode = PictureBoxSizeMode.StretchImage;
         this.Image = setImage();
      }

      public void resetPosition() {
         Cell = FirstCell;
      }

      protected abstract Image setImage();
   }
}
