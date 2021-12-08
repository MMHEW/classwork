using Microsoft.AspNetCore.Mvc;
using ClassChallengeDEC08.Models;
using System.Collections.Generic;
namespace ClassChallengeDEC08.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            

            List<Friend> friends = new List<Friend>();

            Friend friend1 = new Friend(1, "Jake", "North Carolina");
            Friend friend2 = new Friend(2, "Joe", "Wisconsin");
            Friend friend3 = new Friend(3, "Leon", "Mexico");

            friends.Add(friend1);
            friends.Add(friend2);
            friends.Add(friend3);

            FriendsList friendsList = new FriendsList();

            friendsList.Friends = friends;

            return View(friendsList);
        }
    }
}
