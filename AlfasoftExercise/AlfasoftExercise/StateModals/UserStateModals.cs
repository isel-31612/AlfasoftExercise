using AlfasoftExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlfasoftExercise.StateModals
{
	//Response of a User Representation
	public class UserStateModal
	{
        public UserStateModal(User user)
        {
            Id = user.Number;
            Name = user.Name;
            Password = user.Password;
        }

        public int Id;
		public String Name;
		public String Password;
	}
	
	//Response of a List of Users
	public class UserListStateModal
	{
        public UserListStateModal(IEnumerable<User> users)
        {
            usersStateModal = users.Select(u => new UserStateModal(u));
        }
        public IEnumerable<UserStateModal> usersStateModal;
	}
	
	//Client input of a new User
	public class NewUserStateModal : IStateModalsConverter<User>
	{
        public NewUserStateModal(){}
        public int Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }

        public User getModel(){
			return new User(Id,Name,Password);
		}
	}

    public class RemoveUserStateModal
    {
        public RemoveUserStateModal() { }
        public String Name { get; set; }
    }
}