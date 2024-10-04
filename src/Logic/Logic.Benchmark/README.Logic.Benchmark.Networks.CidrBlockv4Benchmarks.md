```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **71.4772 ns** |  **3.3131 ns** | **0.1816 ns** |  **71.2685 ns** |  **71.5989 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0212 ns |  0.0267 ns | 0.0015 ns |   0.0197 ns |   0.0227 ns |         - |
| TryParseCidrString | 1      |  72.9469 ns |  7.1009 ns | 0.3892 ns |  72.6090 ns |  73.3725 ns |         - |
| TryParseCidrBytes  | 1      |   2.7590 ns |  0.0184 ns | 0.0010 ns |   2.7583 ns |   2.7601 ns |         - |
| **NewFromCidrString**  | **3**      | **199.1808 ns** | **46.0807 ns** | **2.5258 ns** | **197.6380 ns** | **202.0957 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6433 ns |  0.0826 ns | 0.0045 ns |   0.6403 ns |   0.6485 ns |         - |
| TryParseCidrString | 3      | 211.6301 ns |  0.4002 ns | 0.0219 ns | 211.6139 ns | 211.6550 ns |         - |
| TryParseCidrBytes  | 3      |   9.3566 ns |  0.4765 ns | 0.0261 ns |   9.3274 ns |   9.3777 ns |         - |
