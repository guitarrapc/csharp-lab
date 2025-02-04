```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.3141 ns** |  **3.3935 ns** | **0.1860 ns** |  **50.1770 ns** |  **50.5259 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6222 ns |  0.0143 ns | 0.0008 ns |   0.6216 ns |   0.6231 ns |         - |
| TryParseCidrString | 1      |  52.6111 ns |  0.5050 ns | 0.0277 ns |  52.5916 ns |  52.6428 ns |         - |
| TryParseCidrBytes  | 1      |   3.0871 ns |  0.0060 ns | 0.0003 ns |   3.0867 ns |   3.0874 ns |         - |
| **NewFromCidrString**  | **3**      | **151.0798 ns** | **27.2571 ns** | **1.4941 ns** | **149.3557 ns** | **151.9969 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6275 ns |  0.1013 ns | 0.0055 ns |   0.6214 ns |   0.6323 ns |         - |
| TryParseCidrString | 3      | 155.7264 ns |  2.7413 ns | 0.1503 ns | 155.6187 ns | 155.8981 ns |         - |
| TryParseCidrBytes  | 3      |   9.5197 ns |  2.2120 ns | 0.1212 ns |   9.3809 ns |   9.6051 ns |         - |
