using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Game
    {
        public Game()
        {
            CreateAllQuestions();
            CurrentCategory = 100;
            Random = new Random();
        }

        public int CurrentCategory { get; set; }
        public List<Question> Questions { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }

        private void CreateAllQuestions()
        {
            var path =  Directory.GetCurrentDirectory() + "\\questions.json";
            var text = File.ReadAllText(path);
            Questions = JsonConvert.DeserializeObject<List<Question>>(text);
        }

        public void GetQuestion()
        {
            var questionsCat = new List<Question>();
            foreach (var q in Questions)
            {
                if (q.Category == CurrentCategory)
                {
                    questionsCat.Add(q);
                }
            }

            var number = Random.Next(0, questionsCat.Count);
            CurrentQuestion = questionsCat[number];

        }
    }
}
