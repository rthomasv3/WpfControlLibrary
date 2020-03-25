namespace CodeCompendium.WpfControlLibrary.Models
{
   /// <summary>
   /// Class used to represent a user.
   /// </summary>
   public sealed class User : NotifyPropertyChanged
   {
      #region Fields

      private string _name;
      private string _email;
      private bool _isSubscribed;
      private string _selectedSubscription;

      #endregion

      #region Constructor

      public User(string name, string email, bool isSubscribed, string selectedSubscription)
      {
         _name = name;
         _email = email;
         _isSubscribed = isSubscribed;
         _selectedSubscription = selectedSubscription;
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets the user's name.
      /// </summary>
      public string Name
      {
         get { return _name; }
         set { Set(ref _name, value); }
      }

      /// <summary>
      /// Gets or sets the user's email.
      /// </summary>
      public string Email
      {
         get { return _email; }
         set { Set(ref _email, value); }
      }

      /// <summary>
      /// Gets or sets a boolean indicating if the user is subscribed.
      /// </summary>
      public bool IsSubscribed
      {
         get { return _isSubscribed; }
         set { Set(ref _isSubscribed, value); }
      }

      /// <summary>
      /// Gets or sets the user's selected subscription.
      /// </summary>
      public string SelectedSubscription
      {
         get { return _selectedSubscription; }
         set { Set(ref _selectedSubscription, value); }
      }

      #endregion
   }
}
