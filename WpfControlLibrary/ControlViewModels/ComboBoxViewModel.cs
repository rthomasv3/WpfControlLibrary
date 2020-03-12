using System.Collections.Generic;
using System.Linq;

namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the combo box control template.
   /// </summary>
   public sealed class ComboBoxViewModel : ControlViewModel
   {
      #region Fields

      private List<string> _stringOptions = new List<string>() { "String Option 1", "String Option 2", "String Option 3" };
      private string _selectedStringOption;

      private List<KeyValuePair<int, string>> _objectOptions = new List<KeyValuePair<int, string>>()
      {
         new KeyValuePair<int, string>(1, "Object Option 1"),
         new KeyValuePair<int, string>(2, "Object Option 2"),
         new KeyValuePair<int, string>(3, "Object Option 3")
      };
      private KeyValuePair<int, string> _selectedObjectOption;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="ComboBoxViewModel"/> class.
      /// </summary>
      public ComboBoxViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _selectedStringOption = _stringOptions.FirstOrDefault();
         _selectedObjectOption = _objectOptions.FirstOrDefault();
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets string options.
      /// </summary>
      public IEnumerable<string> StringOptions
      {
         get { return _stringOptions.AsReadOnly(); }
      }

      /// <summary>
      /// Gets or sets the selected string option
      /// </summary>
      public string SelectedStringOption
      {
         get { return _selectedStringOption; }
         set { Set(ref _selectedStringOption, value); }
      }

      /// <summary>
      /// Gets object options.
      /// </summary>
      public IEnumerable<KeyValuePair<int, string>> ObjectOptions
      {
         get { return _objectOptions.AsReadOnly(); }
      }

      /// <summary>
      /// Gets or sets the selected string option
      /// </summary>
      public KeyValuePair<int, string> SelectedObjectOption
      {
         get { return _selectedObjectOption; }
         set { Set(ref _selectedObjectOption, value); }
      }

      #endregion
   }
}
