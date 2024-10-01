```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.7058 ns** | **0.9956 ns** | **0.0546 ns** |  **65.6697 ns** |  **65.7686 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0253 ns | 0.0867 ns | 0.0048 ns |   0.0210 ns |   0.0304 ns |         - |
| TryParseCidrString | 1      |  73.1663 ns | 2.9690 ns | 0.1627 ns |  73.0300 ns |  73.3465 ns |         - |
| TryParseCidrBytes  | 1      |   2.7558 ns | 0.0119 ns | 0.0007 ns |   2.7550 ns |   2.7563 ns |         - |
| **NewFromCidrString**  | **3**      | **197.2757 ns** | **7.9062 ns** | **0.4334 ns** | **196.9017 ns** | **197.7506 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6432 ns | 0.0031 ns | 0.0002 ns |   0.6430 ns |   0.6433 ns |         - |
| TryParseCidrString | 3      | 209.3302 ns | 9.5557 ns | 0.5238 ns | 208.9246 ns | 209.9215 ns |         - |
| TryParseCidrBytes  | 3      |   9.3027 ns | 0.2214 ns | 0.0121 ns |   9.2930 ns |   9.3163 ns |         - |
