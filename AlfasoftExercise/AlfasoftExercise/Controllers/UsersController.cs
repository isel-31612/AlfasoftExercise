using System.Net;
using System.Net.Http;
using System.Web.Http;
using AlfasoftExercise.Store;
using AlfasoftExercise.StateModals;
using AlfasoftExercise.Utils;

namespace AlfasoftExercise.Controllers
{
    public class UsersController : ApiController
    {
        //API
        [Route(ResourceStrings.UserList, Name = "GetUsersList")]
        public HttpResponseMessage GetUsers()
        {
            var store = UserStore.getInstance();
            var users = store.GetAll();
            var stateModal = new UserListStateModal(users);
            return Request.CreateResponse(stateModal);
        }

        [Route(ResourceStrings.AddUser, Name = "PostAddUserByName")]
        public HttpResponseMessage AddUser(NewUserStateModal newUser)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var store = UserStore.getInstance();
            var user = store.AddUser(newUser);

            if (user!=null)
                return Request.CreateResponse(new UserStateModal(user));
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        [Route(ResourceStrings.RemoveUser, Name = "PostRemoveUserByName")]
        public HttpResponseMessage RemoveUser(RemoveUserStateModal removeUser)
        {
            var store = UserStore.getInstance();
            var user = store.RemoveUser(removeUser);
            if (user != null)
                return Request.CreateResponse(new UserStateModal(user));
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}