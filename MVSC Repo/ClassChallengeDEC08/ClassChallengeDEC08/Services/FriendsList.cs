using System.Collections.Generic;
using ClassChallengeDEC08.Models;

namespace ClassChallengeDEC08.Services

{
    public class FriendsList : IFriendsList
    {
        public List<Friend> Friends { get; set; }

        public FriendsList()
        {
            InitializeFriendsList();

        }

        public void InitializeFriendsList()
        {

            Friends = new List<Friend>();
            Friends.Add(new Friend() { _friendID = 1, _friendName = "Jake", _place = "North Carolina" });
            Friends.Add(new Friend() { _friendID = 2, _friendName = "Joe", _place = "Wisconsin" });
            Friends.Add(new Friend() { _friendID = 3, _friendName = "Leon", _place = "Mexico" });

        }

    }
}
