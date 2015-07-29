using AlfasoftExercise.DatabaseConfiguration;
using AlfasoftExercise.Models;
using AlfasoftExercise.StateModals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlfasoftExercise.Store
{
	public class UserStore
	{
		private UserStore(){}
		
		public static UserStore getInstance(){
			return new UserStore();
		}
		
		public IEnumerable<User> GetAll(int page = 1, int size = 10)
		{
			using(var ctx = new AlfasoftDBContext()){
                return ctx.Set<User>()
                    .OrderBy(u=>u.Name)
                    .Skip((page-1) * (size))
                    .Take(size)
                    .ToList();
            }
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
				if(!ctx.Users.Any(u => u.Name.Equals(newUser.Name) || u.Number == newUser.Id)){
					var user = newUser.getModel();
						
					ctx.Users.Add(user);
                    ctx.SaveChanges();
					return true;
				}
			}
			return false;
		}
		
		public bool RemoveUser(RemoveUserStateModal removeUser)
		{
			using(var ctx = new AlfasoftDBContext()){
                User user = ctx.Users.SingleOrDefault(u => u.Name.Equals(removeUser.Name));
				if(user!=null){
					ctx.Users.Remove(user);
                    ctx.SaveChanges();
                    return true;
				}
				return false;
			}
		}
	}
}