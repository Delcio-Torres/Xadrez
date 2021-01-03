using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Properties;

namespace Xadrez.Entities.Pieces {
   class Rook : Piece {
      public Rook(Cell firstCell, Color color) : base(firstCell, color) {

      }

      protected override Image setImage() {
         if (Color == Color.BLACK) {
            return Resources.piece_black_rook;
         }
         return Resources.piece_white_rook;
      }
   }
}
