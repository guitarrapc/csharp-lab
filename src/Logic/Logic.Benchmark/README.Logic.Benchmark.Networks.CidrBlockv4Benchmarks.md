```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0637 ns** | **0.5889 ns** | **0.0323 ns** |  **65.0426 ns** |  **65.1009 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.8456 ns | 0.1350 ns | 0.0074 ns |  74.8405 ns |  74.8540 ns |         - |
| TryParseCidrBytes  | 1      |   3.0377 ns | 0.0654 ns | 0.0036 ns |   3.0345 ns |   3.0416 ns |         - |
| **NewFromCidrString**  | **3**      | **195.4183 ns** | **0.7584 ns** | **0.0416 ns** | **195.3864 ns** | **195.4653 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6082 ns | 0.1148 ns | 0.0063 ns |   0.6011 ns |   0.6132 ns |         - |
| TryParseCidrString | 3      | 213.4840 ns | 6.5590 ns | 0.3595 ns | 213.1740 ns | 213.8781 ns |         - |
| TryParseCidrBytes  | 3      |   9.1934 ns | 2.6786 ns | 0.1468 ns |   9.0594 ns |   9.3504 ns |         - |
