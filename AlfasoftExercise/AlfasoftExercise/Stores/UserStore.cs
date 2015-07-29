using System;

namespace AlfasoftExercise.Store
{
	public class UserStore
	{
		private UserStore(){}
		
		private UserStore getInstance(){
			return new UserStore();
		}
		
		public IEnumerable<User> GetAll(int page = 1, int size = 10)
		{
			IEnumerable<User> users = null;
			using(var ctx = new AlfasoftDBContext()){
				users = ctx.Users;//Check if object doesnt need a "get"
			}
				
			return users
					.Skip(size * (page - 1))
					.Take(size);
		}

		public User GetById(int userId)
		{
			using(var ctx = new AlfasoftDBContext()){
				return ctx.Users.SingleOrDefault(u=>u.Number == userId);
			}
		}

		public bool AddUser(NewUserStateModal newUser)
		{
			using(var ctx = new AlfasoftDBContext()){
				if(!Name.exists && !ID.exists){
					var user = newUser.getModel();
						
					ctx.Users.Add(user);
					return true;
				}
			}
			return false;
		}
		
		public bool RemoveUser(String name)
		{
			using(var ctx = new AlfasoftDBContext()){
				User user = ctx.Users.SingleOrDefault(u=>u.Name.equals(name))
				if(user!=null){
					ctx.Users.Remove(user);
					return true;
				}
				return false;
			}
		}
	}
}