using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{    
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 만들어서 사용하기
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        //public delegate void VideoEncodeEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodeEventHandler VideoEncoded;

        // 제공되는 것 사용하기
        // EventHandler
        // EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video )
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
