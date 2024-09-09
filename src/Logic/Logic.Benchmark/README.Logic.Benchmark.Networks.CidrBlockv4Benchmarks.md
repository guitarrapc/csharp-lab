```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.8204 ns** |  **2.2568 ns** | **0.1237 ns** |  **64.6825 ns** |  **64.9216 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0248 ns |  0.0398 ns | 0.0022 ns |   0.0227 ns |   0.0270 ns |         - |
| TryParseCidrString | 1      |  73.5302 ns | 11.0510 ns | 0.6057 ns |  72.8702 ns |  74.0607 ns |         - |
| TryParseCidrBytes  | 1      |   2.7514 ns |  0.2626 ns | 0.0144 ns |   2.7427 ns |   2.7680 ns |         - |
| **NewFromCidrString**  | **3**      | **196.9336 ns** |  **3.9336 ns** | **0.2156 ns** | **196.7490 ns** | **197.1706 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6382 ns |  0.0125 ns | 0.0007 ns |   0.6374 ns |   0.6387 ns |         - |
| TryParseCidrString | 3      | 209.0015 ns |  9.0162 ns | 0.4942 ns | 208.5931 ns | 209.5509 ns |         - |
| TryParseCidrBytes  | 3      |   9.3051 ns |  2.1643 ns | 0.1186 ns |   9.1779 ns |   9.4127 ns |         - |
