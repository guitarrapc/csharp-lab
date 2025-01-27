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
| **NewFromCidrString**  | **1**      |  **50.1930 ns** | **2.0282 ns** | **0.1112 ns** |  **50.1180 ns** |  **50.3207 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6256 ns | 0.0890 ns | 0.0049 ns |   0.6216 ns |   0.6311 ns |         - |
| TryParseCidrString | 1      |  52.4577 ns | 1.0977 ns | 0.0602 ns |  52.3897 ns |  52.5039 ns |         - |
| TryParseCidrBytes  | 1      |   3.0994 ns | 0.2027 ns | 0.0111 ns |   3.0928 ns |   3.1122 ns |         - |
| **NewFromCidrString**  | **3**      | **148.9576 ns** | **8.3202 ns** | **0.4561 ns** | **148.5800 ns** | **149.4643 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6276 ns | 0.1102 ns | 0.0060 ns |   0.6226 ns |   0.6343 ns |         - |
| TryParseCidrString | 3      | 157.5377 ns | 9.5419 ns | 0.5230 ns | 156.9388 ns | 157.9044 ns |         - |
| TryParseCidrBytes  | 3      |   9.1183 ns | 0.2344 ns | 0.0128 ns |   9.1065 ns |   9.1320 ns |         - |
