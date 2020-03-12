using System;

namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the image view control template.
   /// </summary>
   public sealed class ImageViewModel : ControlViewModel
   {
      #region Fields

      private readonly Uri _imageUri;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="ImageViewModel"/> class.
      /// </summary>
      public ImageViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _imageUri = new Uri("/Resources/code-compendium-icon-48.png", UriKind.Relative);
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets the default image uri.
      /// </summary>
      public Uri ImageUri
      {
         get { return _imageUri; }
      }

      #endregion
   }
}
