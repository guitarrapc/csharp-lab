```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|---------:|--------:|---------:|---------:|-------:|----------:|
| **SystemTextJson**          | **{&quot;X&quot;(...)f0&quot;} [146]** | **545.9 ns** | **17.29 ns** | **0.95 ns** | **544.8 ns** | **546.6 ns** | **0.0029** |     **240 B** |
| **SystemTextJsonSourceGen** | **{&quot;X&quot;(...)58&quot;} [145]** | **557.2 ns** | **19.17 ns** | **1.05 ns** | **556.0 ns** | **558.0 ns** | **0.0029** |     **240 B** |
