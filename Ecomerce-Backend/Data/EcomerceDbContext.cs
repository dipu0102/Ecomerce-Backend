
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce_Backend.Data
{
	public class EcomerceDbContext : IdentityDbContext
	{
		public EcomerceDbContext(DbContextOptions<EcomerceDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

		}
	}
}
