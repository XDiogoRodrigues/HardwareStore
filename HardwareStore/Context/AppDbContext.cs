using Microsoft.EntityFrameworkCore;

namespace HardwareStore.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}
}
