using System.Data;
using System;

Console.WriteLine("Collection Expressions");

Console.WriteLine("Few of the ways collections might be created: ");

int[] arrayOne = new int[] { 1, 2, 3, 4 };
int[] emptyArrayTwo = Array.Empty<int>();
List<int> listOne = new List<int> { 1, 2, 3, 4 };

Console.Write("The new ways collection might be created: ");

int[] newArrayOne = [1, 2, 3, 4];
int[] newEmptyArrayTwo = [];
List<int> newListOnt = [1, 2, 3, 4];

int[] moreNumbers = [.. newArrayOne, 7, 8, 9];

foreach (int item in moreNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("Ended...");