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
| **NewFromCidrString**  | **1**      |  **49.9453 ns** |  **0.4593 ns** | **0.0252 ns** |  **49.9186 ns** |  **49.9686 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6209 ns |  0.0156 ns | 0.0009 ns |   0.6201 ns |   0.6218 ns |         - |
| TryParseCidrString | 1      |  52.7266 ns |  1.3320 ns | 0.0730 ns |  52.6641 ns |  52.8069 ns |         - |
| TryParseCidrBytes  | 1      |   3.1833 ns |  1.7295 ns | 0.0948 ns |   3.1095 ns |   3.2903 ns |         - |
| **NewFromCidrString**  | **3**      | **153.2733 ns** | **15.1870 ns** | **0.8324 ns** | **152.4277 ns** | **154.0920 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6279 ns |  0.1721 ns | 0.0094 ns |   0.6214 ns |   0.6387 ns |         - |
| TryParseCidrString | 3      | 155.9902 ns | 16.5992 ns | 0.9099 ns | 155.0251 ns | 156.8324 ns |         - |
| TryParseCidrBytes  | 3      |   9.2614 ns |  0.7119 ns | 0.0390 ns |   9.2238 ns |   9.3017 ns |         - |
