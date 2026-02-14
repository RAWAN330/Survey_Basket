using Survey_Basket_API.Models;

namespace Survey_Basket_API.Service
{
    public class PollService : IPollService
    {
        private readonly static List<Poll> polls = [
           new Poll
            {
                Id = 1,
                Title = "Favorite Programming Language",
                Description = "Vote for your favorite programming language.",
                Options = new List<string> { "C#", "Java", "Python", "JavaScript" },
                Votes = new List<int> { 10, 5, 15, 20 }
            },
            ];

        public Poll Add(Poll poll)
        {
          
            poll.Id = polls.Count > 0 ? polls.Max(p => p.Id) + 1 : 1; // Auto-increment ID
                polls.Add(poll);
                return poll;
        }

        public bool Delete(int id)
        {
            var Poll = GetById(id);
            if (Poll is null)
                return false;

            polls.Remove(Poll);
            return true;

        }

        public IEnumerable<Poll> Get()
        {
            return polls;
        }

        public Poll GetById(int id)
        {
           
            return polls?.FirstOrDefault(p => p.Id == id)?? new Poll();
        }

        public bool Update( int id , Poll poll)
        {

            var currentPoll = GetById(id);
            if (currentPoll is null)
                return false;

            currentPoll.Description = poll.Description;
            currentPoll.Id = id;
            currentPoll.Title = poll.Title;
            currentPoll.Options = poll.Options;
            currentPoll.Votes = poll.Votes;
            return true;


        }
    }
}
