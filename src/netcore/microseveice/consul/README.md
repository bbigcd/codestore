## 微服务学习（netcore）

* #### 服务发现

  [Consul](https://www.consul.io/)

  * Consul 开发环境开启 `consul.exe agent -dev`

  * 新建一个mvc模板项目

    >  dotnet new mvc -n healthCheck1

  * 添加 consul 的 nuget 包

    > cd healthCheck1
    > dotnet add package Consul
  
  * 将启动的配置文件launchSettings.json修改成
  
    ```json
    {
      "profiles": {
        "healthCheck1": {
          "commandName": "Project",
          "launchBrowser": true,
          "applicationUrl": "http://localhost:5001",
          "environmentVariables": {
            "ASPNETCORE_ENVIRONMENT": "Development"
          }
        }
      }
    }
    ```
  
    修改开启端口为5001
  
  * 在 Consul 中注册
  
    ```c#
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        var client = new ConsulClient(ConfigurationOverview);
        var result = client.Agent.ServiceRegister(new AgentServiceRegistration()
        {
            ID = "hband_api",
            Name = "api",
            Address = "http://localhost",
            Port = 5001,
            Check = new AgentServiceCheck
            {
                //服务启动多久后注册
                DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(5),
                //健康检查时间间隔，或者称为心跳间隔
                Interval = TimeSpan.FromSeconds(10),
                //健康检查地址
                HTTP = $"http://localhost:5001/api/health",//launchSettings.json 中设置
                Timeout = TimeSpan.FromSeconds(5)
            }
        });
    }
    
    private static void ConfigurationOverview(ConsulClientConfiguration obj)
    {
        obj.Address = new Uri("http://127.0.0.1:8500");
        obj.Datacenter = "dc1";
    }
    ```
  
  * 