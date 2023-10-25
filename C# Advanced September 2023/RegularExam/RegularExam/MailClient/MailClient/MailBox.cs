using System.Security.Principal;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity { get; set; }

        public List<Mail> Inbox { get; set; }

        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (Capacity > Inbox.Count)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender) => Inbox.Remove(Inbox.FirstOrDefault(m => m.Sender == sender));

        public int ArchiveInboxMessages()
        {
            int mailsMoved = Inbox.Count;


            foreach (Mail mail in Inbox)
            {
                Archive.Add(mail);
            }

            Inbox.Clear();

            return mailsMoved;
        }

        public string GetLongestMessage() => Inbox.MaxBy(m => m.Body).ToString();

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
