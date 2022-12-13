using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AerToss.Infrastructure.Data
{
	internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
	{
		public void Configure(EntityTypeBuilder<Review> builder)
		{
			throw new NotImplementedException();
		}
	}
}
