namespace PartyInvites.Models;

public class Repository
{
    //NEVER DO THIS
    //This is only for academic/demostration
    
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses() => responses;
        

        public static void AddResponse(GuestResponse response) {  
            responses.Add(response); 
        }
    }

