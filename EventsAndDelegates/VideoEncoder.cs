namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // Steps to use Events:
        // 1 - Define a delegate.
        // 2 - Define an event based on that delegate.
        // 3 - Raise the event.

        // Normal form: public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // EventHandler
        // EventHandler<TEventArgs>
        // Normal form: public event VideoEncodedEventHandler VideoEncoded;

        // Less code that normal form...
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}