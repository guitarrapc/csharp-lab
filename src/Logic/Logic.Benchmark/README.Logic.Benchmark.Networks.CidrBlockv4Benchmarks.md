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
| **NewFromCidrString**  | **1**      |  **49.9493 ns** | **1.4582 ns** | **0.0799 ns** |  **49.8775 ns** |  **50.0354 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6331 ns | 0.2233 ns | 0.0122 ns |   0.6218 ns |   0.6461 ns |         - |
| TryParseCidrString | 1      |  52.8655 ns | 1.9094 ns | 0.1047 ns |  52.7486 ns |  52.9505 ns |         - |
| TryParseCidrBytes  | 1      |   3.1010 ns | 0.2192 ns | 0.0120 ns |   3.0871 ns |   3.1079 ns |         - |
| **NewFromCidrString**  | **3**      | **149.4498 ns** | **7.2119 ns** | **0.3953 ns** | **149.0714 ns** | **149.8601 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6268 ns | 0.0857 ns | 0.0047 ns |   0.6240 ns |   0.6323 ns |         - |
| TryParseCidrString | 3      | 154.4400 ns | 1.4783 ns | 0.0810 ns | 154.3676 ns | 154.5275 ns |         - |
| TryParseCidrBytes  | 3      |   9.3887 ns | 2.6364 ns | 0.1445 ns |   9.2578 ns |   9.5438 ns |         - |
