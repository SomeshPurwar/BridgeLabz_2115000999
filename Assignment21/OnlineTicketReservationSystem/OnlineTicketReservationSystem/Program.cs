using System;
namespace OnlineTicketReservationSystem
{
    class Ticket
    {
        public int TicketID;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public DateTime BookingTime;
        public Ticket Next;

        public Ticket(int ticketID, string customerName, string movieName, string seatNumber)
        {
            TicketID = ticketID;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = DateTime.Now;
            Next = null;
        }
    }

    class CircularLinkedList
    {
        private Ticket head = null;

        public void AddTicket(int ticketID, string customerName, string movieName, string seatNumber)
        {
            Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber);

            if (head == null)
            {
                head = newTicket;
                head.Next = head;
            }
            else
            {
                Ticket temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                temp.Next = newTicket;
                newTicket.Next = head;
            }
            Console.WriteLine($"Ticket {ticketID} booked successfully for {customerName}.");
        }

        public void RemoveTicket(int ticketID)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available.");
                return;
            }

            Ticket temp = head, prev = null;

            if (head.TicketID == ticketID)
            {
                if (head.Next == head)
                {
                    head = null;
                }
                else
                {
                    Ticket last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                Console.WriteLine($"Ticket {ticketID} removed successfully.");
                return;
            }

            do
            {
                prev = temp;
                temp = temp.Next;
            } while (temp != head && temp.TicketID != ticketID);

            if (temp.TicketID == ticketID)
            {
                prev.Next = temp.Next;
                Console.WriteLine($"Ticket {ticketID} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Ticket {ticketID} not found.");
            }
        }

        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Ticket temp = head;
            Console.WriteLine("\nCurrent Booked Tickets:");
            do
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                temp = temp.Next;
            } while (temp != head);
        }

        public void SearchTicket(string query)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available.");
                return;
            }

            Ticket temp = head;
            bool found = false;
            Console.WriteLine($"\nSearch results for \"{query}\":");
            do
            {
                if (temp.CustomerName.ToLower() == query.ToLower() || temp.MovieName.ToLower() == query.ToLower())
                {
                    Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No tickets found.");
        }

        public int CountTickets()
        {
            if (head == null)
                return 0;

            int count = 0;
            Ticket temp = head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }
    }

    class Program
    {
        static void Main()
        {
            CircularLinkedList ticketSystem = new CircularLinkedList();

            ticketSystem.AddTicket(101, "Somesh", "Sanam Teri Kasam", "A1");
            ticketSystem.AddTicket(102, "Shubham", "Baby John", "B3");
            ticketSystem.AddTicket(103, "Bangali", "TMKOC", "C2");
            ticketSystem.AddTicket(104, "Krishna", "SkyForce", "D4");

            ticketSystem.DisplayTickets();

            ticketSystem.SearchTicket("Sanam Teri Kasam");
            ticketSystem.SearchTicket("TMKOC");

            Console.WriteLine($"\nTotal booked tickets: {ticketSystem.CountTickets()}");

            ticketSystem.RemoveTicket(103);

            ticketSystem.DisplayTickets();

            Console.WriteLine($"\nTotal booked tickets: {ticketSystem.CountTickets()}");
        }
    }

}