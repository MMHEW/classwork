using System.Collections.Generic;
using ClassChallengeDEC08.Models;


namespace ClassChallengeDEC08.Services
{
    public interface IFriendsList
    {
        //List<Friend> Friends { get; set; }

        public Friend GetFriendById(int? id);

        public void insertNewFriend(Friend friend);

        public void DeleteFriendById(int? id);

        public void UpdateFriend(Friend friend);

        public List<Friend> GetFriends();
    }
}