using System;
using System.Collections.Generic;

class Policy : IComparable<Policy>
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override bool Equals(object obj)
    {
        return obj is Policy policy && PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public int CompareTo(Policy other)
    {
        return ExpiryDate.CompareTo(other.ExpiryDate);
    }

    public override string ToString()
    {
        return $"PolicyNumber: {PolicyNumber}, Coverage: {CoverageType}, Expiry: {ExpiryDate.ToShortDateString()}";
    }
}

class InsurancePolicySystem
{
    private HashSet<Policy> policySet = new HashSet<Policy>(); // Fast lookups
    private LinkedList<Policy> policyList = new LinkedList<Policy>(); // Maintain insertion order
    private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(); // Sorted by expiry date
    private Dictionary<string, int> policyCount = new Dictionary<string, int>(); // Duplicate tracking

    public void AddPolicy(Policy policy)
    {
        if (!policySet.Contains(policy))
        {
            policySet.Add(policy);
            policyList.AddLast(policy);
            sortedPolicies.Add(policy);
            policyCount[policy.PolicyNumber] = 1;
        }
        else
        {
            policyCount[policy.PolicyNumber]++;
        }
    }

    public List<Policy> GetAllUniquePolicies()
    {
        return new List<Policy>(policySet);
    }

    public List<Policy> GetPoliciesExpiringSoon()
    {
        DateTime today = DateTime.Today;
        DateTime cutoff = today.AddDays(30);
        List<Policy> expiringSoon = new List<Policy>();

        foreach (var policy in sortedPolicies)
        {
            if (policy.ExpiryDate <= cutoff)
            {
                expiringSoon.Add(policy);
            }
        }

        return expiringSoon;
    }

    public List<Policy> GetPoliciesByCoverage(string coverageType)
    {
        List<Policy> result = new List<Policy>();

        foreach (var policy in policySet)
        {
            if (policy.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(policy);
            }
        }

        return result;
    }

    public List<Policy> GetDuplicatePolicies()
    {
        List<Policy> duplicates = new List<Policy>();

        foreach (var policy in policySet)
        {
            if (policyCount[policy.PolicyNumber] > 1)
            {
                duplicates.Add(policy);
            }
        }

        return duplicates;
    }
}

class Program
{
    static void Main()
    {
        InsurancePolicySystem system = new InsurancePolicySystem();

        // Adding sample policies
        system.AddPolicy(new Policy("P123", "Health", DateTime.Today.AddDays(15)));
        system.AddPolicy(new Policy("P124", "Auto", DateTime.Today.AddDays(40)));
        system.AddPolicy(new Policy("P125", "Home", DateTime.Today.AddDays(25)));
        system.AddPolicy(new Policy("P126", "Health", DateTime.Today.AddDays(5)));
        system.AddPolicy(new Policy("P123", "Health", DateTime.Today.AddDays(15))); // Duplicate

        // Retrieve and display all unique policies
        Console.WriteLine("All Unique Policies:");
        foreach (var policy in system.GetAllUniquePolicies())
        {
            Console.WriteLine(policy);
        }

        // Retrieve policies expiring soon
        Console.WriteLine("\nPolicies Expiring Soon:");
        foreach (var policy in system.GetPoliciesExpiringSoon())
        {
            Console.WriteLine(policy);
        }

        // Retrieve policies by coverage type
        Console.WriteLine("\nHealth Coverage Policies:");
        foreach (var policy in system.GetPoliciesByCoverage("Health"))
        {
            Console.WriteLine(policy);
        }

        // Retrieve duplicate policies
        Console.WriteLine("\nDuplicate Policies:");
        foreach (var policy in system.GetDuplicatePolicies())
        {
            Console.WriteLine(policy);
        }
    }
}
