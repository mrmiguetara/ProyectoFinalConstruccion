using System;
using System.Collections.Generic;
using System.Linq;
using Core.Helpers;
using Core.Models;
using Core.Repository;

namespace Core.Managers
{
    public class SectionManager
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly QuestionManager _questionManager;

        public SectionManager(
            ISectionRepository sectionRepository, 
            QuestionManager questionManager)
        {
            _sectionRepository = sectionRepository;
            _questionManager = questionManager;
        }

        public ISet<Section> GetSectionsForExam(int examId)
        {
            var sections = _sectionRepository.GetSectionsForExam(examId);

            return sections;
        }


        public void AddSection(Section section)
        {
            _sectionRepository.Create(section);
            
            _sectionRepository.Save();
        }

        public Section GetSingleSection(int id, bool questionsIncluded = true)
        {
            
            var section = _sectionRepository.Find(id);

            if (questionsIncluded)
            {
                section.Questions = _questionManager.GetQuestionsForSection(section.Id);
            }

            return section;
        }

        public Section UpdateSection(Section section)
        {
            var trackedSection = _sectionRepository.Find(section.Id);
            
            PropertyCopier<Section, Section>.Copy(section, trackedSection);
            
            trackedSection.Updated = DateTime.Now;

            trackedSection.Questions = _questionManager.GetQuestionsForSection(section.Id);

            _sectionRepository.Update(trackedSection);
            
            _sectionRepository.Save();

            return trackedSection;

        }
        
        public Section DeleteSection(int id)
        {
            var section = _sectionRepository.Find(id);

            _sectionRepository.Delete(section.Id);
            
            _sectionRepository.Save();

            return section;
        }

        public ISet<Section> DeleteAllSectionsForExam(int examId)
        {
            var sections = _sectionRepository.GetSectionsForExam(examId);
            if (sections.Any(section => HasQuestions(section.Id)))
            {
                return null;
            }
            
            _sectionRepository.DeleteSectionsForExam(examId);
            
            _sectionRepository.Save();

            return sections.ToHashSet();

        }

        public bool HasQuestions(int id)
        {
            return _questionManager.GetQuestionsForSection(id).Count > 0;
        }
    }
}