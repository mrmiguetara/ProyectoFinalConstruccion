using System.Collections.Generic;
using System.Linq;
using Core.Models;
using Core.Repository;

namespace Core.Managers
{
    public class SectionManager
    {
        private readonly ISectionRepository _sectionRepository;

        public SectionManager(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public ISet<Section> GetSectionsForExam(int examId)
        {
            var sections = _sectionRepository.GetSectionsForExam(examId);

            return sections;
        }
    }
}