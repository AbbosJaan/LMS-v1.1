using LMS.Data;
using LMS.Data.Interfaces;
using LMS.Domain;
using LMS.Service.Interfaces;
using LMS.ViewModel;

namespace LMS.Service
{
    public class GroupService : IGenericCRUDService<GroupViewModel>
    {
        private readonly IEntityBaseRepository<Group> _repository;
        public GroupService(IEntityBaseRepository<Group> repository, AppDbContext context)
        {
             _repository = repository;
        }

        public async Task<GroupViewModel> CreateAsync(GroupViewModel model)
        {
            var result = await _repository.AddAsync((Group)model);
            return (GroupViewModel)result;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GroupViewModel>> GetAllAsync()
        {
            var groups = await _repository.GetAllAsync(x => x.Users);
            var result = new List<GroupViewModel>();
            foreach (var group in groups)
            {
                result.Add((GroupViewModel)group);
            }
            return result;
        }

        public Task<GroupViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GroupViewModel> UpdateAsync(int id, GroupViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
