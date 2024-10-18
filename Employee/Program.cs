using EmployeeProject.Modules;

namespace EmployeeProject;

internal class Program
{
    static void Main()
    {
        Project MyProject1 = new Project(1, DateTime.Today.AddDays(-1), DateTime.Today.AddDays(1));
        Project MyProject2 = new Project(2, DateTime.Today.AddDays(-2), DateTime.Today.AddDays(2));

        Employee NewEmployee1 = new Employee(1, "NewEmployee1");
        Employee NewEmployee2 = new Employee(2, "NewEmployee2");
        Employee NewEmployee3 = new Employee(3, "NewEmployee3");

        Project[] projects = { MyProject1, MyProject2 };
        Employee[] employees = { NewEmployee1, NewEmployee2 };

        MyProject1.employees = employees;
        MyProject2.employees = employees;
        NewEmployee1.Projects = projects;
        NewEmployee2.Projects = projects;

        MyProject1.Print();
        MyProject1.RemoveEmployee(NewEmployee3);
        MyProject1.Print();
        MyProject1.AssignEmployee(NewEmployee3);
        MyProject1.Print();
        MyProject1.Finish();
        NewEmployee1.Leave(MyProject1);
        MyProject1.Print();
    }
}
