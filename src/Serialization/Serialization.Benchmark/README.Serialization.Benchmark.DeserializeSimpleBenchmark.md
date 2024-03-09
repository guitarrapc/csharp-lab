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
| **SystemTextJsonSourceGen** | **{&quot;X&quot;(...)fd&quot;} [147]** | **567.1 ns** | **71.84 ns** | **3.94 ns** | **563.4 ns** | **571.3 ns** | **0.0029** |     **240 B** |
| **SystemTextJson**          | **{&quot;X&quot;(...)a1&quot;} [145]** | **550.3 ns** | **24.98 ns** | **1.37 ns** | **549.3 ns** | **551.9 ns** | **0.0029** |     **240 B** |
