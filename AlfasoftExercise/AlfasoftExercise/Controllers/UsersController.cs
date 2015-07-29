using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AlfasoftExercise.DatabaseConfiguration;
using AlfasoftExercise.Models;
using AlfasoftExercise.Store;
using AlfasoftExercise.StateModals;

namespace AlfasoftExercise.Controllers
{
    public class UsersController : ApiController
    {

        [Route("api/users", Name = "GetUsersList")]
        [ResponseType(typeof(UserListStateModal))]
        public HttpResponseMessage GetUsers()
        {
            var store = UserStore.getInstance();
            var users = store.GetAll();
            var stateModal = new UserListStateModal(users);
            return Request.CreateResponse(stateModal);
        }

        [Route("api/users/{id}", Name = "GetUsersById")]
        [ResponseType(typeof(User))]
        public HttpResponseMessage GetUser(int id)
        {
            var store = UserStore.getInstance();
            var user = store.GetById(id);
            if (user == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var stateModal = new UserStateModal(user);
            return Request.CreateResponse(stateModal);
        }

        [Route("api/users/new", Name = "PostAddUserByName")]
        public HttpResponseMessage AddUser(NewUserStateModal newUser)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var store = UserStore.getInstance();
            var result = store.AddUser(newUser);

            if (result)
                return Request.CreateResponse(HttpStatusCode.NoContent);
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        [Route("api/users/delete", Name = "PostRemoveUserByName")]
        public HttpResponseMessage RemoveUser(RemoveUserStateModal removeUser)
        {
            var store = UserStore.getInstance();
            var result = store.RemoveUser(removeUser);
            if (result)
                return Request.CreateResponse(HttpStatusCode.NoContent);
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}