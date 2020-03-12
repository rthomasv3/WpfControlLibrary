using System.Collections.Generic;

namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the wrap panel control template.
   /// </summary>
   public sealed class WrapPanelViewModel : ControlViewModel
   {
      #region Fields

      private readonly List<string> _buttons;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="WrapPanelViewModel"/> class.
      /// </summary>
      public WrapPanelViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _buttons = new List<string>();
         for (int i = 0; i < 7; ++i)
         {
            _buttons.Add($"Button {i + 1}");
         }
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets a list of text for buttons.
      /// </summary>
      public IEnumerable<string> Buttons
      {
         get { return _buttons.AsReadOnly(); }
      }

      #endregion
   }
}
