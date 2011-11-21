using System;

namespace Notes
{
  public static class Events
  {
    public static void Invoke(object sender, EventHandler eventHandler)
    {
      if (eventHandler != null)
      {
        eventHandler(sender, EventArgs.Empty);
      }
    }
  }
}
