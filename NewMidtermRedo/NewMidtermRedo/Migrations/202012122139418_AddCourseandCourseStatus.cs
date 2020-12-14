namespace NewMidtermRedo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseandCourseStatus : DbMigration
    {
        public override void Up()
        {
            
              Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Algebra', 'Study of Expressions', 'Bradley James', 10)");
              Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Acting', 'Method Acting', 'Candice Patton', 8)");
              Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Code', 'Beginners in Coding', 'Chris Evans', 9)");
              Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Language Arts', 'Understanding Written Words', 'Joe Lewis', 8)");

              Sql("Insert into CourseStatus(Status) values('Inprogress')");
              Sql("Insert into CourseStatus(Status) values('Completed')");
        }
        
        public override void Down()
        {
        }
    }
}
