namespace ClassChallengeDEC08.Models
{
    public class Friend
    {
       
        public int _friendID { get; set; }

        public string _friendName { get; set; }

        public string _place { get; set; }

        public Friend(int friendID, string friendName, string place)
        {
            _friendID = friendID;
            _friendName = friendName;
            _place = place;
        }
    }
}
