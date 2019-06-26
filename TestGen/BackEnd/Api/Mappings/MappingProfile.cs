using Api.ViewModels;
using AutoMapper;
using Core.Models;

namespace Api.Mappings
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<Exam, ExamResponse>();
            CreateMap<Section, SectionResponse>();
            CreateMap<Question, QuestionResponse>();

            CreateMap<ExamRequest, Exam>();
            CreateMap<SectionRequest, Section>();
        }
    }
}