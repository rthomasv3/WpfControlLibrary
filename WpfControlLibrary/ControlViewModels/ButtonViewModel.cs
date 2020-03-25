using System.Windows;
using System.Windows.Input;

namespace CodeCompendium.WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the button control template.
   /// </summary>
   public sealed class ButtonViewModel : ControlViewModel
   {
      #region Fields

      private string _buttonText;
      private ICommand _command;
      private ICommand _commandWithParameter;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="ButtonViewModel"/> class.
      /// </summary>
      public ButtonViewModel(string name, string title, string subtitle)
          : base(name, title, subtitle)
      {
         _buttonText = "Text From Binding";
         _command = new RelayCommand(RunCommand);
         _commandWithParameter = new RelayCommand(obj => RunCommandWithParameter(obj));
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets button text.
      /// </summary>
      public string ButtonText
      {
         get { return _buttonText; }
      }

      /// <summary>
      /// Gets command.
      /// </summary>
      public ICommand Command
      {
         get { return _command; }
      }

      /// <summary>
      /// Gets command with parameter.
      /// </summary>
      public ICommand CommandWithParameter
      {
         get { return _commandWithParameter; }
      }

      #endregion

      #region Private Methods

      private void RunCommand()
      {
         MessageBox.Show("Command executed!");
      }

      private void RunCommandWithParameter(object parameter)
      {
         MessageBox.Show($"Command executed with parameter: {parameter}!");
      }

      #endregion
   }
}
