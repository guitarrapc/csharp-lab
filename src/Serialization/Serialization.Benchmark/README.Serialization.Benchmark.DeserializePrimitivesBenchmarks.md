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
| **MemoryPack**              | **Byte[91]** | **?**                   |    **78.92 ns** |  **25.04 ns** | **1.372 ns** |    **78.12 ns** |    **80.51 ns** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,164.76 ns** | **101.17 ns** | **5.546 ns** | **1,158.82 ns** | **1,169.81 ns** | **0.0019** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,138.01 ns |  23.61 ns | 1.294 ns | 1,136.69 ns | 1,139.28 ns | 0.0019 |     168 B |
