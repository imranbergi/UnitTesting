using System.Collections.Generic;

namespace UnitTestDataMock.Repo
{
    public interface IStudent
    {
        List<Student> DalGetStudents();
        Student DalGetStudentById(int StudentId);
        int DalAddStudent(Student obj);
        int DalUpdateStudent(Student obj);
        int DalDeleteStudent(int StudentId);
    }
}
