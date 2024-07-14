namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their favorite school subject
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            // Use a switch statement to handle different subjects
            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math:I dont really like Math but if you do that's okay.");
                    break;

                case "science":
                    Console.WriteLine("Science: This is my favorite class subject.");
                    break;

                case "history":
                    Console.WriteLine("History: Learning about the past is like stepping back in time!.");
                    break;

                case "english":
                    Console.WriteLine("English: Reading is great! have you ever read Xanth? by: Piers Anthony.");
                    break;

                case "art":
                    Console.WriteLine("Art: My mom always said artist go hungry, maybe she was right.");
                    break;

                default:
                    Console.WriteLine($"Interesting choice! You like {favoriteSubject}, which is a unique subject.");
                    break;
            }
        }
    }
}