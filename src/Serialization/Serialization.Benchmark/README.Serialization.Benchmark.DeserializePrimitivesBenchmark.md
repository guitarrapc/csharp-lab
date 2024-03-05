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
| **SystemTextJsonSourceGen** | **{&quot;Sh(...)d1&quot;} [209]** | **1.081 μs** | **0.0046 μs** | **0.0003 μs** | **1.080 μs** | **1.081 μs** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **{&quot;Sh(...)5a&quot;} [207]** | **1.116 μs** | **0.0765 μs** | **0.0042 μs** | **1.112 μs** | **1.121 μs** | **0.0019** |     **168 B** |
