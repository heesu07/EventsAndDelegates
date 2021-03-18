using System;

namespace EventsAndDelegates
{
  public class PrintService
  {
    public void OnVideoEncoded(object source, VideoEventArgs args)
    {
      Console.WriteLine("PrintService: Print encoding result..." + args.Video.Title );
    }
  }
}
