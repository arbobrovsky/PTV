using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EFDBContext :DbContext
    {
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {

        }

    }
}
