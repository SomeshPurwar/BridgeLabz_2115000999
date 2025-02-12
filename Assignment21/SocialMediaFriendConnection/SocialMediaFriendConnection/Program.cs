using System;
namespace SocialMediaFriendConnection
{
    class User
    {
        public string UserID;
        public string Name;
        public int Age;
        public List<string> FriendIDs;
        public User Next;

        public User(string userID, string name, int age)
        {
            UserID = userID;
            Name = name;
            Age = age;
            FriendIDs = new List<string>();
            Next = null;
        }
    }

    class SocialMedia
    {
        private User head;

        public void AddUser(string userID, string name, int age)
        {
            User newUser = new User(userID, name, age);
            newUser.Next = head;
            head = newUser;
        }

        public void AddFriend(string userID1, string userID2)
        {
            User user1 = FindUser(userID1);
            User user2 = FindUser(userID2);
            if (user1 != null && user2 != null && !user1.FriendIDs.Contains(userID2))
            {
                user1.FriendIDs.Add(userID2);
                user2.FriendIDs.Add(userID1);
                Console.WriteLine("Friend connection added.");
            }
            else
            {
                Console.WriteLine("Friend connection could not be added.");
            }
        }

        public void RemoveFriend(string userID1, string userID2)
        {
            User user1 = FindUser(userID1);
            User user2 = FindUser(userID2);
            if (user1 != null && user2 != null)
            {
                user1.FriendIDs.Remove(userID2);
                user2.FriendIDs.Remove(userID1);
                Console.WriteLine("Friend connection removed.");
            }
            else
            {
                Console.WriteLine("Friend connection could not be removed.");
            }
        }

        public void DisplayFriends(string userID)
        {
            User user = FindUser(userID);
            if (user != null)
            {
                Console.WriteLine($"Friends of {user.Name}:");
                foreach (var friendID in user.FriendIDs)
                {
                    User friend = FindUser(friendID);
                    if (friend != null)
                        Console.WriteLine(friend.Name);
                }
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void FindMutualFriends(string userID1, string userID2)
        {
            User user1 = FindUser(userID1);
            User user2 = FindUser(userID2);
            if (user1 != null && user2 != null)
            {
                List<string> mutualFriends = new List<string>();
                foreach (string friendID in user1.FriendIDs)
                {
                    if (user2.FriendIDs.Contains(friendID))
                    {
                        mutualFriends.Add(friendID);
                    }
                }

                Console.WriteLine("Mutual Friends:");
                foreach (var friendID in mutualFriends)
                {
                    User friend = FindUser(friendID);
                    if (friend != null)
                        Console.WriteLine(friend.Name);
                }
            }
            else
            {
                Console.WriteLine("One or both users not found.");
            }
        }

        public void SearchUser(string identifier)
        {
            User temp = head;
            while (temp != null)
            {
                if (temp.UserID == identifier || temp.Name.Equals(identifier, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"User Found: {temp.Name}, Age: {temp.Age}, ID: {temp.UserID}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("User not found.");
        }

        public void CountFriends(string userID)
        {
            User user = FindUser(userID);
            if (user != null)
            {
                Console.WriteLine($"{user.Name} has {user.FriendIDs.Count} friends.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        private User FindUser(string userID)
        {
            User temp = head;
            while (temp != null)
            {
                if (temp.UserID == userID)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }
    }

    class Program
    {
        static void Main()
        {
            SocialMedia socialMedia = new SocialMedia();
            socialMedia.AddUser("1", "Somesh", 25);
            socialMedia.AddUser("2", "Shubham", 27);
            socialMedia.AddUser("3", "Vaibhav", 22);
            socialMedia.AddUser("4", "Shivam", 24);

            socialMedia.AddFriend("1", "2");
            socialMedia.AddFriend("1", "3");
            socialMedia.AddFriend("2", "3");
            socialMedia.AddFriend("2", "4");

            socialMedia.DisplayFriends("1");
            socialMedia.CountFriends("1");

            Console.WriteLine("Finding mutual friends between Somesh and Shubham:");
            socialMedia.FindMutualFriends("1", "2");

            socialMedia.RemoveFriend("1", "2");
            socialMedia.DisplayFriends("1");
        }
    }

}