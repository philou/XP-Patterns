using System;

namespace Notes
{
  public class NoteModel
  {
    private string _content;
    public string Content
    {
      get { return _content; }
      set
      {
        if (_content != value)
        {
          _content = value;
          Invoke(ContentChanged);
        }
      }
    }

    public event EventHandler ContentChanged;

    private void Invoke(EventHandler eventHandler)
    {
      if (eventHandler != null)
      {
        eventHandler(this, EventArgs.Empty);
      }
    }

  }
}