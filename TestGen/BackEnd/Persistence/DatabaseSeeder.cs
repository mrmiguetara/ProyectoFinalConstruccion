using System.Collections;
using System.Collections.Generic;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionType>().HasData(
                new QuestionType
                {
                    Id = 1,
                    Type = "Verdadero o Falso"    
                },
                new QuestionType
                {
                    Id = 2,
                    Type = "Seleccion Multiple"    
                },
                new QuestionType
                {
                    Id = 3,
                    Type = "Seleccion Simple"    
                },
                new QuestionType
                {
                    Id = 4,
                    Type = "Completa"    
                }
            );


            modelBuilder.Entity<Exam>().HasData(
            new Exam
            {
                Id = 1,
                Subject = "Historia",
                Teacher = "Kakin",
                UserId = 1
            }
            );

            modelBuilder.Entity<Section>().HasData(
            new Section
            {
                ExamId = 1,
                Id = 1,
                Instruction = "Escriba si es verdadero o falso"
            },
            new Section
                {
                    ExamId = 1,
                    Id = 2,
                    Instruction = "Eliga la respuesta correcta"
                }
            );


            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Answer = "true",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy verdadero"
                },
                new Question
                {
                    Id = 2,
                    Answer = "true",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy verdadero"
                },
                new Question
                {
                    Id = 3,
                    Answer = "true",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy verdadero"
                },
                new Question
                {
                    Id = 4,
                    Answer = "true",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy verdadero"
                },
                new Question
                {
                    Id = 5,
                    Answer = "false",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy falso"
                },
                new Question
                {
                    Id = 6,
                    Answer = "false",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy falso"
                },
                new Question
                {
                    Id = 7,
                    Answer = "false",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy falso"
                },
                new Question
                {
                    Id = 8,
                    Answer = "true",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy verdadero"
                },
                new Question
                {
                    Id = 9,
                    Answer = "false",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy falso"
                },
                new Question
                {
                    Id = 10,
                    Answer = "true",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy verdadero"
                },
                new Question
                {
                    Id = 11,
                    Answer = "true",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy verdadero"
                },
                new Question
                {
                    Id = 12,
                    Answer = "true",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy verdadero"
                },
                new Question
                {
                    Id = 13,
                    Answer = "false",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy falso"
                },
                new Question
                {
                    Id = 14,
                    Answer = "false",
                    QuestionTypeId = 1,
                    SectionId = 1,
                    Title = "Yo soy falso"
                },
                new Question
                {
                    Answer = "a",
                    Id = 15,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "a",
                    Id = 16,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "d",
                    Id = 17,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "a",
                    Id = 18,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "b",
                    Id = 19,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "c",
                    Id = 20,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "d",
                    Id = 21,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "a",
                    Id = 22,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "b",
                    Id = 23,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "a",
                    Id = 24,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "a",
                    Id = 25,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "a",
                    Id = 26,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "d",
                    Id = 27,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "c",
                    Id = 28,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                },
                new Question
                {
                    Answer = "b",
                    Id = 29,
                    QuestionTypeId = 2,
                    Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                    Title = "Que letra es la correcta",
                    SectionId = 2
                }
            );



        }
    }
}