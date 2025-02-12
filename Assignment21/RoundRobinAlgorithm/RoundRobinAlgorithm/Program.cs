using System;
namespace RoundRobinAlgorithm
{
    class Process
    {
        public int PID;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;
        public Process Next;

        public Process(int pid, int burstTime, int priority)
        {
            PID = pid;
            BurstTime = burstTime;
            RemainingTime = burstTime;
            Priority = priority;
            Next = null;
        }
    }

    class CircularLinkedList
    {
        private Process head = null;

        public void AddProcess(int pid, int burstTime, int priority)
        {
            Process newProcess = new Process(pid, burstTime, priority);
            if (head == null)
            {
                head = newProcess;
                head.Next = head;
            }
            else
            {
                Process temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                temp.Next = newProcess;
                newProcess.Next = head;
            }
        }

        public void RemoveProcess(int pid)
        {
            if (head == null)
                return;

            Process temp = head, prev = null;

            if (head.PID == pid)
            {
                if (head.Next == head)
                {
                    head = null;
                    return;
                }

                Process last = head;
                while (last.Next != head)
                    last = last.Next;
                head = head.Next;
                last.Next = head;
                return;
            }

            do
            {
                prev = temp;
                temp = temp.Next;
            } while (temp != head && temp.PID != pid);

            if (temp.PID == pid)
            {
                prev.Next = temp.Next;
            }
        }

        public void RoundRobinScheduling(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("No processes to schedule.");
                return;
            }

            int time = 0;
            Process temp = head;
            int totalProcesses = 0;
            int totalWaitingTime = 0, totalTurnaroundTime = 0;

            do
            {
                totalProcesses++;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("\nRound Robin Scheduling (Time Quantum = " + timeQuantum + ")");
            while (head != null)
            {
                temp = head;
                do
                {
                    if (temp.RemainingTime > 0)
                    {
                        int executionTime = Math.Min(timeQuantum, temp.RemainingTime);
                        time += executionTime;
                        temp.RemainingTime -= executionTime;

                        if (temp.RemainingTime == 0)
                        {
                            int turnaroundTime = time;
                            int waitingTime = turnaroundTime - temp.BurstTime;
                            totalTurnaroundTime += turnaroundTime;
                            totalWaitingTime += waitingTime;
                            Console.WriteLine($"Process {temp.PID} completed. Turnaround Time: {turnaroundTime}, Waiting Time: {waitingTime}");
                            RemoveProcess(temp.PID);
                        }
                    }
                    temp = temp.Next;
                } while (temp != head);
            }

            Console.WriteLine($"\nAverage Waiting Time: {(double)totalWaitingTime / totalProcesses}");
            Console.WriteLine($"Average Turnaround Time: {(double)totalTurnaroundTime / totalProcesses}");
        }

        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("No processes available.");
                return;
            }

            Process temp = head;
            Console.WriteLine("\nProcesses in Queue:");
            do
            {
                Console.WriteLine($"PID: {temp.PID}, Burst Time: {temp.BurstTime}, Remaining Time: {temp.RemainingTime}, Priority: {temp.Priority}");
                temp = temp.Next;
            } while (temp != head);
        }
    }

    class Program
    {
        static void Main()
        {
            CircularLinkedList scheduler = new CircularLinkedList();

            scheduler.AddProcess(1, 10, 2);
            scheduler.AddProcess(2, 5, 1);
            scheduler.AddProcess(3, 8, 3);
            scheduler.AddProcess(4, 6, 2);

            scheduler.DisplayProcesses();

            scheduler.RoundRobinScheduling(4);
        }
    }

}
