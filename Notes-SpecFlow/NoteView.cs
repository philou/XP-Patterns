using System.Windows.Forms;

namespace Notes
{
  public partial class NoteView : Form
  {
    private readonly NoteModel _model;
    private readonly NotePresenter _presenter;

    public NoteView()
    {
      InitializeComponent();

      _model = new NoteModel();
      _presenter = new NotePresenter(Model);

      _contentTextBox.DataBindings.Add("Text", Model, "Content", false, DataSourceUpdateMode.OnPropertyChanged);
      _saveButton.DataBindings.Add("Enabled", Presenter, "SaveButtonEnabled", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    public NoteModel Model
    {
      get { return _model; }
    }

    public NotePresenter Presenter
    {
      get { return _presenter; }
    }
  }
}
