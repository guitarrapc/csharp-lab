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
| **SystemTextJsonSourceGen** | **{&quot;A&quot;(...)7&quot;}} [892]** | **19.32 μs** | **4.458 μs** | **0.244 μs** | **19.04 μs** | **19.49 μs** | **0.0305** |   **3.19 KB** |
| **SystemTextJson**          | **{&quot;A&quot;(...)f&quot;}} [894]** | **20.12 μs** | **2.346 μs** | **0.129 μs** | **19.97 μs** | **20.22 μs** | **0.0305** |   **3.19 KB** |
