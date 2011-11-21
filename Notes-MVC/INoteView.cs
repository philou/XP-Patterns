namespace Notes
{
  public interface INoteView
  {
    string ContentTextBoxValue { set; }
    bool SaveButtonEnabled { set; }
  }
}