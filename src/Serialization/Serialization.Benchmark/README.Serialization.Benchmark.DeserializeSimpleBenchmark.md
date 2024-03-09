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
| **SystemTextJson**          | **{&quot;X&quot;(...)53&quot;} [146]** | **555.5 ns** | **26.47 ns** | **1.45 ns** | **553.9 ns** | **556.7 ns** | **0.0029** |     **240 B** |
| **SystemTextJsonSourceGen** | **{&quot;X&quot;(...)e8&quot;} [145]** | **550.4 ns** | **43.46 ns** | **2.38 ns** | **548.3 ns** | **552.9 ns** | **0.0029** |     **240 B** |
