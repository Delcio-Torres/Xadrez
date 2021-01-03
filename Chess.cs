using System;
using System.Drawing;
using System.Windows.Forms;
using Xadrez.Properties;

namespace Xadrez {
   public partial class Chess : Form {
      public Chess() {
         InitializeComponent();

         var boardX = Math.Abs(Width - board.Size.Width) / 2;
         board.Location = new System.Drawing.Point(boardX, 0);
         Icon = Resources.icon;
      }
   }
}
