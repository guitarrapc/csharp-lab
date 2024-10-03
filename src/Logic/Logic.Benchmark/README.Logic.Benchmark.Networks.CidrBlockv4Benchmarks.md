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
| **NewFromCidrString**  | **1**      |  **66.0622 ns** |  **3.6426 ns** | **0.1997 ns** |  **65.8544 ns** |  **66.2526 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0296 ns |  0.1122 ns | 0.0062 ns |   0.0256 ns |   0.0367 ns |         - |
| TryParseCidrString | 1      |  73.5171 ns |  5.5133 ns | 0.3022 ns |  73.3232 ns |  73.8653 ns |         - |
| TryParseCidrBytes  | 1      |   2.7666 ns |  0.1731 ns | 0.0095 ns |   2.7611 ns |   2.7776 ns |         - |
| **NewFromCidrString**  | **3**      | **199.0180 ns** |  **7.4851 ns** | **0.4103 ns** | **198.7746 ns** | **199.4917 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6400 ns |  0.0122 ns | 0.0007 ns |   0.6394 ns |   0.6407 ns |         - |
| TryParseCidrString | 3      | 212.5548 ns | 16.1971 ns | 0.8878 ns | 211.8831 ns | 213.5614 ns |         - |
| TryParseCidrBytes  | 3      |   9.2718 ns |  1.8175 ns | 0.0996 ns |   9.1635 ns |   9.3595 ns |         - |
