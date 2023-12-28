internal partial class Program
{
    public class StopWatch
    {
        private bool status;
        private DateTime initial_time;
        private DateTime final_time;

        public StopWatch()
        {
            this.status = false;
        }

        public void Start()
        {
            if (this.status)
            {
                throw new InvalidOperationException("The stopwatch is already started");
            }
            else
            {
                this.initial_time = DateTime.Now;
                this.status = true;
            }
        }

        public void Stop()
        {
            this.final_time = DateTime.Now;
            this.status = false;
        }

        public TimeSpan Duration()
        {
            TimeSpan duration = this.final_time - this.initial_time;
            return duration;
        }

    }
}