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
          Events.Invoke(this, ContentChanged);
        }
      }
    }

    public event EventHandler ContentChanged;
  }
}