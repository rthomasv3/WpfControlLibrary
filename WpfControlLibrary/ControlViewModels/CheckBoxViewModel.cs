namespace CodeCompendium.WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the check box control template.
   /// </summary>
   public sealed class CheckBoxViewModel : ControlViewModel
   {
      #region Fields

      private bool _isChecked;
      private string _checkBoxText;
      private bool? _indeterminateChecked;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="CheckBoxViewModel"/> class.
      /// </summary>
      public CheckBoxViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _checkBoxText = "Text and Checked From Binding";
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets is checked.
      /// </summary>
      public bool IsChecked
      {
         get { return _isChecked; }
         set { Set(ref _isChecked, value); }
      }

      /// <summary>
      /// Gets or sets check box text.
      /// </summary>
      public string CheckBoxText
      {
         get { return _checkBoxText; }
      }

      /// <summary>
      /// Gets or sets indeterminate checked.
      /// </summary>
      public bool? IndeterminateChecked
      {
         get { return _indeterminateChecked; }
         set { Set(ref _indeterminateChecked, value); }
      }

      #endregion
   }
}
