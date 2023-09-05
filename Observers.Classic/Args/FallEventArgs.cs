namespace Observers.Classic.Args
{
    public class FallEventArgs : EventArgs
    {
        public FallEventArgs(DateTime happenDate)
        {
            HappenDate = happenDate;
        }

        public DateTime HappenDate { get; set; }
    }
}