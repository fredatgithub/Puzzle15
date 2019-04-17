using System;
using System.Windows.Forms;

namespace Puzzle15
{
  static class Program
  {
    /// <summary>
    /// Point d'entrée principal de l'application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      FifteenPuzzle puzzle = new FifteenPuzzle();
      Form form = puzzle.BuildForm();
      Application.Run(form);
    }
  }
}
