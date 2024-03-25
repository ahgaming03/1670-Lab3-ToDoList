using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab3_ToDoList.Models;

namespace Lab3_ToDoList.Data
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext (DbContextOptions<TaskDBContext> options)
            : base(options)
        {
        }

        public DbSet<Lab3_ToDoList.Models.Task> Task { get; set; } = default!;
    }
}
