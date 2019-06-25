using System.Collections.Generic;
using Core.Models;

namespace Core.Repository
{
    public interface ISectionRepository : IGenericRepository<Section>
    {

        ISet<Section> GetSectionsForExam(int examId);

    }
}