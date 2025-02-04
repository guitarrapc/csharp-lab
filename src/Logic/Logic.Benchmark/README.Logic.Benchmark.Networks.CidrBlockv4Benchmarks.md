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
| **NewFromCidrString**  | **1**      |  **50.1772 ns** | **1.2277 ns** | **0.0673 ns** |  **50.1328 ns** |  **50.2546 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6306 ns | 0.1246 ns | 0.0068 ns |   0.6227 ns |   0.6351 ns |         - |
| TryParseCidrString | 1      |  53.5720 ns | 2.2032 ns | 0.1208 ns |  53.4430 ns |  53.6824 ns |         - |
| TryParseCidrBytes  | 1      |   3.1060 ns | 0.4091 ns | 0.0224 ns |   3.0913 ns |   3.1318 ns |         - |
| **NewFromCidrString**  | **3**      | **148.2840 ns** | **4.9795 ns** | **0.2729 ns** | **148.0648 ns** | **148.5897 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6219 ns | 0.0099 ns | 0.0005 ns |   0.6213 ns |   0.6223 ns |         - |
| TryParseCidrString | 3      | 155.7339 ns | 4.3936 ns | 0.2408 ns | 155.5251 ns | 155.9974 ns |         - |
| TryParseCidrBytes  | 3      |   9.5414 ns | 0.5778 ns | 0.0317 ns |   9.5224 ns |   9.5780 ns |         - |
