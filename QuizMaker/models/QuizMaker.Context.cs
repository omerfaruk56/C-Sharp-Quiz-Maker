﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizMaker.models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class quizMakerdbEntities : DbContext
    {
        public quizMakerdbEntities()
            : base("name=quizMakerdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<DegreeOfDifficult> DegreeOfDifficult { get; set; }
        public virtual DbSet<ExamLocation> ExamLocation { get; set; }
        public virtual DbSet<ExamMaker> ExamMaker { get; set; }
        public virtual DbSet<ExamWriter> ExamWriter { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<MChoiceOption> MChoiceOption { get; set; }
        public virtual DbSet<QuestionMaker> QuestionMaker { get; set; }
        public virtual DbSet<QuestionType> QuestionType { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Supervisor> Supervisor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<vw_examWriter> vw_examWriter { get; set; }
    }
}
