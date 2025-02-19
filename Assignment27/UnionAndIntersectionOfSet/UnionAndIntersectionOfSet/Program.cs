using System;
using System.Collections.Generic;

class SetOperations
{
    static HashSet<int> GetUnion(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);
        return unionSet;
    }

    static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2);
        return intersectionSet;
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> unionResult = GetUnion(set1, set2);
        HashSet<int> intersectionResult = GetIntersection(set1, set2);

        Console.WriteLine("Union: " + string.Join(", ", unionResult));
        Console.WriteLine("Intersection: " + string.Join(", ", intersectionResult));
    }
}
