```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[91]** | **?**                   |    **76.74 ns** |  **2.550 ns** | **0.140 ns** |    **76.61 ns** |    **76.88 ns** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,174.90 ns** | **19.947 ns** | **1.093 ns** | **1,173.94 ns** | **1,176.09 ns** | **0.0019** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,143.77 ns | 12.593 ns | 0.690 ns | 1,143.12 ns | 1,144.50 ns | 0.0019 |     168 B |
