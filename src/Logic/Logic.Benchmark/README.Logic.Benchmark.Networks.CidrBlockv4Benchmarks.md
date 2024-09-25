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
| **NewFromCidrString**  | **1**      |  **66.7536 ns** |  **5.7094 ns** | **0.3130 ns** |  **66.5647 ns** |  **67.1148 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0192 ns |  0.0601 ns | 0.0033 ns |   0.0157 ns |   0.0222 ns |         - |
| TryParseCidrString | 1      |  72.9557 ns |  1.0325 ns | 0.0566 ns |  72.8910 ns |  72.9960 ns |         - |
| TryParseCidrBytes  | 1      |   2.7702 ns |  0.1962 ns | 0.0108 ns |   2.7610 ns |   2.7820 ns |         - |
| **NewFromCidrString**  | **3**      | **202.6295 ns** | **15.0946 ns** | **0.8274 ns** | **202.1043 ns** | **203.5832 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6408 ns |  0.0239 ns | 0.0013 ns |   0.6399 ns |   0.6423 ns |         - |
| TryParseCidrString | 3      | 212.5013 ns |  5.4486 ns | 0.2987 ns | 212.1606 ns | 212.7178 ns |         - |
| TryParseCidrBytes  | 3      |   9.3924 ns |  0.3709 ns | 0.0203 ns |   9.3697 ns |   9.4089 ns |         - |
