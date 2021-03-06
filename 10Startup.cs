﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OrderApi.Data;
using OrderApi.Services;


namespace OrderApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //使用内存数据库
            // services.AddDbContext<TodoContext>(opt =>
            //     opt.UseInMemoryDatabase("TodoList"));

            //使用MySql数据库，配置连接字符串和Mysql的版本
            //这里创建了一个单例单TodoContext对象，用于实现依赖注入

            services.AddDbContextPool<OrderDbContext>(
                options => options.UseMySql(
                    "Server=localhost;Database=orderDb;User=root;Password=777wiki;" // replace with your Connection String
                ));
            //添加一个 OrderService对象，用于依赖注入
            services.AddScoped<OrderService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            //自动创建库
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<OrderDbContext>();
                context.Database.EnsureCreated();
            }

            //使用html页面和其他静态资源
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
