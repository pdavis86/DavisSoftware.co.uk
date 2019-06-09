namespace DavisSoftware.Models
{
    public class ProgressBarModel
    {
        public string Topic { get; set; }
        public int Percentage { get; set; }

        public ProgressBarModel(string topic, int percentage)
        {
            Topic = topic;
            Percentage = percentage;
        }
    }
}