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
            
            
            
        }
    }
}