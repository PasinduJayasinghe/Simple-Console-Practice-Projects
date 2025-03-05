using System.IO;




namespace QuizzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("questions.txt");
            List<string> questions = new List<string>();
            List<string> answers = new List<string>();

            for (int i = 0; i < text.Length; i++) {
                if (i % 4 == 0)
                {
                    questions.Add(text[i]);


                }
                else {
                    answers.Add(text[i]);
                }


            }

            int quetionsIndex = 0;
            int answersIndex=0;
            int score = 0;

            while (quetionsIndex < questions.Count) {
                Console.WriteLine(questions[quetionsIndex]);
                quetionsIndex++;

                int correctAnswerIndex = 0;

                for (int i = 0; i < 3; i++)
                {
                    if (answers[answersIndex].StartsWith(">"))
                    {
                        correctAnswerIndex = i + 1;

                        Console.WriteLine(i + 1 + "" + answers[answersIndex].Replace(">",""));
                        answersIndex++;
                    }
                }

                int answer=Convert.ToInt32(Console.ReadLine());

                if(answer == answersIndex)
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            
            
            }
        }
    }
}
