using ChildCare.MonitoringSystem.Business;
using ChildCare.MonitoringSystem.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ChildCare.MonitoringSystem.Web.BackgroundWorker
{
    public class LocationUpdateService : BackgroundService
    {
        private readonly StudentBusiness _studentBusiness;
        string longitude = "74.924192";
        string latitude = "12.979621";
        private readonly IServiceProvider _serviceProvider;
        public LocationUpdateService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceProvider = serviceScopeFactory.CreateScope().ServiceProvider;
            _studentBusiness = _serviceProvider.GetService<StudentBusiness>();
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(10000, stoppingToken);
                var studentlocation = _studentBusiness.UpdateStudentLocation(4027, latitude, longitude);
            }
           
        }
    }
}
