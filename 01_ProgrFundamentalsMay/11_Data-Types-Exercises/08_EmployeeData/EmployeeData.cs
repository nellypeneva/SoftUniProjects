using System;
class EmployeeData
{
    static void Main()
    {

        string firstName = "Amanda";
        string lastName = "Jonson";
        byte age = 27;
        char gender = 'f';
        ulong idNumber = 8306112507;
        uint employeeNumber = 27563571;

        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}\n",
                            firstName, lastName, age, gender, idNumber, employeeNumber);
    }
}
