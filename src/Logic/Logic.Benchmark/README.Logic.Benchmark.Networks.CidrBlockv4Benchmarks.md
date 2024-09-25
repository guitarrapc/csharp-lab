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
| **NewFromCidrString**  | **1**      |  **66.3885 ns** | **1.0638 ns** | **0.0583 ns** |  **66.3228 ns** |  **66.4343 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0250 ns | 0.0484 ns | 0.0027 ns |   0.0227 ns |   0.0279 ns |         - |
| TryParseCidrString | 1      |  73.0286 ns | 7.6095 ns | 0.4171 ns |  72.7383 ns |  73.5065 ns |         - |
| TryParseCidrBytes  | 1      |   2.7598 ns | 0.0160 ns | 0.0009 ns |   2.7590 ns |   2.7607 ns |         - |
| **NewFromCidrString**  | **3**      | **196.9748 ns** | **7.3036 ns** | **0.4003 ns** | **196.6435 ns** | **197.4197 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6455 ns | 0.1346 ns | 0.0074 ns |   0.6411 ns |   0.6541 ns |         - |
| TryParseCidrString | 3      | 211.6414 ns | 2.9845 ns | 0.1636 ns | 211.4587 ns | 211.7743 ns |         - |
| TryParseCidrBytes  | 3      |   9.3745 ns | 0.5960 ns | 0.0327 ns |   9.3516 ns |   9.4119 ns |         - |
