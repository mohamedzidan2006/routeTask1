namespace routeT1
{
    class Book
    {
        public string title;
        public int page;
    }
    internal class Program
    {
        static void Main()
        {
            //Book b = new Book();
            //b.title = "clean code";
            //b.page = 10;
            //object obj = b;
            #region Q1
            //Console.WriteLine(b.title);
            //Console.WriteLine(b.page);
            #endregion
            #region Q2
            //Console.WriteLine(b.ToString());
            //Console.WriteLine(b.Equals(b));
            //Console.WriteLine(b.GetHashCode());
            //Console.WriteLine(b.GetType());
            #endregion
            #region Q3
            //int pages =int.Parse("464");
            #endregion
            #region Q4
            //            try
            //            {
            //                int num1 = 10;
            //                int num2 = 0;
            //                int division = num1 / num2;
            //                Console.WriteLine(division);
            //            }
            //            catch (Exception ex) {
            //                Console.WriteLine(ex.ToString());
            //            }
            //            finally {
            //                Console.WriteLine("Done");
            //}
            #endregion
            #region Q5
            //int pages = 300;
            //double p = pages;
            //Console.WriteLine(p);
            #endregion
            #region Q6
            //double price = 49.99;
            //int p = (int)price;
            //Console.WriteLine(p);
            #endregion
            #region Q7
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);
            #endregion
            #region Q8
            //string yearText = "2023";
            //int year1=int.Parse(yearText);
            //Console.WriteLine(year1);
            //string badText = "abc";
            //if (int.TryParse(badText, out int result))
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("Invalid number");
            #endregion
            #region Q9
            //int copies = 100;
            //object boxed = copies;
            //int unboxed = (int)boxed;
            //Console.WriteLine(boxed);
            //Console.WriteLine(unboxed);
            #endregion
            #region Q10
            //int? year = null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year.Value);
            #endregion
            #region Q11
            //string? reviewer = null;
            //Console.WriteLine(reviewer == null);
            #endregion
            #region Q12
            //Book? book = null;
            //Console.WriteLine(book?.title);
            #endregion
            #region Q13
            //string? title = null;
            //Console.WriteLine(title ?? "Untitled");
            //title ??= "Untitled";
            //Console.WriteLine(title);
            #endregion
            #region Q14
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //Console.WriteLine(confirmedName);
            #endregion
            Console.WriteLine("Enter your name");
            


        }
    }
}
