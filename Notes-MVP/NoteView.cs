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
      _presenter = new NotePresenter(_model);
    }

    protected override void OnLoad(System.EventArgs e)
    {
      base.OnLoad(e);

      _contentTextBox.DataBindings.Add("Text", _model, "Content", false, DataSourceUpdateMode.OnPropertyChanged);
      _saveButton.DataBindings.Add("Enabled", _presenter, "SaveButtonEnabled", false, DataSourceUpdateMode.OnPropertyChanged);
    }
  }
}
