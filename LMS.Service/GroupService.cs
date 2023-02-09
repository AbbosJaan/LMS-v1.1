using LMS.Data;
using LMS.Data.Interfaces;
using LMS.Domain;
using LMS.Service.Interfaces;
using LMS.ViewModel;
using LMS.ViewModel.CreationViewModel;

namespace LMS.Service
{
    public class GroupService : IGroupSerivce
    {
        private readonly IGroupBaseRepository _repository;
        public GroupService(IGroupBaseRepository repository)
        {
             _repository = repository;
        }

        public async Task<GroupViewModel> CreateAsync(GroupCreationViewModel model)
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
            var groups = await _repository.GetAllWithCourseAsync();
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
