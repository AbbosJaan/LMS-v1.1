﻿using LMS.Data.Interfaces;
using LMS.Domain;
using LMS.Service.Interfaces;
using LMS.ViewModel;
using LMS.ViewModel.CreationViewModel;

namespace LMS.Service.Groups
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

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<GroupViewModel>> GetAllAsync()
        {
            var groups = await _repository.GetAllGroupsAsync();
            var result = new List<GroupViewModel>();
            foreach (var group in groups)
            {
                result.Add((GroupViewModel)group);
            }
            return result;
        }

        public async Task<GroupViewModel> GetByIdAsync(int id)
        {
            var group = await _repository.GetByIdAsync(id);
            return (GroupViewModel)group;
        }

        public Task<GroupCreationViewModel> GetByIdForCreation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(int id, GroupCreationViewModel model) => await _repository.UpdateGroupAsync(id, (Group)model);
      
    }
}
