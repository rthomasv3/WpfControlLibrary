namespace CodeCompendium.WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the grid control template.
   /// </summary>
   public sealed class GridViewModel : ControlViewModel
   {
      #region Fields

      private bool _showGridLines;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="GridViewModel"/> class.
      /// </summary>
      public GridViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets show grid lines.
      /// </summary>
      public bool ShowGridLines
      {
         get { return _showGridLines; }
         set { Set(ref _showGridLines, value); }
      }

      #endregion
   }
}
