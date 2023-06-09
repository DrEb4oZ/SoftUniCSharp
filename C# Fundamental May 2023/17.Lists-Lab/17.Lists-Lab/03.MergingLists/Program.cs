namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> mergedLists = new List<int>();
            if (firstList.Count >= secondList.Count)
            {
                mergedLists = MergeTwoLists(firstList, secondList, secondList.Count);
            }

            else
            {
                mergedLists = MergeTwoLists(firstList, secondList, firstList.Count);
            }

            Console.WriteLine(string.Join(" ", mergedLists));
        }

        static List<int> MergeTwoLists(List<int> firstListToMerge, List<int> secondListToMerge, int loopLength)
        {
            List<int> mergedList = new List<int>();
            for (int i = 0; i < loopLength; i++)
            {
                mergedList.Add(firstListToMerge[i]);
                mergedList.Add(secondListToMerge[i]);
            }

            GetRemaningPartOfList(firstListToMerge, secondListToMerge, loopLength, mergedList);

            return mergedList;
        }

        private static void GetRemaningPartOfList(List<int> firstListToMerge, List<int> secondListToMerge, int loopLength, List<int> mergedList)
        {
            if (firstListToMerge.Count >= secondListToMerge.Count)
            {
                firstListToMerge.RemoveRange(0, loopLength);
                mergedList.AddRange(firstListToMerge);
            }

            else
            {
                secondListToMerge.RemoveRange(0, loopLength);
                mergedList.AddRange(secondListToMerge);
            }
        }
    }
}