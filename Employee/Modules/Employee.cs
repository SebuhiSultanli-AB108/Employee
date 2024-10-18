namespace EmployeeProject.Modules;

internal class Employee
{
    private int _id;
    private string _fullName;
    private Project[] _projects;

    public int Id { get { return _id; } set { _id = value; } }
    public string Fullname { get { return _fullName; } set { _fullName = value; } }
    public Project[] Projects { get { return _projects; } set { _projects = value; } }

    public Employee(int id, string fullName)
    {
        Id = id;
        Fullname = fullName;
    }

    public void Leave(Project project)
    {
        int projectId = project.id;
        for (int i = 0; i < Projects.Length; i++)
        {
            Project prj = Projects[i];
            for (int j = 0; j < Projects[i].employees.Length; j++)
            {
                if (prj.employees[j] != null && prj.employees[j].Id == projectId) Projects[i].employees[i] = null;
            }
            if (Projects[i].id == projectId) Projects[i] = null;
        }
    }
}
