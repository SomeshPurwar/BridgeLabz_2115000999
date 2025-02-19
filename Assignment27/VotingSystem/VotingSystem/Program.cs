using System;
using System.Collections.Generic;
using System.Linq;

class VotingSystem
{
    private Dictionary<string, int> votes = new Dictionary<string, int>(); // Stores votes count
    private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(); // Maintains sorted order
    private LinkedList<string> voteOrder = new LinkedList<string>(); // Maintains vote order

    // Cast a vote
    public void Vote(string candidate)
    {
        if (!votes.ContainsKey(candidate))
        {
            votes[candidate] = 0;
            sortedVotes[candidate] = 0;
        }

        votes[candidate]++;
        sortedVotes[candidate]++;
        voteOrder.AddLast(candidate);
    }

    // Get total votes per candidate
    public Dictionary<string, int> GetVoteCounts()
    {
        return new Dictionary<string, int>(votes);
    }

    // Get sorted results
    public SortedDictionary<string, int> GetSortedResults()
    {
        return new SortedDictionary<string, int>(sortedVotes);
    }

    // Get votes in the order they were cast
    public List<string> GetVoteOrder()
    {
        return voteOrder.ToList();
    }
}

class Program
{
    static void Main()
    {
        VotingSystem system = new VotingSystem();

       
        system.Vote("SP");
        system.Vote("KP");
        system.Vote("Xy");
        system.Vote("Yz");
        system.Vote("Dk");
        system.Vote("SK");

        // Display vote counts
        Console.WriteLine("Vote Counts:");
        foreach (var entry in system.GetVoteCounts())
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Display sorted results
        Console.WriteLine("\nSorted Results:");
        foreach (var entry in system.GetSortedResults())
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Display order of votes cast
        Console.WriteLine("\nVote Order:");
        foreach (var name in system.GetVoteOrder())
        {
            Console.WriteLine(name);
        }
    }
}
