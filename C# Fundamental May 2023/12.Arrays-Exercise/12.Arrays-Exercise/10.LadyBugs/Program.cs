namespace _10.LadyBugs
/*  
5
0 1 4
0 right 1
end
*/



{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] fieldSizeArray = new int[fieldSize];
            int[] ladybugsStartPosition = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < ladybugsStartPosition.Length; i++)
            {
                if (ladybugsStartPosition[i] < fieldSizeArray.Length && ladybugsStartPosition[i] >= 0)
                fieldSizeArray[ladybugsStartPosition[i]] = 1;
            }

            string ladybugMovement = Console.ReadLine();
            while (ladybugMovement != "end")
            {
                string[] ladybugMovementArray = ladybugMovement
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int ladybugLocation = int.Parse(ladybugMovementArray[0]);
                string ladybugDirection = ladybugMovementArray[1];
                int ladybugMovementSpaces = int.Parse(ladybugMovementArray[2]);


                if (ladybugLocation < fieldSizeArray.Length && ladybugLocation >= 0 && fieldSizeArray[ladybugLocation] == 1 && ladybugDirection == "right")
                {
                    fieldSizeArray[ladybugLocation] = 0;

                    if ((ladybugLocation + ladybugMovementSpaces) >= fieldSizeArray.Length || (ladybugLocation + ladybugMovementSpaces) < 0)
                    {
                        ladybugMovement = Console.ReadLine();
                        continue;
                    }
                    bool outOfRangeRight = false;
                    while (!outOfRangeRight && fieldSizeArray[ladybugLocation + ladybugMovementSpaces] == 1)
                    {
                        ladybugLocation += ladybugMovementSpaces;
                        if ((ladybugLocation + ladybugMovementSpaces) >= fieldSizeArray.Length || (ladybugLocation + ladybugMovementSpaces) < 0)
                        {
                            ladybugMovement = Console.ReadLine();
                            outOfRangeRight = true;
                        }
                    }
                    if (!outOfRangeRight)
                    {
                        fieldSizeArray[ladybugLocation + ladybugMovementSpaces] = 1;
                        ladybugMovement = Console.ReadLine();
                    }
                }
                else if (ladybugLocation < fieldSizeArray.Length && ladybugLocation >= 0 && fieldSizeArray[ladybugLocation] == 1 && ladybugDirection == "left")
                {
                    fieldSizeArray[ladybugLocation] = 0;

                    if ((ladybugLocation - ladybugMovementSpaces) >= fieldSizeArray.Length || (ladybugLocation - ladybugMovementSpaces) < 0)
                    {
                        ladybugMovement = Console.ReadLine();
                        continue;
                    }
                    bool outOfRangeLeft = false;
                    while (!outOfRangeLeft && fieldSizeArray[ladybugLocation - ladybugMovementSpaces] == 1)
                    {
                        ladybugLocation -= ladybugMovementSpaces;
                        if ((ladybugLocation - ladybugMovementSpaces) >= fieldSizeArray.Length || (ladybugLocation - ladybugMovementSpaces) < 0)
                        {
                            ladybugMovement = Console.ReadLine();
                            outOfRangeLeft = true;
                        }
                    }
                    if (!outOfRangeLeft)
                    {
                        fieldSizeArray[ladybugLocation - ladybugMovementSpaces] = 1;
                        ladybugMovement = Console.ReadLine();
                    }
                }
                else
                {
                    ladybugMovement = Console.ReadLine();
                }
            }
            Console.WriteLine(string.Join(" ", fieldSizeArray));
        }
    }
}