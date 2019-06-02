namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.SqlServer;
    using System.IO;
    using System.Linq;
    using Portfolio.Models;
    using Portfolio.Models.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<Portfolio.Models.PortfolioDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SqlClient", new PortfolioSqlServerMigrationSqlGenerator());
        }
        private void GenerateTestData(PortfolioDbContext context)
        {

            try
            {

                if (!context.User.Any())
                {
                    context.User.Add(
                    new User
                    {
                        Email = "lamanaa@code.edu.az",
                        Password = "?e?Y B/?A~Hg??O??J???~??????z?",

                    });


                }
                if (!context.Levels.Any())
                {
                    context.Levels.AddRange(new[] {
                    new CareerLevel{
                        Name="Junior",

                    },
                    new CareerLevel{
                        Name="Mid-Level",

                    },
                    new CareerLevel{
                        Name="Senior",

                    },
                    
                         });


                }
                if (!context.Degrees.Any())
                {
                    context.Degrees.AddRange(new[] {
                    new Degree{
                        Name="C",

                    },
                    new Degree{
                        Name="A",

                    },
                    new Degree{
                        Name="B",

                    },
                    new Degree{
                        Name="M",

                    },
                    new Degree{
                        Name="MBA",

                    }
                         });


                }
                if (!context.Occupations.Any())
                {
                    context.Occupations.AddRange(new[] {
                    new Occupation{
                        Name="Graphic Designer",

                    },
                    new Occupation{
                        Name="Web Developer",

                    },
                    new Occupation{
                        Name="Web Designer",

                    },
                    new Occupation{
                        Name="E-Commerce Analyst",

                    },

                         });


                }
                if (!context.Pcategory.Any())
                {
                    context.Pcategory.AddRange(new[] {
                    new PortfolioCatagory{
                        Name="Branding",

                    },
                    new PortfolioCatagory{
                        Name="Designing",

                    },
                    new PortfolioCatagory{
                        Name="Photography",

                    },
                    new PortfolioCatagory{
                        Name="Visual Design",

                    },

                         });


                }
                //if (!context.Portfolios.Any())
                //{
                //    context.Portfolios.AddRange(new[] {
                //    new Portfolio{
                //        MediaUrl= "img-2.jpg" ,
                //        Tags= ,
                //        PcategoryId=1,
                //        Pcategory=context.Pcategory.Where(a=>a.Id==1).FirstOrDefault(),
                //        Link= ,
                //    },
                //    new Portfolio{
                //        MediaUrl="img-5.jpg" ,
                //        Tags= ,
                //        PcategoryId=1,
                //        Pcategory=context.Pcategory.Where(a=>a.Id==1).FirstOrDefault(),
                //        Link= ,

                //    },
                //    new Portfolio{
                //        MediaUrl="img-9.jpg" ,
                //        Tags= ,
                //        PcategoryId=1,
                //        Pcategory=context.Pcategory.Where(a=>a.Id==1).FirstOrDefault(),
                //        Link= ,

                //    },
                //    new Portfolio{
                //        MediaUrl="img-8.jpg" ,
                //        Tags= ,
                //        PcategoryId=1,
                //        Pcategory=context.Pcategory.Where(a=>a.Id==1).FirstOrDefault(),
                //        Link= ,

                //    },
                //    new Portfolio{
                //        MediaUrl="img-1.jpg" ,
                //        Tags= ,
                //        PcategoryId=2,
                //        Pcategory=context.Pcategory.Where(a=>a.Id==2).FirstOrDefault(),
                //        Link= ,

                //    },
                //    new Portfolio{
                //       MediaUrl="img-4.jpg" ,
                //        Tags= ,
                //         PcategoryId=2,
                //        Pcategory=context.Pcategory.Where(a=>a.Id==2).FirstOrDefault(),
                //        Link= ,

                //    },
                //    new Portfolio{
                //        MediaUrl= ,
                //        Tags= ,
                //        PcategoryId=,
                //        Pcategory=,
                //        Link= ,

                //    },
                //         });

                //}

                if (!context.Skills.Any())
                {
                    context.Skills.AddRange(new[] {
                    new Skill{
                        Name="HTML5/CSS3",

                    },
                    new Skill{
                        Name="C#",

                    },
                    new Skill{
                        Name="JAVA",

                    },
                    new Skill{
                        Name="PHP",

                    },
                    new Skill{
                        Name="Photoshop",

                    },
                    new Skill{
                        Name=".NET",

                    },
                    new Skill{
                        Name="DreamViewer",

                    },
                         });
                    
                }
                if (!context.Experiences.Any())
                {
                    context.Experiences.AddRange(new[] {
                    new ProfessionalExperience{
                        YearRange="2002 - 2008",
                        Name="Wordpress Developer",
                        JobName="Market Network",
                        Place="San Francisco, California, USA",
                        Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam (...)",
                        MediaUrl="company-logo-1.jpg"

                    },
                    new ProfessionalExperience{
                        YearRange="2009 - 2016",
                        Name="html5 and css3 Developer",
                        JobName="Market Network",
                        Place="San Francisco, California, USA",
                        Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam (...)",
                        MediaUrl="company-logo-2.jpg"

                    },
                         });
                }
                if (!context.EduHistory.Any())
                {
                    context.EduHistory.AddRange(new[] {
                    new EducationHistory{
                        YearRange="2002 - 2008",
                        Name="Multimedia Arts",
                        Profession="Market Network",
                        Place="San Francisco, California, USA",
                        Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam (...)",


                    },
                    new EducationHistory{
                        YearRange="2009 - 2016",
                        Name="Mathematics in computer science",
                        Profession="Market Network",
                        Place="San Francisco, California, USA",
                        Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam (...)",


                    },
                         });
                }

                ////if (VizewDbContext.schemaName != "dbo")
                //GenerateTestData(context);

                context.SaveChanges();

            }
            catch (Exception)
            {

            }


        }
                 

