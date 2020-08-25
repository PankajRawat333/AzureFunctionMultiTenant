using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp8
{
    public class TenantProvider : ITenantProvider
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public TenantProvider(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        public string GetTenant()
        {
            string tenant = this.httpContextAccessor.HttpContext.Request.Headers["Tenant"];
            return tenant;
        }
    }
    public interface ITenantProvider
    {
        string GetTenant();
    }
}
