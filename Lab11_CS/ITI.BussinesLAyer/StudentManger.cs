

using Microsoft.Data.SqlClient;
using System.Data;

namespace ITI.BussinesLAyer
{
    public class Student
    {
        public int St_id { get; set; }
        public string? St_Fname { get; set; }
        public string? St_Lname { get; set; }
        public string? St_Address { get; set; }
        public int? Dept_Id { get; set; }
        public int? St_Age { get; set; }

    }
    
        public static class StudentManager
        {
            public static List<Student> GetAll()
            {
                var query = "select * from student";
                var dt = ITI.DataAccessLayer.StudentManger.ExecuteQuery(query);

                List<Student> students = new List<Student>();
                foreach (DataRow row in dt.Rows)
                {
                    Student student = new Student
                    {
                        St_id = (int)row["st_id"],
                        St_Fname = row["st_fname"].ToString(),
                        St_Lname = row["st_lname"].ToString(),
                        St_Address = row["st_address"].ToString(),

                        St_Age = string.IsNullOrEmpty(row["st_age"].ToString()) ? null : (int)row["st_age"]
                    };
                    students.Add(student);
                }

                return students;
            }

            public static Student? GetById(int id)
            {
                var query = $"select * from student where st_id = {id}";
                var dt = DataAccessLayer.StudentManger.ExecuteQuery(query);

                if (dt.Rows.Count != 0)
                {
                    Student student = new Student()
                    {
                        St_id = (int)dt.Rows[0]["st_id"],
                        St_Fname = dt.Rows[0]["st_fname"].ToString(),
                        St_Lname = dt.Rows[0]["st_lname"].ToString(),
                        St_Address = dt.Rows[0]["st_address"].ToString(),
                        St_Age = string.IsNullOrEmpty(dt.Rows[0]["st_age"].ToString()) ? null : (int)dt.Rows[0]["st_age"]

                    };

                    return student;
                }
                return null;
            }

            public static int Add(Student student)
            {
                var query = "insert into student( st_fname, st_lname, st_address, st_age) values ( @fname, @lname, @address, @age)";

                SqlParameter[] sqlParameter =
                {

                new SqlParameter("@fname", student.St_Fname),
                new SqlParameter("@lname", student.St_Lname),
                new SqlParameter("@address", student.St_Address),
                new SqlParameter("@age", student.St_Age)
            };

                return DataAccessLayer.StudentManger.ExecuteNonQuery(query, sqlParameter);
            }

            public static int Update(Student student)
            {
                var query = "update student set st_fname = @fname, st_lname = @lname, st_address = @address, st_age = @age where st_id = @id";

                SqlParameter[] sqlParameter =
                {
                new SqlParameter("@id", student.St_id),
                new SqlParameter("@fname", student.St_Fname),
                new SqlParameter("@lname", student.St_Lname),
                new SqlParameter("@address", student.St_Address),
                new SqlParameter("@age", student.St_Age)
            };

                return DataAccessLayer.StudentManger.ExecuteNonQuery(query, sqlParameter);

            }

            public static int Delete(int id)
            {
                var query = "delete student where st_id = @id";

                SqlParameter[] sqlParameter =
                {
                new SqlParameter("@id", id)
                };

                return DataAccessLayer.StudentManger.ExecuteNonQuery(query, sqlParameter);

            }


        }

    
}
