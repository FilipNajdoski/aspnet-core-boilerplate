using Abp.Application.Services.Dto;

namespace DistantPointExe.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

