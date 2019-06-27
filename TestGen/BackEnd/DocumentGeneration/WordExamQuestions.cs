using System;
using System.Collections.Generic;
using System.Linq;
using Core.Models;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using Newtonsoft.Json;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace DocumentGeneration
{
    public class WordExamQuestions
    {
        public List<Question> questions { get; private set; }

        private Dictionary<int, Func<Question, int, List<Paragraph>>> functions;

        public WordExamQuestions(List<Question> questions)
        {
            this.questions = questions;
            
            functions = new Dictionary<int, Func<Question, int, List<Paragraph>>>
            {
                {1, TrueOrFalseQuestion},
                {2, MultipleChoiceQuestion},
                {3, MultipleChoiceQuestion},
                {4, OpenEndedAnswerQuestions}
            };
        }

        public Paragraph[] GetQuestionsParagraph()
        {
            var paragraphs = new List<Paragraph>();

            int counter = 1;
            foreach (var question in questions)
            {
                paragraphs.AddRange(functions[question.QuestionTypeId](question, counter++));
            }
            
            
            return paragraphs.ToArray();
        }

        private List<Paragraph> testRun(Question question, int number)
        {
            var run = new Run();

            var text = new Text($"{number}. {question.Title}");
            
            run.AppendChild(text);

            return new List<Paragraph>{new Paragraph(run)};
        }

        private List<Paragraph> TrueOrFalseQuestion(Question question, int number)
        {
            var paragraphs = new List<Paragraph>();
            var run = new Run();
            var text = new Text($"    {number}. {question.Title}. _______");
            text.Space = SpaceProcessingModeValues.Preserve;
            run.Append(text);
            
            paragraphs.Add(new Paragraph(run));
            paragraphs.Add(new Paragraph(new Run(new Text(""))));

            return paragraphs;
        }
        
        private List<Paragraph> MultipleChoiceQuestion(Question question, int number)
        {
            var paragraphs = new List<Paragraph>();
            
            var json = question.Options;
            var options = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            var run = new Run();

            var iconIfMultiple = question.QuestionTypeId == 4 ? "*" : "";
            var text = new Text($"    {number}. {question.Title}. {iconIfMultiple}");
            text.Space = SpaceProcessingModeValues.Preserve;
            run.Append(text);
            
            paragraphs.Add(new Paragraph(run));
            
            foreach (var option in options)
            {
                var optionText = new Text($"      {option.Key} - {option.Value}");
                optionText.Space = SpaceProcessingModeValues.Preserve;
                paragraphs.Add(new Paragraph(new Run(optionText)));
            }
            
            paragraphs.Add(new Paragraph(new Run(new Text(""))));    

            return paragraphs;
        }

        private List<Paragraph> OpenEndedAnswerQuestions(Question question, int number)
        {
            var paragraphs = new List<Paragraph>();
            var run = new Run();

            var text = new Text($"    {number}. {question.Title}. ");
            text.Space = SpaceProcessingModeValues.Preserve;
            
            run.Append(text);
            paragraphs.Add(new Paragraph(run));
            paragraphs.Add(new Paragraph(new Run(new Break())));
            paragraphs.Add(new Paragraph(new Run(new Break())));

            return paragraphs;
        }
        
        
    }
}