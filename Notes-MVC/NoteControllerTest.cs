using System;
using NUnit.Framework;

namespace Notes
{
  class NoteViewMock : INoteView
  {
    public string ContentTextBoxValue { get; set; }
    public bool SaveButtonEnabled { get; set; }
  }

  [TestFixture]
  public class NoteControllerTest
  {
    private NoteViewMock _view;
    private NoteModel _model;
    private NoteController _controller;

    const string new_content = "Wash the dog";

    [SetUp]
    public void SetUp()
    {
      _view = new NoteViewMock { SaveButtonEnabled = true, ContentTextBoxValue = "Default view content"};
      _model = new NoteModel { Content = "" };
      _controller = new NoteController(_view, _model);
    }

    [Test]
    public void it_should_update_the_model_with_the_content_in_the_view()
    {
      _controller.ContentChanged(new_content);

      Assert.AreEqual(new_content, _model.Content);
    }
    [Test]
    public void it_should_update_the_view_if_the_model_changes()
    {
      _model.Content = new_content;

      Assert.AreEqual(new_content, _view.ContentTextBoxValue);
    }

    [Test]
    public void it_should_initialize_the_view_text_box_with_the_content_of_the_model()
    {
      Assert.AreEqual(_model.Content, _view.ContentTextBoxValue);
    }

    [Test]
    public void it_should_disable_the_save_button_by_default()
    {
      Assert.IsFalse(_view.SaveButtonEnabled);
    }

    [Test]
    public void it_should_enable_the_save_button_when_some_content_is_entered()
    {
      _controller.ContentChanged(new_content);

      Assert.IsTrue(_view.SaveButtonEnabled);
    }

    [Test]
    public void it_should_not_enable_the_save_button_when_some_empty_content_is_entered()
    {
      _controller.ContentChanged(String.Empty);

      Assert.IsFalse(_view.SaveButtonEnabled);
    }
  }
}
