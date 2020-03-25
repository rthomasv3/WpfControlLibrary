namespace CodeCompendium.WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the radio button control template.
   /// </summary>
   public sealed class RadioButtonViewModel : ControlViewModel
   {
      #region Fields

      private bool _option1Checked;
      private bool _option2Checked;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="RadioButtonViewModel"/> class.
      /// </summary>
      public RadioButtonViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _option2Checked = true;
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets a boolean indicating if option 1 is selected.
      /// </summary>
      public bool Option1Checked
      {
         get { return _option1Checked; }
         set { Set(ref _option1Checked, value); }
      }

      /// <summary>
      /// Gets or sets a boolean indicating if option 2 is selected.
      /// </summary>
      public bool Option2Checked
      {
         get { return _option2Checked; }
         set { Set(ref _option2Checked, value); }
      }

      #endregion
   }
}
