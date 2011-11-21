using System.Windows.Forms;

namespace Notes
{
  public partial class NoteView : Form, INoteView
  {
    private readonly NoteController _controller;

    public NoteView()
    {
      InitializeComponent();

      _controller = new NoteController(this, new NoteModel());
    }

    public string ContentTextBoxValue
    {
      set { _contentTextBox.Text = value; }
    }

    public bool SaveButtonEnabled
    {
      set { _saveButton.Enabled = value; }
    }

    private void OnContentTextBoxTextChanged(object sender, System.EventArgs e)
    {
      _controller.ContentChanged(_contentTextBox.Text);
    }
  }
}
