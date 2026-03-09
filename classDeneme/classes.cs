

class Student
{
    public String FirstName;
    public String LastName;
    public long IDNumber;
    public String Gender;
    public DateTime DateOfBirth;
    public DateTime YearOfEnrollment;
    public String Faculty;
    public String Department;
    public String StudentID;



    public Student(String firstName, String lastName, long iDNumber, String gender, DateTime dateOfBirth, DateTime yearOfEnrollment, String faculty, String department, String studentID)
    {
        FirstName = firstName;
        LastName = lastName;
        IDNumber = iDNumber;
        Gender  = gender;
        DateOfBirth = dateOfBirth;
        YearOfEnrollment = yearOfEnrollment;
        Faculty = faculty;
        Department = department;
        StudentID = studentID;

    }
    

}