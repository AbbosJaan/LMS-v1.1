

using LMS.Domain;

namespace LMS.ViewModel.CreationViewModel
{
    public class GroupCreationViewModel
    {
        public string Name { get; set; }
        public static explicit operator Group(GroupCreationViewModel viewModel)
        {
            return new Group
            {
                Name = viewModel.Name,
            };
        }
    }
}
