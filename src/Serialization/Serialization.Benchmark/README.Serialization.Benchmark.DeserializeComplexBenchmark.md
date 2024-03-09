```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| **SystemTextJson**          | **{&quot;Gn(...)&quot;:1} [183]** | **963.3 ns** |   **2.57 ns** | **0.14 ns** | **963.1 ns** | **963.4 ns** |      **-** |     **104 B** |
| **SystemTextJsonSourceGen** | **{&quot;Gn(...)&quot;:0} [181]** | **931.7 ns** | **166.35 ns** | **9.12 ns** | **925.8 ns** | **942.2 ns** | **0.0010** |     **104 B** |
