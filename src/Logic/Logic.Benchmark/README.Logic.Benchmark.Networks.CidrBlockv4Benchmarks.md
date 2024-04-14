```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0951 ns** |  **5.7423 ns** | **0.3148 ns** |  **64.9014 ns** |  **65.4583 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  72.6411 ns |  5.4209 ns | 0.2971 ns |  72.4644 ns |  72.9842 ns |         - |
| TryParseCidrBytes  | 1      |   3.0450 ns |  0.4062 ns | 0.0223 ns |   3.0318 ns |   3.0707 ns |         - |
| **NewFromCidrString**  | **3**      | **197.4468 ns** | **75.3103 ns** | **4.1280 ns** | **194.7125 ns** | **202.1953 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6049 ns |  0.1830 ns | 0.0100 ns |   0.5986 ns |   0.6165 ns |         - |
| TryParseCidrString | 3      | 210.2594 ns | 10.0570 ns | 0.5513 ns | 209.8388 ns | 210.8834 ns |         - |
| TryParseCidrBytes  | 3      |   9.0781 ns |  1.0077 ns | 0.0552 ns |   9.0269 ns |   9.1367 ns |         - |
