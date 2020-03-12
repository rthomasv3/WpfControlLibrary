using System.Collections.Generic;
using System.Linq;

namespace WpfControlLibrary.Models
{
   /// <summary>
   /// Class used to represent a parent in a tree.
   /// </summary>
   public sealed class TreeItemParent
   {
      #region Fields

      private readonly string _text;
      private readonly IEnumerable<TreeItemChild> _children;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="TreeItemParent"/> class.
      /// </summary>
      public TreeItemParent(string text, List<TreeItemChild> children)
      {
         _text = text;
         _children = children ?? Enumerable.Empty<TreeItemChild>();
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

      /// <summary>
      /// Gets a collection of tree item children.
      /// </summary>
      public IEnumerable<TreeItemChild> Children
      {
         get { return _children; }
      }

      #endregion
   }
}
