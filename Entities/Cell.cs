using System.Windows.Forms;
using System.Drawing;
using Xadrez.Properties;
using Xadrez.Entities.Pieces;

namespace Xadrez.Entities {
   class Cell : PictureBox {
      private static Image BLACK = Resources.square_brown;
      private static Image WHITE = Resources.square_light_brown;

      public Piece Piece { get; set; }
      public Position Position { get; set; }
      public Board Board { get; set; }

      public Cell(Board board, Position position) {
         this.Image = position.isEven() ? BLACK : WHITE;
         this.Location = position.Location;
         this.Width = Position.CELL_SIZE;
         this.Height = Position.CELL_SIZE;
         this.SizeMode = PictureBoxSizeMode.StretchImage;
         Position = position;
         Board = board;

         reset();
      }

      public void reset() {
         if (Piece != null) {
            Board.Controls.Remove(Piece);
            Piece = null;
         }

         if (Position.Y == 0) {
            if (Position.X == 0 || Position.X == 7) {
               Piece = new Rook(this, Color.WHITE);
            }
         }

         if (Position.Y == 1) {
            Piece = new Pawn(this, Color.WHITE);
         }

         if (Position.Y == 6) {
            Piece = new Pawn(this, Color.BLACK);
         }

         if (Position.Y == 7) {
            if (Position.X == 0 || Position.X == 7) {
               Piece = new Rook(this, Color.BLACK);
            }
         }

         if (Piece != null) {
            Board.Controls.Add(Piece);
         }
      }
   }
}
