using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using DistantPointExe.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointExe.Patients.Dto
{
    [AutoMapFrom(typeof(Patient))]
    public class PatientsListDto : EntityDto, IHasCreationTime
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
