using System;
using NUnit.Framework;

namespace Notes
{
  class NoteViewMock
  {
    private readonly NotePresenter _presenter;
    public bool SaveButtonEnabledChanged;

    public NoteViewMock(NotePresenter presenter)
    {
      _presenter = presenter;
      _presenter.SaveButtonEnabledChanged += OnPresenterSaveButtonEnabledChanged;
    }

    private void OnPresenterSaveButtonEnabledChanged(object sender, EventArgs e)
    {
      SaveButtonEnabledChanged = true;
    }
  }

  [TestFixture]
  public class NotePresenterTest
  {
    private NoteViewMock _view;
    private NoteModel _model;
    private NotePresenter _presenter;

    const string new_content = "Wash the dog";

    [SetUp]
    public void SetUp()
    {
      _model = new NoteModel();
      _presenter = new NotePresenter(_model);
      _view = new NoteViewMock(_presenter);
    }

    [Test]
    public void the_save_button_should_be_disabled_by_default()
    {
      Assert.IsFalse(_presenter.SaveButtonEnabled);
    }

    [Test]
    public void the_save_button_should_be_enabled_when_there_is_some_content()
    {
      _model.Content = new_content;

      Assert.IsTrue(_presenter.SaveButtonEnabled);
      Assert.IsTrue(_view.SaveButtonEnabledChanged);
    }

    [Test]
    public void the_save_button_should_be_disabled_when_there_is_an_empty_content()
    {
      _model.Content = String.Empty;

      Assert.IsFalse(_presenter.SaveButtonEnabled);
    }
  }
}
