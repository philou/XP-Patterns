using System;

namespace Notes
{
  public class NoteController
  {
    private readonly INoteView _view;
    private readonly NoteModel _model;

    public NoteController(INoteView view, NoteModel model)
    {
      _view = view;
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
      _view.ContentTextBoxValue = _model.Content;
      _view.SaveButtonEnabled = !String.IsNullOrEmpty(_model.Content);
    }

    public void ContentChanged(string content)
    {
      _model.Content = content;
    }
  }
}