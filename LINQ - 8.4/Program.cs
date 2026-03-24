using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// TODO:
// 1. Create a list of integers.
var num = new List<int> {1,2,3,4,5,6,7,8,9 };
// 2. Group them by "Even" and "Odd" with GroupBy.
var grouped = num.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
// 3. Loop through each group.
// 4. Print the group label and the numbers in that group.
// TODO: print each group here
foreach (var group in grouped)
{
    Console.WriteLine(group.Key + ": " + string.Join(", ", group));
}