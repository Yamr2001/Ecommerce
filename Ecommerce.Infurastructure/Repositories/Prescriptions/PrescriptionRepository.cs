using Ecommerce.SharedLib.Infurasturcture;
using Ecommerce.SharedLib.Infurasturcture.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities.Prescriptions
{
    public class PrescriptionRepository(IHttpContextAccessor contextAccessor, DbContext entites) : Repository<Prescription>(contextAccessor, entites), IPrescriptionRepository
    {
    }
}
