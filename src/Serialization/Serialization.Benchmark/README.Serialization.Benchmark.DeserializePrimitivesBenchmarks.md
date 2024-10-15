```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[91]** | **?**                   |    **79.15 ns** |  **2.619 ns** | **0.144 ns** |    **78.99 ns** |    **79.25 ns** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,152.10 ns** | **83.595 ns** | **4.582 ns** | **1,149.45 ns** | **1,157.39 ns** | **0.0019** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,123.39 ns | 44.985 ns | 2.466 ns | 1,121.89 ns | 1,126.24 ns | 0.0019 |     168 B |
