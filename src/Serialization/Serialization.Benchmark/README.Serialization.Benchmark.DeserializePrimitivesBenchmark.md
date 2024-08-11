```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[91]** | **?**                   |    **75.45 ns** |   **2.986 ns** | **0.164 ns** |    **75.27 ns** |    **75.58 ns** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,170.07 ns** | **111.399 ns** | **6.106 ns** | **1,165.93 ns** | **1,177.08 ns** | **0.0019** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,149.63 ns |  78.475 ns | 4.301 ns | 1,147.14 ns | 1,154.60 ns | 0.0019 |     168 B |
