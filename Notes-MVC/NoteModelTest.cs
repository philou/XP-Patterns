using NUnit.Framework;

namespace Notes
{
  [TestFixture]
  public class NoteModelTest
  {
    private NoteModel _note;
    private bool _content_modification_published;

    [SetUp]
    public void SetUp()
    {
      _note = new NoteModel { Content = "Don't forget to buy pizzas for tonight."};

      _content_modification_published = false;
      _note.ContentChanged += (s, a) => _content_modification_published = true;
    }
    [Test]
    public void content_should_publish_its_modifications()
    {
      _note.Content = "Fix the hoover.";

      Assert.IsTrue(_content_modification_published);
    }

    [Test]
    public void content_should_not_publish_non_modifications()
    {
      _note.Content = _note.Content;

      Assert.IsFalse(_content_modification_published);
    }

  }
}