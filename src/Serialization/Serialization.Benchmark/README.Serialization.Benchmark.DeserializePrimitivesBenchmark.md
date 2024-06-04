```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[91]** | **?**                   |    **74.09 ns** |  **5.067 ns** | **0.278 ns** |    **73.82 ns** |    **74.37 ns** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,160.73 ns** | **60.561 ns** | **3.320 ns** | **1,158.36 ns** | **1,164.52 ns** | **0.0019** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,109.12 ns | 62.855 ns | 3.445 ns | 1,106.41 ns | 1,112.99 ns | 0.0019 |     168 B |
