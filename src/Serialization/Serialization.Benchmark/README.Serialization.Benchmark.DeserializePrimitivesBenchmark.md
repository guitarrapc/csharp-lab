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
| **SystemTextJsonSourceGen** | **{&quot;Sh(...)4e&quot;} [206]** | **1.065 μs** | **0.0414 μs** | **0.0023 μs** | **1.063 μs** | **1.068 μs** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **{&quot;Sh(...)8a&quot;} [209]** | **1.124 μs** | **0.0807 μs** | **0.0044 μs** | **1.121 μs** | **1.129 μs** | **0.0019** |     **168 B** |
