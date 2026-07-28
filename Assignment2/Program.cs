namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Book obj = new Book();
            obj.title = "Genius";
            obj.age = 50;
            Console.WriteLine(obj.title);
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj.Equals(obj));
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj.GetType());
            /*try
            {
                int res = 10 / 0;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("DONE");
            }*/
            /*double price = 49.99;

            int p = (int)price;
            Console.WriteLine(p);*/
            //int pages = 300;
            //double pp = Convert.ToDouble(pages);
            //Console.WriteLine(pp);
            //string pagesText = "464";
            //int tt = Convert.ToInt32(pagesText);
            //Console.WriteLine(tt);
            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine(year);
            //string badText = "abc";
            //if(int.TryParse(badText,out int result))
            //{
            //  Console.WriteLine(result);
            //}
            //else
            //{
            //  Console.WriteLine("Invalid number");
            //}
            //int pages = 464;
            //string text = pages.ToString();
            //Console.WriteLine(text);
            //Console.WriteLine(text.GetType());
            int copies = 100;
            object boxedCopies = copies;
            int newCopies = (int)boxedCopies;
            Console.WriteLine(boxedCopies);
            Console.WriteLine(newCopies);
            int? year = null;
            Console.WriteLine(year);

            year = 2023;
            Console.WriteLine(year);
            string? reviewer = null;
            if (reviewer == null)
                Console.WriteLine("whether");
            Book? book = null;
            book?.title = "ahmed";//انا بي لما سويت باحمد لم يطبع احمد وانا لما كنت سايبه فارغ مطبعش null 
            Console.WriteLine(book?.title);
            string? title = null;
            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled";
            Console.WriteLine(title);
            string? name = "Ahmed";
            string confirmedName = name!;

            Console.WriteLine(confirmedName);

            string studentname;
            string Age, Grade1, Grade2, Grade3;

            Console.WriteLine("Enter name ");
            studentname = Console.ReadLine();
            Console.WriteLine("Enter Age ");
            Age = Console.ReadLine();
            Console.WriteLine("Enter Grade1 ");
            Grade1 = Console.ReadLine();
            Console.WriteLine("Enter grade2 ");
            Grade2 = Console.ReadLine();
            Console.WriteLine("Enter grade3 ");
            Grade3 = Console.ReadLine();
            int totalgrade = Convert.ToInt32(Grade1) + Convert.ToInt32(Grade2) + Convert.ToInt32(Grade3);
            //int.TryParse(Console.WriteLine(totalgrade);

            double Average = totalgrade / 3;
            Console.WriteLine($"Average: {Average}");
            if (Convert.ToInt32(Average) >= 50)
                Console.WriteLine("PASSAD");
            else
                Console.WriteLine("FAILED");

            Console.WriteLine($"STUDET NAME{studentname}");
            if (Convert.ToInt32(Age) >= 18)
                Console.WriteLine("ADULT");
            else
                Console.WriteLine("MINOR");


        }
    }
}
