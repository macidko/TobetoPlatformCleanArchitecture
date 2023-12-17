﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Announcement:Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ProfileAnnouncement? ProfileAnnouncement { get; set; }
        public Announcement()
        {

        }

        public Announcement(string name, string description, int id) : this()
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}