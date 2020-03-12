using System.Collections.Generic;
using System.Linq;
using WpfControlLibrary.Models;

namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the data grid control template.
   /// </summary>
   public sealed class DataGridViewModel : ControlViewModel
   {
      #region Fields

      private readonly List<string> _subscriptionOptions = new List<string>()
      {
         "All Emails", "Announcements Only", "Ads Only"
      };

      private readonly List<User> _users = new List<User>()
      {
         new User("Red", "red@codecompendium.dev", false, "All Emails"),
         new User("Blue", "blue@codecompendium.dev", true, "Ads Only"),
      };

      private User _selectedUser;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="DataGridViewModel"/> class.
      /// </summary>
      public DataGridViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _selectedUser = _users.Last();
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets the list of users.
      /// </summary>
      public IEnumerable<User> Users
      {
         get { return _users.AsReadOnly(); }
      }

      /// <summary>
      /// Gets or sets the selected user.
      /// </summary>
      public User SelectedUser
      {
         get { return _selectedUser; }
         set { Set(ref _selectedUser, value); }
      }

      /// <summary>
      /// Gets the list of subscription options.
      /// </summary>
      public IEnumerable<string> SubscriptionOptions
      {
         get { return _subscriptionOptions.AsReadOnly(); }
      }

      #endregion
   }
}
