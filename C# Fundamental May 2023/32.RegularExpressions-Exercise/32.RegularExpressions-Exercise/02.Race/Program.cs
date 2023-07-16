using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] raceParticipants = Console.ReadLine()
                .Split(", ");
            List<Participant> participants = new List<Participant>();
            for (int i = 0; i < raceParticipants.Length; i++)
            {
                Participant currentParticipant = new Participant();
                currentParticipant.Name = raceParticipants[i];
                participants.Add(currentParticipant);
            }

            string regexParticipantName = @"[A-Za-z]";
            string regexParticipantDistance = @"\d";
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection participantName = Regex.Matches(input, regexParticipantName);
                MatchCollection participantDistance = Regex.Matches(input, regexParticipantDistance);
                StringBuilder nameFromInput = new StringBuilder();
                foreach (Match nameCharacter in participantName)
                {
                    nameFromInput.Append(nameCharacter.Value);
                }

                uint totalDistance = 0;
                foreach (Match distanceCharacter in participantDistance)
                {
                    totalDistance += uint.Parse(distanceCharacter.Value);
                }

                Participant foundParticipant = participants.FirstOrDefault(x => x.Name == nameFromInput.ToString());
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += totalDistance;
                }
            }
            List<Participant> orderedParticipant = participants
                .OrderByDescending(x => x.Distance)
                .Take(3)
                .ToList();

            Console.WriteLine($"1st place: {orderedParticipant[0].Name}\n2nd place: {orderedParticipant[1].Name}\n3rd place: {orderedParticipant[2].Name}");
        }
    }
    public class Participant
    {
        public string Name { get; set; }

        public uint Distance { get; set; }
    }
}