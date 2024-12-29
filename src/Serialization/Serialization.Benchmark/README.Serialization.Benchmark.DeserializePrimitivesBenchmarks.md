```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[91]** | **?**                   |    **69.18 ns** |   **3.029 ns** |  **0.166 ns** |    **69.01 ns** |    **69.34 ns** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,136.05 ns** |  **41.147 ns** |  **2.255 ns** | **1,134.51 ns** | **1,138.64 ns** | **0.0019** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,111.73 ns | 201.675 ns | 11.054 ns | 1,099.06 ns | 1,119.44 ns | 0.0019 |     168 B |
