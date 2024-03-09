```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| **SystemTextJsonSourceGen** | **{&quot;A&quot;(...)b&quot;}} [889]** | **19.21 μs** | **6.886 μs** | **0.377 μs** | **18.89 μs** | **19.63 μs** | **0.0305** |   **3.19 KB** |
| **SystemTextJson**          | **{&quot;A&quot;(...)e&quot;}} [893]** | **19.91 μs** | **2.923 μs** | **0.160 μs** | **19.78 μs** | **20.09 μs** | **0.0305** |   **3.19 KB** |
