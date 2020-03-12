namespace WpfControlLibrary.Models
{
   /// <summary>
   /// Class used to represent a child in a tree.
   /// </summary>
   public sealed class TreeItemChild
   {
      #region Fields

      private readonly string _text;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="TreeItemChild"/> class.
      /// </summary>
      public TreeItemChild(string text)
      {
         _text = text;
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
