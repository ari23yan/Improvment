using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public readonly IMediator _mediator;
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

    }
}
