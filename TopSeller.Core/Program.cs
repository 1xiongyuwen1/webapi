using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TopSeller.Core.Entity;

namespace TopSeller.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 生成承载 web 应用程序的 Microsoft.AspNetCore.Hosting.IWebHost。Build是WebHostBuilder最终的目的，将返回一个构造的WebHost，最终生成宿主。
            var host = CreateWebHostBuilder(args).Build();
            // 创建可用于解析作用域服务的新 Microsoft.Extensions.DependencyInjection.IServiceScope。
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();

                try
                {
                    // 从 system.IServicec提供程序获取 T 类型的服务。
                    var myContext = services.GetRequiredService<MyContext>();
                    // string GitJsonFileFormat = "https://github.com/anjoy8/Blog.Data.Share/raw/master/Blog.Core.Data.json/{0}.tsv";
                    //myContext.GetEntityDB<Module>().InsertRange(JsonHelper.ParseFormByJson<List<Module>>(GetNetData.Get(string.Format(GitJsonFileFormat, "Module"))));
                    //myContext.GetEntityDB<Permission>().InsertRange(JsonHelper.ParseFormByJson<List<Permission>>(GetNetData.Get(string.Format(GitJsonFileFormat, "Permission"))));
                    //myContext.GetEntityDB<Role>().InsertRange(JsonHelper.ParseFormByJson<List<Role>>(GetNetData.Get(string.Format(GitJsonFileFormat, "Role"))));
                    //myContext.GetEntityDB<RoleModulePermission>().InsertRange(JsonHelper.ParseFormByJson<List<RoleModulePermission>>(GetNetData.Get(string.Format(GitJsonFileFormat, "RoleModulePermission"))));
                    //myContext.GetEntityDB<sysUserInfo>().InsertRange(JsonHelper.ParseFormByJson<List<sysUserInfo>>(GetNetData.Get(string.Format(GitJsonFileFormat, "sysUserInfo"))));
                    //myContext.GetEntityDB<Topic>().InsertRange(JsonHelper.ParseFormByJson<List<Topic>>(GetNetData.Get(string.Format(GitJsonFileFormat, "Topic"))));
                    //myContext.GetEntityDB<TopicDetail>().InsertRange(JsonHelper.ParseFormByJson<List<TopicDetail>>(GetNetData.Get(string.Format(GitJsonFileFormat, "TopicDetail"))));
                    //myContext.GetEntityDB<UserRole>().InsertRange(JsonHelper.ParseFormByJson<List<UserRole>>(GetNetData.Get(string.Format(GitJsonFileFormat, "UserRole"))));

                    // 为了大家的数据安全，这里先注释掉了，大家自己先测试玩一玩吧。
                    // 数据库连接字符串是在 Model 层的 Seed 文件夹下的 MyContext.cs 中
                    // DBSeed.SeedAsync(myContext).Wait();
                    // CreateWebHostBuilder(args).Build().Run();
                    host.Run();
                }
                catch (Exception e)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(e, "Error occured seeding the Database.");
                    throw;
                }
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:5888")
                .UseStartup<Startup>();
    }
}
