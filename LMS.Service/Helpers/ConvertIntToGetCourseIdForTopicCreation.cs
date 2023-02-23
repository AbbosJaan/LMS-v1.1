namespace LMS.Service.Helpers
{
    public class ConvertIntToGetCourseIdForTopicCreation
    {
        public GetCourseIdForTopicCreation Convertor(int id)
        {
            return new GetCourseIdForTopicCreation
            {
                Id = id
            };
        }
    }
}
