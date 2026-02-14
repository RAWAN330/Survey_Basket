


namespace Survey_Basket_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollsController : ControllerBase
    {
       

        private readonly IPollService pollService;

        public PollsController(IPollService pollService)
        {
            this.pollService = pollService;
        }
        [HttpGet]
        public ActionResult GetPolls() {
            var polls = pollService.Get();
            return Ok(polls);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetPoll(int id) {
        var poll = pollService.GetById(id);
          return poll is not null ? Ok(poll) : NotFound();
        }

        [HttpPost ("")]
        public ActionResult CreatePoll(Poll poll)
        {
                        // Implementation for creating a new poll would go here
            return CreatedAtAction(nameof(GetPoll), new { id = poll.Id }, poll);
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePoll(int id, Poll request)
        {
            var isUpdated = pollService.Update(id, request);
            if (! isUpdated) 
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePoll(int id)
        {
            var isDelete = pollService.Delete(id);
            if (!isDelete)
                return NotFound();
            return NoContent();
        }

        }
}
