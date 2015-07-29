using AlfasoftExercise.StateModals;
using AlfasoftExercise.Utils;
using System.Web.Mvc;

namespace AlfasoftExercise.Controllers
{
    public class ViewController : Controller
    {
        [Route(ResourceStrings.ListUserView, Name = "GetUsersList")]
        public ViewResult GetUsers()
        {
            return View("List");
        }

        [Route(ResourceStrings.AddUserView, Name = "GetAddUserByName")]
        public ViewResult AddUser()
        {
            return View("Add");
        }

        [Route(ResourceStrings.RemoveUserView, Name = "GetRemoveUserByName")]
        public ViewResult RemoveUser()
        {
            return View("Remove");
        }
    }
}
