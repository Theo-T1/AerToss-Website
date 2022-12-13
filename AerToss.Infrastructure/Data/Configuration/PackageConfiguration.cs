using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AerToss.Infrastructure.Data
{
	internal class PackageConfiguration : IEntityTypeConfiguration<Package>
	{
		public void Configure(EntityTypeBuilder<Package> builder)
		{
			throw new NotImplementedException();
		}
	}
}
