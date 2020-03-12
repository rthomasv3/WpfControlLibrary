using System.Collections.Generic;
using WpfControlLibrary.Models;

namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the tree view control template.
   /// </summary>
   public sealed class TreeViewViewModel : ControlViewModel
   {
      #region Fields

      private readonly List<TreeItemParent> _treeItems = new List<TreeItemParent>();

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="TreeViewViewModel"/> class.
      /// </summary>
      public TreeViewViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         for (int i = 0; i < 5; ++i)
         {
            List<TreeItemChild> children = new List<TreeItemChild>();
            for (int j = 0; j < 3; ++j)
            {
               children.Add(new TreeItemChild($"Child {j}"));
            }
            _treeItems.Add(new TreeItemParent($"Parent {i}", children));
         }
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets the collection of tree items.
      /// </summary>
      public IEnumerable<TreeItemParent> TreeItems
      {
         get { return _treeItems.AsReadOnly(); }
      }

      #endregion
   }
}
