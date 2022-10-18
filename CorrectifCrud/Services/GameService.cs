using CorrectifCrud.Models;

namespace CorrectifCrud.Services
{
    public class GameService
    {
        private List<Game> _games;

        private int _counter;

        public int Counter
        {
            get { return ++_counter; }
            set { _counter = value; }
        }

        public GameService()
        {
            _games = new List<Game>();
            Counter = 0;
        }

        public List<Game> GetAll()
        {
            return _games;
        }
        public Game GetById(int id)
        {
            return _games.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            _games.Remove(_games.First(x => x.Id == id));
        }

        public void Add(Game g)
        {
            g.Id = Counter;
            _games.Add(g);
        }

        public void Update(Game g)
        {
            Delete(g.Id);
            Add(g);
        }
    }
}
