using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Entities.DTOs;
using TaskEvaluation.Core.Interfaces.IServices;

namespace TaskEvaluation.Infrastructure.Services
{
    public class GroupService : IGroupService
    {
        public Task CreateGroupAsync(GroupDTO group)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGroupAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GroupDTO>> GetAllGroupsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GroupDTO> GetGroupByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGroupAsync(GroupDTO group)
        {
            throw new NotImplementedException();
        }
    }
}
