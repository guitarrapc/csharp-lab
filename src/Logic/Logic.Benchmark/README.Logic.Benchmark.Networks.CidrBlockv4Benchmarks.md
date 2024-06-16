```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2429 ns** | **1.6033 ns** | **0.0879 ns** |  **65.1463 ns** |  **65.3182 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8990 ns | 0.1295 ns | 0.0071 ns |  73.8937 ns |  73.9071 ns |         - |
| TryParseCidrBytes  | 1      |   3.0434 ns | 0.1942 ns | 0.0106 ns |   3.0328 ns |   3.0541 ns |         - |
| **NewFromCidrString**  | **3**      | **196.1264 ns** | **3.1362 ns** | **0.1719 ns** | **195.9706 ns** | **196.3108 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6035 ns | 0.0345 ns | 0.0019 ns |   0.6023 ns |   0.6056 ns |         - |
| TryParseCidrString | 3      | 213.6306 ns | 4.1958 ns | 0.2300 ns | 213.3794 ns | 213.8308 ns |         - |
| TryParseCidrBytes  | 3      |   9.1501 ns | 1.8365 ns | 0.1007 ns |   9.0344 ns |   9.2178 ns |         - |
