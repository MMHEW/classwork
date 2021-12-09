using Microsoft.AspNetCore.Mvc;
using ClassChallengeDEC08.Models;
using System.Collections.Generic;
using ClassChallengeDEC08.Services;

namespace ClassChallengeDEC08.Controllers
{
    public class FriendController : Controller
    {
        IFriendsList _friendsList;

        //public List<Friend> friends;

        //Inject service into Contrtoller
        public FriendController(IFriendsList friendsList)
        {
            //Dependency Injection Reference type values
            _friendsList = friendsList;            
        }

        public IActionResult Index()
        {         
            return View(_friendsList);
        }


        [HttpGet]
        public IActionResult InsertNewFriend()
        {
            
            return View();
        }

        [HttpPost]        
        public IActionResult InsertNewFriend(Friend friend)
        {
            _friendsList.Friends.Add(friend);
            
            return View();
        }
    }
}
