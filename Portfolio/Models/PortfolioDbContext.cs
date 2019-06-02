using Portfolio.Migrations;
using Portfolio.Models.Entity;
using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class PortfolioDbContext:DbContext
    {
        internal const string schemaName = "dbo";

        public PortfolioDbContext()
            : base("name=cString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PortfolioDbContext, Configuration>());
        }
        public DbSet<User> User { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProfessionalExperience> Experiences { get; set; }
        public DbSet<EducationHistory> EduHistory { get; set; }
        public DbSet<CareerLevel> Levels { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonSkill> PersonSkills  { get; set; }
        public DbSet<PortfolioCatagory> Pcategory { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Portfolio.Models.Entity.Portfolioss> Portfolios { get; set; }
    }
}