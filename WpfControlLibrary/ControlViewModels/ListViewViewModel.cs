using System.Collections.Generic;
using WpfControlLibrary.Models;

namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the list view control template.
   /// </summary>
   public sealed class ListViewViewModel : ControlViewModel
   {
      #region Fields

      private readonly List<User> _users = new List<User>()
      {
         new User("Red", "red@codecompendium.dev", false, "All Emails"),
         new User("Blue", "blue@codecompendium.dev", true, "Ads Only"),
      };

      private User _selectedUser;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="ListViewViewModel"/> class.
      /// </summary>
      public ListViewViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
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

      #endregion
   }
}
