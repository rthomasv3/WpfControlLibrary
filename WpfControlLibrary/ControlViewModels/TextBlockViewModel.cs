namespace CodeCompendium.WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the text block control template.
   /// </summary>
   public sealed class TextBlockViewModel : ControlViewModel
   {
      #region Fields

      private readonly string _text = "Text block with text from binding.";

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="TextBlockViewModel"/> class.
      /// </summary>
      public TextBlockViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets text.
      /// </summary>
      public string Text
      {
         get { return _text; }
      }

      #endregion
   }
}
