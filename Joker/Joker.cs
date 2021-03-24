using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joker
{
    class Joker
    {
        private static int id = 1;
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        private List<User> insertUserNums = new List<User>();

        public Joker()
        {
            Date = DateTime.Now.Date;
            IdInsert();
            Start();
        }

        public void IdInsert()
        {
            Id = id;
            id++;
        }
        public void Start()
        {
            Console.WriteLine($"Welcome to Joker!\nDraw No:{Id})");
            User user1 = new User(insertUserNums.Count);
            insertUserNums.Add(user1);
            user1.Insert();
            Draw draw = new Draw();
            insertUserNums.ForEach(x => x.Results(draw.DrawNumbers,draw.DrawJoker));
        }
    }
}
