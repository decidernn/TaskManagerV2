﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_Manager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TaskManagerEntities : DbContext
    {
        private static TaskManagerEntities _context;
        public TaskManagerEntities()
            : base("name=TaskManagerEntities")
        {
        }

        public static TaskManagerEntities GetContext()
        {
            if (_context == null)
            {
                _context = new TaskManagerEntities();
            }

            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<MemberSubtask> MemberSubtask { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Subtask> Subtask { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserHistory> UserHistory { get; set; }
    
        public virtual int AddUserHistoryRecord(Nullable<int> userId, Nullable<int> idAction, Nullable<System.DateTime> dateAction)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var idActionParameter = idAction.HasValue ?
                new ObjectParameter("IdAction", idAction) :
                new ObjectParameter("IdAction", typeof(int));
    
            var dateActionParameter = dateAction.HasValue ?
                new ObjectParameter("DateAction", dateAction) :
                new ObjectParameter("DateAction", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUserHistoryRecord", userIdParameter, idActionParameter, dateActionParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> CheckIdInMembers(Nullable<int> userId, string teamTitle)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var teamTitleParameter = teamTitle != null ?
                new ObjectParameter("TeamTitle", teamTitle) :
                new ObjectParameter("TeamTitle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("CheckIdInMembers", userIdParameter, teamTitleParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> CheckIdInMembersForTeam(Nullable<int> userId, Nullable<int> taskId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var taskIdParameter = taskId.HasValue ?
                new ObjectParameter("TaskId", taskId) :
                new ObjectParameter("TaskId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("CheckIdInMembersForTeam", userIdParameter, taskIdParameter);
        }
    
        public virtual ObjectResult<GetAllData_Result> GetAllData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllData_Result>("GetAllData");
        }
    
        public virtual ObjectResult<GetUserHistory_Result> GetUserHistory(Nullable<int> idUser)
        {
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("IdUser", idUser) :
                new ObjectParameter("IdUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserHistory_Result>("GetUserHistory", idUserParameter);
        }
    }
}