namespace Survey_Basket_API.Models
{
    public class Poll
    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Options { get; set; }
        public List<int> Votes { get; set; }
        public Poll()
        {
            Options = new List<string>();
            Votes = new List<int>();
        }


    }
}
