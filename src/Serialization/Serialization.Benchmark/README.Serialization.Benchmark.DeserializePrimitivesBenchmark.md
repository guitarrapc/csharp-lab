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
| **SystemTextJsonSourceGen** | **{&quot;Sh(...)be&quot;} [208]** | **1.102 μs** | **0.1476 μs** | **0.0081 μs** | **1.097 μs** | **1.111 μs** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **{&quot;Sh(...)a2&quot;} [207]** | **1.139 μs** | **0.0930 μs** | **0.0051 μs** | **1.135 μs** | **1.145 μs** | **0.0019** |     **168 B** |
