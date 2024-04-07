```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0560 ns** |  **0.2387 ns** | **0.0131 ns** |  **65.0450 ns** |  **65.0705 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  75.4435 ns |  1.7382 ns | 0.0953 ns |  75.3366 ns |  75.5195 ns |         - |
| TryParseCidrBytes  | 1      |   3.0360 ns |  0.0915 ns | 0.0050 ns |   3.0322 ns |   3.0417 ns |         - |
| **NewFromCidrString**  | **3**      | **197.2712 ns** |  **3.9309 ns** | **0.2155 ns** | **197.0224 ns** | **197.3961 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5991 ns |  0.0233 ns | 0.0013 ns |   0.5976 ns |   0.6001 ns |         - |
| TryParseCidrString | 3      | 213.3106 ns | 36.7273 ns | 2.0131 ns | 212.0381 ns | 215.6316 ns |         - |
| TryParseCidrBytes  | 3      |   9.3455 ns |  1.3646 ns | 0.0748 ns |   9.2708 ns |   9.4204 ns |         - |
