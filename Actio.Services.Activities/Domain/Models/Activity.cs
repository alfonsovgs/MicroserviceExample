using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actio.Common.Exceptions;

namespace Actio.Services.Activities.Domain.Models
{
    public class Activity
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Category { get; protected set; }
        public string Description { get; protected set; }
        public Guid UserId { get; protected set; }
        public DateTime CreateAt { get; protected set; }

        protected Activity()
        {
            
        }

        public Activity(Guid id, Category category, Guid userId, string name, string description, DateTime createAt)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ActioException("empty_acivity_name", $"Activity name can not be empty");

            Id = id;
            Category = category.Name;
            UserId = userId;
            Name = name;
            Description = description;
            CreateAt = createAt;
        }
    }
}
