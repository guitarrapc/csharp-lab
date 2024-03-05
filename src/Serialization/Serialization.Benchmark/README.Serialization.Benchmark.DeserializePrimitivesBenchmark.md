```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| **SystemTextJson**          | **{&quot;Sh(...)f0&quot;} [205]** | **1.092 μs** | **0.0468 μs** | **0.0026 μs** | **1.090 μs** | **1.095 μs** | **0.0019** |     **168 B** |
| **SystemTextJsonSourceGen** | **{&quot;Sh(...)98&quot;} [208]** | **1.075 μs** | **0.0113 μs** | **0.0006 μs** | **1.074 μs** | **1.076 μs** | **0.0019** |     **168 B** |
