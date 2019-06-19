## 微服务学习（netcore）

* #### 服务发现

  [Consul](https://www.consul.io/)

  * Consul 开发环境开启 `consul.exe agent -dev`

  * 新建一个mvc模板项目

    >  dotnet new mvc -n healthCheck1

  * 添加 consul 的 nuget 包

    > cd healthCheck1
  >
    > dotnet add package Consul
  
  * 