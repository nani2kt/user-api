using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Demo.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly EmployeeContext context;

        public UserRepository(EmployeeContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetUser(int Id)
        {
            return await context.Users
                .FirstOrDefaultAsync(e => e.Id == Id);//method syntax
        }

        public async Task<User> AddUser(User user)
        {
            var result = await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return result.Entity;
        }


    }
}
