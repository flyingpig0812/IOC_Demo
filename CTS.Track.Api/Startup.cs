using Autofac;
using AutoMapper;
using CTS.Track.Api.AutoMapper;
using CTS.Track.Api.Filter;
using CTS.Track.Api.JWT;
using CTS.Track.Api.Setup;
using CTS.Track.Common.Helper;
using CTS.Track.Common.Redis;
using CTS.Track.Repository.Sugar;
using log4net;
using log4net.Config;
using log4net.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CTS.Track.Api
{
    public class Startup
    {
        public static ILoggerRepository repository { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            repository = LogManager.CreateRepository("LogHelper");
            //ָ�������ļ�
            //XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //ע��appsettings��ȡ��
            services.AddSingleton(new Appsettings(Configuration));

            //ע��Redis
            services.AddSingleton<IRedisCacheManager, RedisCacheManager>();

            //���ݿ�����
            BaseDBConfig.ConnectionString = Configuration.GetSection("AppSettings:ConnectionString").Value;

            services.AddControllersWithViews();
            services.AddControllers();

            #region jwt����
            services.AddTransient<ITokenHelper, TokenHelper>();
            //��ȡ�����ļ����õ�jwt�������
            services.Configure<JWTConfig>(Configuration.GetSection("JWTConfig"));
            //����JWT
            services.AddAuthentication(Options =>
            {
                Options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                Options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).
            AddJwtBearer();
            #endregion

            // ע��Swagger����
            services.AddSwaggerGen(c =>
            {
                // ����ĵ���Ϣ
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CTS.Track.Api", Version = "v1" });
            });
            //ע��automapper
            services.AddAutoMapper(typeof(AutoMapperProfile));


            #region ע���Զ��������
            services.AddTransient<RequestLogsFilterAttribute>();
            services.AddTransient<Authentication>();
            #endregion

            services.Configure<KestrelServerOptions>(x => x.AllowSynchronousIO = true)
                .Configure<IISServerOptions>(x => x.AllowSynchronousIO = true);

        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AutofacModuleRegister());
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CTS.Track.Api v1"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.Use((context, next) =>
            {
                context.Request.EnableBuffering();
                return next();
            });

            app.UseRouting();

            //������֤�м�� Ҫд����ȨUseAuthorization()��ǰ��
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}");
                endpoints.MapControllerRoute(
                    name: "api",
                    pattern: "api/{controller}/{action}");
            });


        }
    }
}
