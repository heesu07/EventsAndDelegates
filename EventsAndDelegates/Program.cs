namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();

            var mailService = new MailService();
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            
            var messageService = new MessageService();
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            var printService = new PrintService();
            videoEncoder.VideoEncoded += printService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
