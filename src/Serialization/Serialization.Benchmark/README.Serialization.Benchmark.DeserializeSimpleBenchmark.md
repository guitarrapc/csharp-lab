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
| **SystemTextJsonSourceGen** | **{&quot;X&quot;(...)ab&quot;} [143]** | **534.4 ns** | **18.46 ns** | **1.01 ns** | **533.7 ns** | **535.6 ns** | **0.0029** |     **240 B** |
| **SystemTextJson**          | **{&quot;X&quot;(...)f3&quot;} [145]** | **544.4 ns** | **21.86 ns** | **1.20 ns** | **543.5 ns** | **545.8 ns** | **0.0029** |     **240 B** |
