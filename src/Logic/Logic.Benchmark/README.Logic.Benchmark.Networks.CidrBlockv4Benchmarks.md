```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.6814 ns** |   **0.3846 ns** |  **0.0211 ns** |  **64.6588 ns** |  **64.7006 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns |  0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.6279 ns |   1.0838 ns |  0.0594 ns |  73.5813 ns |  73.6948 ns |         - |
| TryParseCidrBytes  | 1      |   3.0358 ns |   0.0981 ns |  0.0054 ns |   3.0323 ns |   3.0420 ns |         - |
| **NewFromCidrString**  | **10**     | **666.7423 ns** | **188.0251 ns** | **10.3063 ns** | **660.7358 ns** | **678.6428 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3022 ns |   0.0662 ns |  0.0036 ns |   3.2982 ns |   3.3053 ns |         - |
| TryParseCidrString | 10     | 695.9653 ns |   5.2697 ns |  0.2888 ns | 695.6538 ns | 696.2243 ns |         - |
| TryParseCidrBytes  | 10     |  28.4630 ns |   0.2995 ns |  0.0164 ns |  28.4509 ns |  28.4817 ns |         - |
