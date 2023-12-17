﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Class:Entity<int>
{
    public int ProfileAnnouncementId { get; set; }
    public string Name { get; set; }
    public virtual ProfileAnnouncement ProfileAnnouncement { get; set; }
}