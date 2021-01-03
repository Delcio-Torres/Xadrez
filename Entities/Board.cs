using System.Collections.Generic;
using System.Windows.Forms;

namespace Xadrez.Entities {
   class Board: GroupBox {
      private static int BOARD_SIZE = Position.CELL_SIZE * 8;
      public List<List<Cell>> board;

      public Board() {
         this.Size = new System.Drawing.Size(BOARD_SIZE, BOARD_SIZE);
         this.Location = new System.Drawing.Point(0, 0);

         board = new List<List<Cell>>(8);
         for (int rowNumber = 0; rowNumber < 8; rowNumber++) {

            var row = new List<Cell>(8);
            for (int col = 0; col < 8; col++) {
               var cell = new Cell(new Position(col, rowNumber));
               this.Controls.Add(cell);
               row.Add(cell);
            }

            board.Add(row);
         }
      }
   }
}
