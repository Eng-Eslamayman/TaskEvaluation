using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvaluation.Core.Interfaces.IServices
{
    public interface IGroupService
    {
        Task<GroupDTO> GetGroupByIdAsync(int id);
        Task<IEnumerable<GroupDTO>> GetAllGroupsAsync();
        Task CreateGroupAsync(GroupDTO group);
        Task UpdateGroupAsync(GroupDTO group);
        Task DeleteGroupAsync(int id);
    }
}