private void GenerateTestDataForPersonSkill(PortfolioDbContext context)
        {
            try
            {
                if (!context.PersonSkills.Any())
                {
                    context.PersonSkills.AddRange(new[] {
                    new PersonSkill{
                        PersonId=1,
                        Person=context.Person.Where(a=>a.Id==1).FirstOrDefault(),
                        SkillsId=1,
                        Skills=context.Skills.Where(a=>a.Id==1).FirstOrDefault(),
                        IsSoft=true,
                        Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam (...)",
                        Percentage="80%" ,
                        },
                    new PersonSkill{
                        PersonId=1,
                        Person=context.Person.Where(a=>a.Id==1).FirstOrDefault(),
                        SkillsId=5,
                        Skills=context.Skills.Where(a=>a.Id==5).FirstOrDefault(),
                        IsSoft=true,
                        Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam (...)",
                        Percentage="80%" ,

                    },
                    new PersonSkill{
                        PersonId=1,
                        SkillsId=7,
                        Person=context.Person.Where(a=>a.Id==1).FirstOrDefault(),

                        Skills=context.Skills.Where(a=>a.Id==5).FirstOrDefault(),
                        IsSoft=false,
                        Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam (...)",
                        Percentage="90%" ,

                    },

                         });


                }

            }
            catch (Exception)
            {

                throw;
            }
        }
private void GenerateTestDataForPerson(PortfolioDbContext context)
{
    try
    {
                if (!context.Person.Any())
                {
                    context.Person.Add(
                    new Person
                    {
                        Name = "John Doe",
                        Age = 38,
                        Location = "Rome, Italy",
                        ExperienceYears = "15 years",
                        Phone = "(800) 123-4567",
                        FAX = "800) 123-4568",
                        EMail = "lamanaa@code.edu.az",
                        Website = "example.com",
                        DegreesId = 5,
                        Degrees = context.Degrees.Where(a => a.Id == 5).FirstOrDefault(),
                        LevelsId = 2,
                        Levels = context.Levels.Where(a => a.Id == 2).FirstOrDefault(),
                        MediaUrl = "avatar.jpg",


                    });


                }





            }
    catch (Exception)
    {

        throw;
    }
}


protected override void Seed(PortfolioDbContext context)
        {
            

                GenerateTestData(context);
            
            GenerateTestDataForPersonSkill(context) ;
            GenerateTestDataForPerson(context);






        }


    }

   


    internal class PortfolioSqlServerMigrationSqlGenerator:SqlServerMigrationSqlGenerator

    {
        protected override void Generate(CreateTableOperation operation)
        {
            foreach (var item in operation.Columns)
                SqlCreationDate(item);
            base.Generate(operation);
        }

        protected override void Generate(AddColumnOperation operation)
        {
            SqlCreationDate(operation.Column);
            base.Generate(operation);
        }

        protected override void Generate(AlterColumnOperation operation)
        {
            SqlCreationDate(operation.Column);

            base.Generate(operation);
        }
        void SqlCreationDate(ColumnModel column)
        {
            if (column.Name=="CreationDate")
            {
                column.DefaultValueSql = "getdate()";

            }
            


            //if (column.Name == "CreationDate")
            //    column.DefaultValueSql = "getdate()";
        }

    }
}
