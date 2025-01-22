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
| **NewFromCidrString**  | **1**      |  **50.0553 ns** | **2.1636 ns** | **0.1186 ns** |  **49.9598 ns** |  **50.1881 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6211 ns | 0.0131 ns | 0.0007 ns |   0.6203 ns |   0.6217 ns |         - |
| TryParseCidrString | 1      |  52.6457 ns | 0.4888 ns | 0.0268 ns |  52.6222 ns |  52.6749 ns |         - |
| TryParseCidrBytes  | 1      |   3.0932 ns | 0.1063 ns | 0.0058 ns |   3.0879 ns |   3.0994 ns |         - |
| **NewFromCidrString**  | **3**      | **150.0150 ns** | **2.5609 ns** | **0.1404 ns** | **149.8540 ns** | **150.1120 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6282 ns | 0.1122 ns | 0.0061 ns |   0.6214 ns |   0.6333 ns |         - |
| TryParseCidrString | 3      | 156.4420 ns | 2.9788 ns | 0.1633 ns | 156.2577 ns | 156.5686 ns |         - |
| TryParseCidrBytes  | 3      |   9.3184 ns | 0.9547 ns | 0.0523 ns |   9.2877 ns |   9.3789 ns |         - |
