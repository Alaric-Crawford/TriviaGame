using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TriviaGame
{
    class Program
    {
        static List<Trivia> NameTheArtist = GetNTAList();
        static List<Trivia> History = GetHistoryList();
        static List<Trivia> Geography = GetGeoList();
        static List<Trivia> Arts = GetArtsList();
        static List<Trivia> Entertainment = GetEnmtList();
        static List<Trivia> Science = GetSciList();
        static List<Trivia> Sports = GetSportsList();
        static List<Trivia> EightysFilms = Get80FilmList();
        static List<Trivia> Capitals = GetCapList();
        static List<Trivia> Zodiac = GetZodiacList();
        static List<Trivia> FilmQuotes = GetQuoteList();
        static List<Trivia> VideoGames = GetGamesList();
        static List<Trivia> LeadSingers = GetSingerList();
        static List<Trivia> Random = GetRandomList();

        static List<Trivia> QuestionsAsked = new List<Trivia>();

        static int AnswersRight = 0;

        static int AnswersWrong = 0;

        static void Main(string[] args)
        {
            bool playing = true;

            while (playing == true)
            {
                Console.Clear();
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(AnswersRight + " Answers Right");
                Console.WriteLine(AnswersWrong + " Answers Wrong");

                Console.WriteLine("Want to keep going?");
                var response = Console.ReadLine();

                if (response == "no")
                {
                    playing = false;
                }
            }
        }

        static List<Trivia> GetNTAList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Name The Artist:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetHistoryList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("History:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetGeoList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Geography:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetArtsList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Arts:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetEnmtList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Entertainment:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetSciList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Science:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetSportsList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Sports:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> Get80FilmList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("80's Films:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetCapList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Capitals:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetZodiacList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Zodiac:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetQuoteList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Films Quotes:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetGamesList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Video Games:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetSingerList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Contains("Lead Singers:").ToString().Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static List<Trivia> GetRandomList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();

            List<Trivia> returnList = new List<Trivia>();
            //Each item in list "contents" is now one line of the Trivia.txt document.
            foreach (string pair in contents)
            {
                string question = pair.Split('*')[0];
                string answer = pair.Split('*')[1];
                returnList.Add(new Trivia(question, answer));
            }
            return returnList;
        }

        static void GreetAndPick()
        {
            Console.WriteLine("Hello, and welcome to Trivial!");
            Console.WriteLine("Please pick the number of the category you want:");
            Console.WriteLine();
            Console.WriteLine("1: Name The Artist");
            Console.WriteLine("2: History");
            Console.WriteLine("3: Geography");
            Console.WriteLine("4: Arts");
            Console.WriteLine("5: Entertainment");
            Console.WriteLine("6: Science");
            Console.WriteLine("7: Sports");
            Console.WriteLine("8: 80's Films");
            Console.WriteLine("9: Capitals");
            Console.WriteLine("10: Zodiac");
            Console.WriteLine("11: Film Quotes");
            Console.WriteLine("12: Video Games");
            Console.WriteLine("13: Lead Singers");
            Console.WriteLine("14: Random All");
            var playerChoice = Console.ReadLine();

            if (playerChoice == "1")
            {

            }
            if (playerChoice == "2")
            {

            }
            if (playerChoice == "3")
            {

            }
            if (playerChoice == "4")
            {

            }
            if (playerChoice == "5")
            {

            }
            if (playerChoice == "6")
            {

            }
            if (playerChoice == "7")
            {

            }
            if (playerChoice == "8")
            {

            }
            if (playerChoice == "9")
            {

            }
            if (playerChoice == "10")
            {

            }
            if (playerChoice == "11")
            {

            }
            if (playerChoice == "12")
            {

            }
            if (playerChoice == "13")
            {

            }
            if (playerChoice == "14")
            {

            }
        }

        static void NTAQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, NameTheArtist.Count);

            Trivia questionPicked = NameTheArtist[line];

            QuestionCheck1(questionPicked);
        }

        static void HistQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, History.Count);

            Trivia questionPicked = History[line];

            QuestionCheck2(questionPicked);
        }

        static void GeoQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, Geography.Count);

            Trivia questionPicked = Geography[line];

            QuestionCheck3(questionPicked);
        }

        static void ArtsQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, Arts.Count);

            Trivia questionPicked = Arts[line];

            QuestionCheck4(questionPicked);
        }

        static void EnmtQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, Entertainment.Count);

            Trivia questionPicked = Entertainment[line];

            QuestionCheck5(questionPicked);
        }

        static void SciQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, Science.Count);

            Trivia questionPicked = Science[line];

            QuestionCheck6(questionPicked);
        }

        static void SportsQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, Sports.Count);

            Trivia questionPicked = Sports[line];

            QuestionCheck7(questionPicked);
        }

        static void EightysFilmsQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, EightysFilms.Count);

            Trivia questionPicked = EightysFilms[line];

            QuestionCheck8(questionPicked);
        }

        static void CapsQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, Capitals.Count);

            Trivia questionPicked = Capitals[line];

            QuestionCheck9(questionPicked);
        }

        static void ZodiacQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, Zodiac.Count);

            Trivia questionPicked = Zodiac[line];

            QuestionCheck10(questionPicked);
        }

        static void QuotesQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, FilmQuotes.Count);

            Trivia questionPicked = FilmQuotes[line];

            QuestionCheck11(questionPicked);
        }

        static void GamesQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, VideoGames.Count);

            Trivia questionPicked = VideoGames[line];

            QuestionCheck12(questionPicked);
        }

        static void SingersQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, LeadSingers.Count);

            Trivia questionPicked = LeadSingers[line];

            QuestionCheck13(questionPicked);
        }

        static void RandomQuestion()
        {
            var rando = new Random();

            int line = rando.Next(0, NameTheArtist.Count);

            Trivia questionPicked = NameTheArtist[line];

            QuestionCheck14(questionPicked);
        }

        static void QuestionCheck1(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    NTAQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck2(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    HistQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck3(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    GeoQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck4(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    ArtsQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck5(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    EnmtQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck6(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    SciQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck7(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    SportsQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck8(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    EightysFilmsQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck9(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    CapsQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck10(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    ZodiacQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck11(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    QuotesQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck12(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    GamesQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck13(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    SingersQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void QuestionCheck14(Trivia question)
        {
            foreach (Trivia item in QuestionsAsked)
            {
                if (question.Question == item.Question)
                {
                    RandomQuestion();
                    break;
                }
            }
            QuestionsAsked.Add(question);

            GameTime(question.Question);
        }

        static void GameTime(string requestion)
        {
            Console.WriteLine(requestion);
            var userAnswer = Console.ReadLine();

            AnswerCheck(userAnswer);
        }

        static void AnswerCheck(string answerGot)
        {

            if (answerGot == QuestionsAsked.Last().Answer)
            {
                Console.WriteLine("Well done!");
                AnswersRight++;
            }
            else
            {
                AnswersWrong++;
                Console.WriteLine("Incorrect. The answer or possible answers are:");
                Console.WriteLine(QuestionsAsked.Last().Answer);
            }
        }
    }
}
