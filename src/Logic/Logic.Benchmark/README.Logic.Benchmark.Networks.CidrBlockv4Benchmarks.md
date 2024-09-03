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
| **NewFromCidrString**  | **1**      |  **65.5182 ns** |  **4.6806 ns** | **0.2566 ns** |  **65.2589 ns** |  **65.7719 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0214 ns |  0.0663 ns | 0.0036 ns |   0.0175 ns |   0.0247 ns |         - |
| TryParseCidrString | 1      |  72.4168 ns |  0.5320 ns | 0.0292 ns |  72.3842 ns |  72.4402 ns |         - |
| TryParseCidrBytes  | 1      |   2.7564 ns |  0.2881 ns | 0.0158 ns |   2.7448 ns |   2.7744 ns |         - |
| **NewFromCidrString**  | **3**      | **197.1588 ns** | **14.1929 ns** | **0.7780 ns** | **196.4060 ns** | **197.9597 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6421 ns |  0.1615 ns | 0.0089 ns |   0.6370 ns |   0.6524 ns |         - |
| TryParseCidrString | 3      | 209.8972 ns |  9.9133 ns | 0.5434 ns | 209.2701 ns | 210.2269 ns |         - |
| TryParseCidrBytes  | 3      |   9.3434 ns |  0.6684 ns | 0.0366 ns |   9.3116 ns |   9.3835 ns |         - |
