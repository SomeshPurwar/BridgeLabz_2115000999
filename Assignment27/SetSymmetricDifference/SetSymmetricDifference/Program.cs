using System;
using System.Collections.Generic;

class SetOperations
{
    static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> symmetricDifference = new HashSet<int>(set1);
        symmetricDifference.SymmetricExceptWith(set2);
        return symmetricDifference;
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> symmetricDifferenceResult = GetSymmetricDifference(set1, set2);

        Console.WriteLine("Symmetric Difference: " + string.Join(", ", symmetricDifferenceResult));
    }
}
