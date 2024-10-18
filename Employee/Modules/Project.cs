namespace EmployeeProject.Modules;

internal class Project
{
    public int id { get; set; }
    public Employee[] employees { get; set; }
    DateTime startTime { get; set; }
    DateTime deadLine { get; set; }
    bool isSuccessful { get; set; }

    public Project(int id, DateTime startTime, DateTime deadLine)
    {
        this.id = id;
        this.startTime = startTime;
        this.deadLine = deadLine;
    }

    public void AssignEmployee(Employee employee)
    {
        Employee[] newArr = new Employee[employees.Length + 1];
        for (int i = 0; i < employees.Length; i++)
        {
            newArr[i] = employees[i];
        }
        newArr[newArr.Length - 1] = employee;
        employees = newArr;
    }

    public void RemoveEmployee(Employee employee)
    {
        bool found = false;
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i].Id == employee.Id && employees[i] != null)
            {
                employees[i] = null;
                found = true;

            }
        }
        if (!found)
        {
            Console.WriteLine("Can't find the Employee that u are searching for");
            return;
        }
        Employee[] newArr = new Employee[employees.Length - 1];
        int count = 0;
        foreach (var item in employees)
        {
            if (item != null)
            {
                newArr[count] = item;
                count++;
            }
        }
    }

    public void Finish()
    {
        if (DateTime.Now < deadLine && DateTime.Now > startTime)
            isSuccessful = true;
        else
            isSuccessful = false;
    }

    public void Print()
    {
        Console.WriteLine("====================================");
        Console.WriteLine($"""
                           Id: {id}
                           StartTime: {startTime}
                           DeadLine: {deadLine}
                           IsSuccessful: {isSuccessful}
                           """);
        Console.WriteLine("Employee list:");
        if (employees[0] != null)
            Console.WriteLine("----------------------");
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i] != null)
            {
                Console.WriteLine("Id: " + employees[i].Id);
                Console.WriteLine("FullName: " + employees[i].Fullname);
                Console.WriteLine("----------------------");
            }
        }
        Console.WriteLine("====================================");
    }
}
