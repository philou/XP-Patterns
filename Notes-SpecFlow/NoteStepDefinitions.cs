using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Notes
{
  public static class NoteViewExtensions
  {
    public static void AddContent(this NoteView view, string content)
    {
      view.Model.Content += content;
    }
    public static bool IsSaveButtonEnabled(this NoteView view)
    {
      return view.Presenter.SaveButtonEnabled;
    }
  }

  [Binding]
  public class NoteStepDefinitions
  {
    private NoteView _noteView;

    [Given(@"I am editing a new TODO note")]
    public void GivenIAmEditingANewTODONote()
    {
      _noteView = new NoteView();
    }

    [When(@"I add ""(.*)"" to the note")]
    public void WhenIAddToTheNote(string content)
    {
      _noteView.AddContent(content);
    }

    [Then(@"the save button should be enabled")]
    public void ThenTheSaveButtonShouldBeEnabled()
    {
      Assert.IsTrue(_noteView.IsSaveButtonEnabled());
    }
  }
}
