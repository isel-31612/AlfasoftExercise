using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlfasoftExercise.StateModals
{
	//Response of a User Representation
	public class UserStateModal
	{
		public int Id;
		public String Name;
		public String Password;
	}
	
	//Response of a List of Users
	public class UserListStateModal
	{
		public IEnumerable<UserStateModal> users;0
	}
	
	//Client input of a new User
	public class NewUserStateModal : IStateModalsConverter<User>
	{
		public int Id;
		public String Name;
		public String Password;
		
		public User getModel(){
			return new User(Id,Name,Password);
		}
	}
}