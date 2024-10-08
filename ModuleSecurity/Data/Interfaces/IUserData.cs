﻿using Entity.DTO;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    internal interface IUserData
    {

        public Task Delete(int id);
        public Task<User> GetById(int id);
        public Task<IEnumerable<User>> GetAll();
        public Task<User> Save(User entity);
        public Task<User> Update(User entity);
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
    }
}
