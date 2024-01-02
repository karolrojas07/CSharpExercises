using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    internal class VideoUploaderActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is being uploaded");
        }
    }

    internal class VideoEncoderActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notifying third party service there is a video ready for encoding");
        }
    }

    internal class VideoNotificationActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notify the owner by email the video is being processing");
        }
    }

    internal class VideoDatabaseActivity : IActivity
    {
        public void Execute() {
            Console.WriteLine("Change the video's status to Processin in the database");
        }
    }
}
