using System;
using System.Reflection;


[AttributeUsage(AttributeTargets.Method, Inherited = false)]
class TaskInfoAttribute : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}


class TaskManager
{
    [TaskInfo(1, "Completing Assignment")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

public class Test3
{
    public static void Print()
    {
        // Use Reflection to retrieve the attribute details
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("CompleteTask");

        if (method != null)
        {
            var attributes = method.GetCustomAttributes(typeof(TaskInfoAttribute), false);
            foreach (TaskInfoAttribute attr in attributes)
            {
                Console.WriteLine($"Task Info -> Priority: {attr.Priority}, Assigned To: {attr.AssignedTo}");
            }
        }


        TaskManager taskManager = new TaskManager();
        taskManager.CompleteTask();
    }
}
