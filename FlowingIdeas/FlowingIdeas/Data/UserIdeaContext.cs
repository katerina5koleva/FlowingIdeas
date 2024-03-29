﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowingIdeas.Data.Models;
namespace FlowingIdeas.Data
{
	internal class UserIdeaContext : DbContext
	{
		public UserIdeaContext() : base()
		{

		}
		public DbSet<ArtisticIdea> ArtisticIdeas { get; }
		public DbSet<PhilosophicalIdea> PhilosophicalIdeas { get; }
		public DbSet<User> Users { get; }
		public DbSet<WorkIdea> WorkIdeas { get; }
	}
}
