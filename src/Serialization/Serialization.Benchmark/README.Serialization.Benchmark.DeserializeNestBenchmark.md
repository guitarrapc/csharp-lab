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
| **SystemTextJsonSourceGen** | **{&quot;A&quot;(...)4&quot;}} [893]** | **19.41 μs** | **6.654 μs** | **0.365 μs** | **19.11 μs** | **19.82 μs** | **0.0305** |   **3.19 KB** |
| **SystemTextJson**          | **{&quot;A&quot;(...)7&quot;}} [893]** | **19.72 μs** | **4.478 μs** | **0.245 μs** | **19.44 μs** | **19.88 μs** | **0.0305** |   **3.19 KB** |
