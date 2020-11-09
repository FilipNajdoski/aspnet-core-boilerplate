using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DistantPointExe.Patients.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DistantPointExe.Patients
{
    public interface IPatientAppService : IApplicationService
    {
         Task<ListResultDto<PatientsListDto>> GetAll();
    }
}
