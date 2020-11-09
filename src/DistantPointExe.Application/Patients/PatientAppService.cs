using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using DistantPointExe.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistantPointExe.Patients.Dto
{
    public class PatientAppService : DistantPointExeAppServiceBase, IPatientAppService
    {
        private readonly IRepository<Patient> _patientRepository;

        public PatientAppService(IRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public async Task<ListResultDto<PatientsListDto>> GetAll()
        {
            var patients = await _patientRepository
               .GetAll()
               .OrderByDescending(t => t.CreationTime)
               .ToListAsync();

            
            return new ListResultDto<PatientsListDto>(
               ObjectMapper.Map<List<PatientsListDto>>(patients)
            );
        }
    }
}
