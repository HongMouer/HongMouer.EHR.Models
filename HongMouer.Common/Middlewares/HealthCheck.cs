using HongMouer.EHR.Models;
using HongMouer.EntityRelationalCore.Repositories;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HongMouer.Common
{
    public class HealthCheck : IHealthCheck
    {
        private readonly IRepository _Repository;

        public HealthCheck(IRepository repository)
        {
            _Repository = repository;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                _Repository.FindEntity<UserInfo>();
            }
            catch (Exception ex)
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("From Db Serve"));
            }

            return Task.FromResult(HealthCheckResult.Healthy());
        }
    }
}
