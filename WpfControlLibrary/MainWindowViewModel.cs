using System.Collections.Generic;
using System.Linq;
using WpfControlLibrary.ControlViewModels;

namespace WpfControlLibrary
{
   /// <summary>
   /// View model for the main window view.
   /// </summary>
   public sealed class MainWindowViewModel : NotifyPropertyChanged
   {
      #region Fields

      private readonly List<ControlViewModel> _tabs = new List<ControlViewModel>();
      private ControlViewModel _selectedTab;

      #endregion

      #region Constructor

      /// <summary>
      /// Creates a new instance of the <see cref="MainWindowViewModel"/> class.
      /// </summary>
      public MainWindowViewModel()
      {
         _tabs.Add(new BorderViewModel("Border", "The WPF Border Control", "The border control is used to provide padding, border, and shadow effects."));
         _tabs.Add(new ButtonViewModel("Button", "The WPF Button Control", "The button control is used to execute view model commands."));
         _tabs.Add(new CheckBoxViewModel("CheckBox", "The WPF CheckBox Control", "The check box control is used to toggle values."));
         _tabs.Add(new ComboBoxViewModel("ComboBox", "The WPF ComboBox Control", "The combo box control is used to select from a list of values."));
         _tabs.Add(new DataGridViewModel("DataGrid", "The WPF DataGrid Control", "The data grid control is used to display and edit data in a grid format."));
         _tabs.Add(new GridViewModel("Grid", "The WPF Grid Control", "The grid control is used to display controls in a grid format."));
         _tabs.Add(new GroupBoxViewModel("GroupBox", "The WPF GroupBox Control", "The group box control is used to separate controls into groups."));
         _tabs.Add(new ImageViewModel("Image", "The Image WPF Control", "The image control is used to display images on the screen"));
         _tabs.Add(new ListBoxViewModel("ListBox", "The WPF ListBox Control", "The list box control is used to display a scrollable list of items."));
         _tabs.Add(new ListViewViewModel("ListView", "The WPF ListView Control", "The list view control is used to display a list of items in different layouts."));
         _tabs.Add(new ProgressBarViewModel("ProgressBar", "The WPF ProgressBar Control", "The progress bar control is used to report the progress of an operation."));
         _tabs.Add(new RadioButtonViewModel("RadioButton", "The WPF RadioButton Control", "The radio button control is used for single selection within a group of options."));
         _tabs.Add(new ScrollViewerViewModel("ScrollViewer", "The WPF ScrollViewer Control", "The scroll viewer control is used to create a region that can be scrolled horizontally or vertically."));
         _tabs.Add(new StackPanelViewModel("StackPanel", "The WPF StackPanel Control", "The stack panel control is used to stack controls vertically or horizontally."));
         _tabs.Add(new TextBlockViewModel("TextBlock", "The WPF TextBlock Control", "The text block control is used to display text on the screen in basic scenarios."));
         _tabs.Add(new TextBoxViewModel("TextBox", "The WPF TextBox Control", "The text box control is used to support user input of various data types."));
         _tabs.Add(new TreeViewViewModel("TreeView", "The WPF TreeView Control", "The tree view control is used to display data in a collapsible, hierarchical structure"));
         _tabs.Add(new WrapPanelViewModel("WrapPanel", "The WPF WrapPanel Control", "The wrap panel control is used to layout controls and break to the next row/column when needed."));

         _selectedTab = _tabs.FirstOrDefault();
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets the list of tabs.
      /// </summary>
      public IEnumerable<ControlViewModel> Tabs
      {
         get { return _tabs.AsReadOnly(); }
      }

      /// <summary>
      /// Gets or sets the selected tab.
      /// </summary>
      public ControlViewModel SelectedTab
      {
         get { return _selectedTab; }
         set { Set(ref _selectedTab, value); }
      }

      #endregion
   }
}
