
namespace ServeyBasket.Api.Services;

public class PollService : IPollService
{
    private static readonly List<Poll> _polls = [
        new Poll {Id = 1, Title = "Title 1", Description = "Description 1"},
        new Poll {Id = 2, Title = "Title 2", Description = "Description 2"}
    ];
    public IEnumerable<Poll> GetAll() => _polls;
    public Poll? Get(int id) => _polls.SingleOrDefault(x => x.Id == id);
    public Poll Add(Poll poll)
    {
        poll.Id = _polls.Count + 1;
        _polls.Add(poll);
        return poll;
    }
    public bool Update(int id, Poll newPoll)
    {
        Poll? currentPoll = Get(id);
        if (currentPoll is null)
            return false;

        currentPoll.Title = newPoll.Title;
        currentPoll.Description = newPoll.Description;

        return true;
    }
    public bool Delete(int id)
    {
        Poll? currentPoll = Get(id);
        if (currentPoll is null)
            return false;

        _polls.Remove(currentPoll);
        return true;
    }
}