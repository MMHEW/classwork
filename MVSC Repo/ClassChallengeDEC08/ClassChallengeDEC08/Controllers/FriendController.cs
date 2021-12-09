using Microsoft.AspNetCore.Mvc;
using ClassChallengeDEC08.Models;
using System.Collections.Generic;
using ClassChallengeDEC08.Services;

namespace ClassChallengeDEC08.Controllers
{
    public class FriendController : Controller
    {
        //initializes the dependency injection of FriendsList
        IFriendsList _friendsList;

        //public List<Friend> friends;

        //Inject service into Contrtoller
        public FriendController(IFriendsList friendsList)
        {
            //Dependency Injection Reference type values
            //See Startup.CS to see where we initialized the dependency injection
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
        //CREATE FRIENDS
        [HttpPost]        
        public IActionResult InsertNewFriend(Friend friend)
        {
            //checks to see if validators are happy, if they are will go back to Index page.
            if (ModelState.IsValid)
            {
                
                _friendsList.Friends.Add(friend);
                return RedirectToAction("Index");
            }
            
            
            return View();
        }
    }
}
