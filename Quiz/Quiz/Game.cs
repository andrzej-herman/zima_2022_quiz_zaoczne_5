using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    // 100, 200, 300, 400, 500, 750, 1000

    public class Game
    {
        public Game()
        {
            CreateAllQuestions();
            
            Random = new Random();
            //Categories = new List<int> { 100, 200, 300, 400, 500, 750, 1000 };
            Categories = Questions
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            CurrentCategory = Categories[CurrentCategoryIndex];
        }

        public int CurrentCategory { get; set; }
        public List<Question> Questions { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }
        public List<int> Categories { get; set; }
        public int CurrentCategoryIndex { get; set; }

        private void CreateAllQuestions()
        {
            var path =  Directory.GetCurrentDirectory() + "\\questions.json";
            var text = File.ReadAllText(path);
            Questions = JsonConvert.DeserializeObject<List<Question>>(text);
        }

        public void GetQuestion()
        {
            var questionsCat = Questions.Where(x => x.Category == CurrentCategory).ToList();
            var number = Random.Next(0, questionsCat.Count);
            var question = questionsCat[number];
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();
            var order = 1;
            foreach (var a in question.Answers)
            {
                a.Order = order;
                order++;
            }
           
            CurrentQuestion = question;
        }

        public bool CheckPlayerAnswer(int playerNumber)
        {
            var answer = CurrentQuestion.Answers.First(x => x.Order == playerNumber);
            return answer.IsCorrect;
        }

        public bool IsLastCategory()
        {
            if (CurrentCategoryIndex < Categories.Count - 1)
            {
                CurrentCategoryIndex++;
                CurrentCategory = Categories[CurrentCategoryIndex];
                return false;
            }
            else
                return true;
        }

    }
}
