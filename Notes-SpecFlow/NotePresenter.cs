using System;

namespace Notes
{
  public class NotePresenter
  {
    private readonly NoteModel _model;
    private bool _saveButtonEnabled;

    public NotePresenter(NoteModel model)
    {
      _model = model;

      UpdateViewFromModel();

      _model.ContentChanged += OnModelContentChanged;
    }

    private void OnModelContentChanged(object sender, EventArgs e)
    {
      UpdateViewFromModel();
    }

    private void UpdateViewFromModel()
    {
      SaveButtonEnabled = !String.IsNullOrEmpty(_model.Content);
    }

    public bool SaveButtonEnabled
    {
      get { return _saveButtonEnabled; }
      set
      {
        if (_saveButtonEnabled != value)
        {
          _saveButtonEnabled = value;
          Events.Invoke(this, SaveButtonEnabledChanged);
        }
      }
    }
    public event EventHandler SaveButtonEnabledChanged;
  }
}