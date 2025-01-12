using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDay12_Delegate
{
    //database
    public class Repository
    {



        // Create a list of 8 books
        public static List<Book> books = new List<Book>
        {
            new Book("978-3-16-148410-0", "The Great Gatsby", new string[] { "F. Scott Fitzgerald" }, new DateTime(1925, 4, 10), 12.99m),
            new Book("978-0-14-118263-6", "1984", new string[] { "George Orwell" }, new DateTime(1949, 6, 8), 9.99m),
            new Book("978-0-06-112008-4", "To Kill a Mockingbird", new string[] { "Harper Lee" }, new DateTime(1960, 7, 11), 10.99m),
            new Book("978-0-452-28423-4", "Brave New World", new string[] { "Aldous Huxley" }, new DateTime(1932, 1, 1), 11.99m),
            new Book("978-0-7432-7356-5", "The Catcher in the Rye", new string[] { "J.D. Salinger" }, new DateTime(1951, 7, 16), 8.99m),
            new Book("978-0-679-74539-2", "The Road", new string[] { "Cormac McCarthy" }, new DateTime(2006, 9, 26), 14.99m),
            new Book("978-0-385-50420-5", "The Hitchhiker's Guide to the Galaxy", new string[] { "Douglas Adams" }, new DateTime(1979, 10, 12), 7.99m),
            new Book("978-0-14-143951-8", "Pride and Prejudice", new string[] { "Jane Austen" }, new DateTime(1813, 1, 28), 6.99m),
            new Book("978-0-316-76948-0", "Good Omens", new string[] { "Neil Gaiman", "Terry Pratchett" }, new DateTime(1990, 5, 1), 15.99m),
            new Book("978-0-06-025492-6", "The Chronicles of Narnia", new string[] { "C.S. Lewis", "Pauline Baynes" }, new DateTime(1950, 10, 16), 18.99m),
            new Book("978-0-553-57340-3", "The Lord of the Rings", new string[] { "J.R.R. Tolkien", "Christopher Tolkien" }, new DateTime(1954, 7, 29), 22.99m)
        };
        public static List<Employee> Employees
        {
            get
            {
                return new List<Employee>()
                {
                    new Employee{Id=1,Name="Hazem",Age=22,Salary=10234,DeptId=10 },
                    new Employee{Id=2,Name="Mariem",Age=23,Salary=2234,DeptId=20 },
                    new Employee{Id=3,Name="Sara",Age=24,Salary=3234,DeptId=20 },
                    new Employee{Id=4,Name="Ahmed",Age=25,Salary=4234,DeptId=20 },
                    new Employee{Id=5,Name="Osama",Age=26,Salary=5234,DeptId=30 },
                    new Employee{Id=6,Name="Ali",Age=27,Salary=6234,DeptId=30 },
                    new Employee{Id=7,Name="Haidy",Age=28,Salary=7234,DeptId=20 },
                    new Employee{Id=8,Name="Ziad",Age=29,Salary=8234,DeptId=10 },
                    new Employee{Id=9,Name="Waleed",Age=30,Salary=9234,DeptId=10 },
                    new Employee{Id=10,Name="Omar",Age=31,Salary=1234,DeptId=10 }
                };
            }
        }
    }
}
