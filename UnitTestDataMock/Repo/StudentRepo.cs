using System.Collections.Generic;

namespace UnitTestDataMock.Repo
{
    public class StudentRepo : IStudent
    {
        public Data Db ;
        public StudentRepo()
        {
            Db = new Data();
        }
        public int DalAddStudent(Student obj)
        {
            return Db.Add(obj);
        }

        public Student DalGetStudentById(int StudentId)
        {
            return Db.Get(StudentId);
        }

        public List<Student> DalGetStudents()
        {
            return Db.GellAll();
        }

        public int DalDeleteStudent(int StudentId)
        {
            return Db.Delete(StudentId);
        }

        public int DalUpdateStudent(Student obj)
        {
            return Db.Update(obj);
        }
    }
}
