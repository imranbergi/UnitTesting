using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDataMock
{
    public class Data
    {
        public List<Student> DummyData;
        public Data()
        {
             DummyData = new List<Student>()
             {
                new Student()
                {
                    StudentId = 1,
                    FirstName = "Hissan",
                    LastName = "Rouf",
                    Gender = "Male",
                    Age = 14,
                    Address = "India",
                    ContactNo = "9796725797"
                },
                new Student()
                {
                    StudentId = 2,
                        FirstName = "Abban",
                        LastName = "Rouf",
                        Gender = "Male",
                        Age = 13,
                        Address = "India",
                        ContactNo = "9796725797"
                },
                new Student()
                {
                    StudentId = 3,
                        FirstName = "Baiza",
                        LastName = "Rouf",
                        Gender = "Female",
                        Age = 11,
                        Address = "India",
                        ContactNo = "9796725797"
                },
                new Student()
                {
                    StudentId = 4,
                        FirstName = "Mohammad",
                        LastName = "Sibgatullah",
                        Gender = "Male",
                        Age = 11,
                        Address = "India",
                        ContactNo = "9796725797"
                },
                new Student()
                {
                    StudentId = 5,
                        FirstName = "Mohammad",
                        LastName = "Aahil",
                        Gender = "Male",
                        Age = 13,
                        Address = "India",
                        ContactNo = "9796725797"
                },
                new Student()
                {
                    StudentId = 6,
                        FirstName = "Khadija",
                        LastName = "Imran",
                        Gender = "Female",
                        Age = 8,
                        Address = "Canada",
                        ContactNo = "4372198194"
                 }
             };
        }
        public int Add(Student obj)
        {
            try
            {
                DummyData.Add(obj);
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public int Update(Student obj)
        {
            try
            {
                DummyData.Find(x=>x.StudentId == obj.StudentId).FirstName = obj.FirstName;
                DummyData.Find(x => x.StudentId == obj.StudentId).LastName = obj.LastName;
                DummyData.Find(x => x.StudentId == obj.StudentId).Age = obj.Age;
                DummyData.Find(x => x.StudentId == obj.StudentId).Gender = obj.Gender;
                DummyData.Find(x => x.StudentId == obj.StudentId).Address = obj.Address;
                DummyData.Find(x => x.StudentId == obj.StudentId).ContactNo = obj.ContactNo;
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public Student Get(int StudentId)
        {
            return DummyData.FirstOrDefault(x => x.StudentId == StudentId);
        }
        public List<Student> GellAll()
        {
            return DummyData;
        }
        public int Delete(int StudentId)
        {
            try
            {
                DummyData.Remove(DummyData.Find(x => x.StudentId == StudentId));
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
    }
    

