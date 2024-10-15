namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }

        public bool? WillAttend { get; set; }

        public string IsAttending
        {
            get
            {
                switch (WillAttend)
                {
                    case null:
                        return "Maybe";
                    case true:
                        return "Yes";
                    case false:
                        return "No";
                }
                
            }
        }
    }
}
