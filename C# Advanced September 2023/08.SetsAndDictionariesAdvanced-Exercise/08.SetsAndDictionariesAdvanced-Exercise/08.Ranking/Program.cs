namespace _08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPasswordPair = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> studentContestPointsPair = new SortedDictionary<string, Dictionary<string, int>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] commandTokens = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = commandTokens[0];
                string contestPassword = commandTokens[1];
                if (!contestPasswordPair.ContainsKey(contest))
                {
                    contestPasswordPair.Add(contest, contestPassword);  // is it posible to get new password for already created contest?
                }
            }

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] commandTokens = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);  // is it posible to have invalid imput? e.g something1=>somthing2=>something3 - and missing "something4"
                string contest = commandTokens[0];
                string contestPassword = commandTokens[1];
                string student = commandTokens[2];
                int points = int.Parse(commandTokens[3]);
                if (contestPasswordPair.ContainsKey(contest) && contestPasswordPair[contest].Contains(contestPassword))
                {
                    if (!studentContestPointsPair.ContainsKey(student))
                    {
                        studentContestPointsPair.Add(student, new Dictionary<string, int>());
                    }

                    if (!studentContestPointsPair[student].ContainsKey(contest))
                    {
                        studentContestPointsPair[student].Add(contest, points);
                    }
                    else
                    {
                        if (studentContestPointsPair[student][contest] < points)
                        {
                            studentContestPointsPair[student][contest] = points;
                        }
                    }
                }
            }

            string bestStudent = string.Empty;
            int bestPoints = int.MinValue;
            foreach (KeyValuePair<string, Dictionary<string, int>> student in studentContestPointsPair)
            {
                int currentSum = 0;
                foreach (KeyValuePair<string, int> contestPoints in student.Value)
                {
                    currentSum += contestPoints.Value;
                }

                if (currentSum > bestPoints)
                {
                    bestPoints = currentSum;
                    bestStudent = student.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (KeyValuePair<string, Dictionary<string, int>> student in studentContestPointsPair)
            {
                Console.WriteLine($"{student.Key}");
                //Dictionary<string, int> orderedContest = student.Value.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (KeyValuePair<string, int> contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}