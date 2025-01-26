```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.4473 ns** | **0.9440 ns** | **0.0517 ns** |  **50.3906 ns** |  **50.4920 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6260 ns | 0.0996 ns | 0.0055 ns |   0.6226 ns |   0.6323 ns |         - |
| TryParseCidrString | 1      |  52.6428 ns | 7.5050 ns | 0.4114 ns |  52.3264 ns |  53.1078 ns |         - |
| TryParseCidrBytes  | 1      |   3.1733 ns | 1.9403 ns | 0.1064 ns |   3.0879 ns |   3.2924 ns |         - |
| **NewFromCidrString**  | **3**      | **150.1676 ns** | **2.6564 ns** | **0.1456 ns** | **150.0073 ns** | **150.2916 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6244 ns | 0.1071 ns | 0.0059 ns |   0.6208 ns |   0.6312 ns |         - |
| TryParseCidrString | 3      | 156.5631 ns | 7.0064 ns | 0.3840 ns | 156.1356 ns | 156.8789 ns |         - |
| TryParseCidrBytes  | 3      |   9.2819 ns | 0.0934 ns | 0.0051 ns |   9.2764 ns |   9.2866 ns |         - |
