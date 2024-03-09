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
| **SystemTextJson**          | **{&quot;Gn(...)&quot;:0} [182]** | **959.1 ns** | **77.21 ns** | **4.23 ns** | **955.6 ns** | **963.8 ns** |     **104 B** |
| **SystemTextJsonSourceGen** | **{&quot;Gn(...)&quot;:0} [180]** | **944.0 ns** | **15.63 ns** | **0.86 ns** | **943.3 ns** | **944.9 ns** |     **104 B** |
