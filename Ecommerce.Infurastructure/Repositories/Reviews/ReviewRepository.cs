using Ecommerce.SharedLib.Infurasturcture;
using Ecommerce.SharedLib.Infurasturcture.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities.Reviews
{
    public class ReviewRepository(IHttpContextAccessor contextAccessor, DbContext entites) : Repository<Review>(contextAccessor, entites), IReviewRepository
    {
    }
}
