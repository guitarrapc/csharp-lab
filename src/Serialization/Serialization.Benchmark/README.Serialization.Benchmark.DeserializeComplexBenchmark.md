```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev  | Min      | Max      | Allocated |
|------------------------ |-------------------- |---------:|---------:|--------:|---------:|---------:|----------:|
| **SystemTextJson**          | **{&quot;Gn(...)&quot;:0} [179]** | **953.6 ns** | **18.74 ns** | **1.03 ns** | **952.4 ns** | **954.4 ns** |     **104 B** |
| **SystemTextJsonSourceGen** | **{&quot;Gn(...)&quot;:1} [179]** | **946.1 ns** | **16.74 ns** | **0.92 ns** | **945.3 ns** | **947.1 ns** |     **104 B** |
