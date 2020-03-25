using System.Collections.Generic;

namespace CodeCompendium.WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the scroll viewer control template.
   /// </summary>
   public sealed class ScrollViewerViewModel : ControlViewModel
   {
      #region Fields

      private readonly List<string> _items;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="ScrollViewerViewModel"/> class.
      /// </summary>
      public ScrollViewerViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _items = new List<string>();
         for (int i = 0; i < 50; ++i)
         {
            _items.Add($"Item {i}");
         }
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets a list of items.
      /// </summary>
      public IEnumerable<string> Items
      {
         get { return _items.AsReadOnly(); }
      }

      #endregion
   }
}
