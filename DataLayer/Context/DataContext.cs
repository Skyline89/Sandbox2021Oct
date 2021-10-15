using Microsoft.EntityFrameworkCore;
using Sandbox2021Oct.DataLayer.Context.Tables;
using Sandbox2021Oct.DataLayer.Helpers;
using System;

namespace Sandbox2021Oct.DataLayer.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public bool IsUseLazyLoading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isUseLazyLoading"></param>
        public DataContext(bool isUseLazyLoading)
        {
            IsUseLazyLoading = isUseLazyLoading;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(IsUseLazyLoading)
                          .UseNpgsql(DbConnectionHelper.ExadelDatabaseHard,
                builder => { builder.EnableRetryOnFailure(3, TimeSpan.FromSeconds(2), null); });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
        }

        /// <summary>
        /// 
        /// </summary>
        public DataContext() { }

        #region Entities

        public DbSet<AccessedCandidate> AccessedCandidates { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<InterviewSchedule> InterviewSchedules { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<Team> Teams { get; set; }
        
        #endregion
    }
}
