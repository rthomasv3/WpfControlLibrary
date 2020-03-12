namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the text box control template.
   /// </summary>
   public sealed class TextBoxViewModel : ControlViewModel
   {
      #region Fields

      private string _text = "Text from binding.";
      private string _propChangeText = "Text from binding that updates as you type.";
      private int _number;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="TextBoxViewModel"/> class.
      /// </summary>
      public TextBoxViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets text.
      /// </summary>
      public string Text
      {
         get { return _text; }
         set { Set(ref _text, value); }
      }

      /// <summary>
      /// Gets or sets prop change text.
      /// </summary>
      public string PropChangeText
      {
         get { return _propChangeText; }
         set { Set(ref _propChangeText, value); }
      }

      /// <summary>
      /// Gets or sets a number.
      /// </summary>
      public int Number
      {
         get { return _number; }
         set { Set(ref _number, value); }
      }

      #endregion
   }
}
