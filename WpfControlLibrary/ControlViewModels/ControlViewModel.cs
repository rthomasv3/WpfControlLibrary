using System;

namespace CodeCompendium.WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// Base view model for all control templates.
   /// </summary>
   public class ControlViewModel : NotifyPropertyChanged
   {
      #region Fields

      private string _name;
      private string _title;
      private string _subtitle;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="ControlViewModel"/> class.
      /// </summary>
      public ControlViewModel(string name, string title, string subtitle)
      {
         _name = name ?? throw new ArgumentNullException(nameof(name));
         _title = title ?? throw new ArgumentNullException(nameof(title));
         _subtitle = subtitle ?? throw new ArgumentNullException(nameof(subtitle));
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets the control view model name.
      /// </summary>
      public string Name
      {
         get { return _name; }
      }

      /// <summary>
      /// Gets the control view model title.
      /// </summary>
      public string Title
      {
         get { return _title; }
      }

      /// <summary>
      /// Gets the control view model subtitle.
      /// </summary>
      public string Subtitle
      {
         get { return _subtitle; }
      }

      #endregion
   }
}
