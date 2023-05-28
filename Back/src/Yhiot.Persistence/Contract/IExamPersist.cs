using Yhiot.Domain;

namespace Yhiot.Persistence
{
    public interface IExamPersist
    {
        // Exam

        Task<Exam[]> GetAllExamByNameAsync(string name);
        Task<Exam[]> GetAllExamAsync(string tema);
        Task<Exam> GetAllExamById(int userId);
        
    }
}