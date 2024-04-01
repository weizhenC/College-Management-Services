using CollegeManagementServices.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskStatus = CollegeManagementServices.Models.TaskStatus;

namespace CollegeManagementServices.Data
{
    public class CollegeDbContext : IdentityDbContext
    {
        public DbSet<StaffTask> StaffTasks { get; set; }
        public DbSet<StudentDuty> StudentDuties { get; set; }

        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed the StaffTask table with sample data
            modelBuilder.Entity<StaffTask>().HasData(
                new StaffTask
                {
                    TaskId = 1,
                    Code = "WG4",
                    Description = "Application Dev II",
                    Location = TaskLocation.Online,
                    Status = TaskStatus.InProgress
                },
                new StaffTask
                {
                    TaskId = 2,
                    Code = "SB3",
                    Description = "Cloud administration",
                    Location = TaskLocation.Online,
                    Status = TaskStatus.Completed
                }
            );

            // Seed the StudentDuty table with sample data
            modelBuilder.Entity<StudentDuty>().HasData(
                new StudentDuty
                {
                    Id = 1,
                    Code = "AB10",
                    Description = "Attend classes",
                    Status = "In progress"
                },
                new StudentDuty
                {
                    Id = 2,
                    Code = "52GB",
                    Description = "Do some tutoring",
                    Status = "In progress"
                },
                new StudentDuty
                {
                    Id = 3,
                    Code = "BH23",
                    Description = "Make some friends",
                    Status = "Not started"
                },
                new StudentDuty
                {
                    Id = 4,
                    Code = "M2O3",
                    Description = "Score good grades",
                    Status = "Completed"
                }
            );
        }
    }
}
