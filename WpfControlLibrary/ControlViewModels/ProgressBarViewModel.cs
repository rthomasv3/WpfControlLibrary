using System.Threading;
using System.Windows.Input;

namespace WpfControlLibrary.ControlViewModels
{
   /// <summary>
   /// View model for the progress bar control template.
   /// </summary>
   public sealed class ProgressBarViewModel : ControlViewModel
   {
      #region Fields

      private int _progress;
      private WaitCallback _progressAction;
      private bool _isRunning;
      private ICommand _startProgressCommand;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="ProgressBarViewModel"/> class.
      /// </summary>
      public ProgressBarViewModel(string name, string title, string subtitle)
         : base(name, title, subtitle)
      {
         _progressAction = new WaitCallback(obj => ActionWithProgress());
         _startProgressCommand = new RelayCommand(CanExecute, RunAction);
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets the current progress.
      /// </summary>
      public int Progress
      {
         get { return _progress; }
      }

      /// <summary>
      /// Gets a command to start running an action that reports progress.
      /// </summary>
      public ICommand StartProgressCommand
      {
         get { return _startProgressCommand; }
      }

      #endregion

      #region Private Methods

      private bool CanExecute()
      {
         return !_isRunning;
      }

      private void RunAction()
      {
         _progress = 0;
         ThreadPool.QueueUserWorkItem(_progressAction);
      }

      private void ActionWithProgress()
      {
         _isRunning = true;

         while (_progress < 100)
         {
            Thread.Sleep(100);

            Interlocked.Increment(ref _progress);
            OnPropertyChanged(nameof(Progress));
         }

         _isRunning = false;
      }

      #endregion
   }
}
