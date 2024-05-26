```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.3990 ns** |  **0.5210 ns** | **0.0286 ns** |  **65.3789 ns** |  **65.4317 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8557 ns |  0.8750 ns | 0.0480 ns |  73.8004 ns |  73.8861 ns |         - |
| TryParseCidrBytes  | 1      |   3.0458 ns |  0.3468 ns | 0.0190 ns |   3.0334 ns |   3.0677 ns |         - |
| **NewFromCidrString**  | **3**      | **198.5908 ns** | **37.6067 ns** | **2.0613 ns** | **196.6318 ns** | **200.7412 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6017 ns |  0.0570 ns | 0.0031 ns |   0.5986 ns |   0.6049 ns |         - |
| TryParseCidrString | 3      | 225.9940 ns | 49.0164 ns | 2.6868 ns | 224.1959 ns | 229.0825 ns |         - |
| TryParseCidrBytes  | 3      |   9.1509 ns |  1.2299 ns | 0.0674 ns |   9.0749 ns |   9.2034 ns |         - |
