```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.1536 ns** | **3.9192 ns** | **0.2148 ns** |  **50.0295 ns** |  **50.4017 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6213 ns | 0.0134 ns | 0.0007 ns |   0.6205 ns |   0.6220 ns |         - |
| TryParseCidrString | 1      |  51.9896 ns | 1.8466 ns | 0.1012 ns |  51.8737 ns |  52.0609 ns |         - |
| TryParseCidrBytes  | 1      |   3.0946 ns | 0.1480 ns | 0.0081 ns |   3.0895 ns |   3.1039 ns |         - |
| **NewFromCidrString**  | **3**      | **149.6584 ns** | **6.8948 ns** | **0.3779 ns** | **149.2448 ns** | **149.9856 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6286 ns | 0.1255 ns | 0.0069 ns |   0.6218 ns |   0.6356 ns |         - |
| TryParseCidrString | 3      | 156.1162 ns | 2.2838 ns | 0.1252 ns | 156.0095 ns | 156.2540 ns |         - |
| TryParseCidrBytes  | 3      |   9.3887 ns | 0.7345 ns | 0.0403 ns |   9.3651 ns |   9.4352 ns |         - |
