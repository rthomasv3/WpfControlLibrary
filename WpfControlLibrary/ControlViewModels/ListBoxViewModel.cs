using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfControlLibrary.Models;

namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the list box control template.
   /// </summary>
   public sealed class ListBoxViewModel : ControlViewModel
   {
      #region Fields

      private readonly List<string> _readonlyList = new List<string>()
      {
         "First Item", "Second Item", "Third Item"
      };
      private readonly List<User> _users = new List<User>()
      {
         new User("Red", "red@codecompendium.dev", false, "All Emails"),
         new User("Blue", "blue@codecompendium.dev", true, "Ads Only"),
      };
      private readonly ObservableCollection<string> _dynamicList = new ObservableCollection<string>()
      {
         "First Item", "Second Item", "Third Item"
      };

      private User _selectedUser;
      private string _readonlyListSelection;
      private string _dynamicListSelection;
      private string _textToAdd;

      private ICommand _addToListCommand;
      private ICommand _deleteFromListCommand;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="ListBoxViewModel"/> class.
      /// </summary>
      public ListBoxViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _addToListCommand = new RelayCommand(AddToList);
         _deleteFromListCommand = new RelayCommand(obj => DeleteFromList(obj as string));
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets a readonly list of simple items.
      /// </summary>
      public IEnumerable<string> ReadonlyList
      {
         get { return _readonlyList.AsReadOnly(); }
      }

      /// <summary>
      /// Gets or sets the basic list selection.
      /// </summary>
      public string ReadonlyListSelection
      {
         get { return _readonlyListSelection; }
         set { Set(ref _readonlyListSelection, value); }
      }

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
      /// Gets a dynamic list of strings.
      /// </summary>
      public IEnumerable<string> DynamicList
      {
         get { return _dynamicList; }
      }

      /// <summary>
      /// Gets or sets the dynamic list selection.
      /// </summary>
      public string DynamicListSelection
      {
         get { return _dynamicListSelection; }
         set { Set(ref _dynamicListSelection, value); }
      }

      /// <summary>
      /// Gets or sets the text to add to the dynamic list.
      /// </summary>
      public string TextToAdd
      {
         get { return _textToAdd; }
         set { Set(ref _textToAdd, value); }
      }

      /// <summary>
      /// Gets the add to list command.
      /// </summary>
      public ICommand AddToListCommand
      {
         get { return _addToListCommand; }
      }

      /// <summary>
      /// Gets the delete from list command.
      /// </summary>
      public ICommand DeleteFromListCommand
      {
         get { return _deleteFromListCommand; }
      }

      #endregion

      #region Private Methods

      private void AddToList()
      {
         _dynamicList.Add(_textToAdd);

         _textToAdd = String.Empty;
         OnPropertyChanged(nameof(TextToAdd));
      }

      private void DeleteFromList(string item)
      {
         _dynamicList.Remove(item);
      }

      #endregion
   }
}
