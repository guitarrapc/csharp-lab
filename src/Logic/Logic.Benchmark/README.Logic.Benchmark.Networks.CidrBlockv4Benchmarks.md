```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.6010 ns** |  **3.8459 ns** | **0.2108 ns** |  **65.3626 ns** |  **65.7627 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0176 ns |  0.0131 ns | 0.0007 ns |   0.0168 ns |   0.0182 ns |         - |
| TryParseCidrString | 1      |  72.8601 ns |  3.3234 ns | 0.1822 ns |  72.7125 ns |  73.0637 ns |         - |
| TryParseCidrBytes  | 1      |   2.7649 ns |  0.2491 ns | 0.0137 ns |   2.7560 ns |   2.7806 ns |         - |
| **NewFromCidrString**  | **3**      | **194.3831 ns** |  **5.8500 ns** | **0.3207 ns** | **194.1891 ns** | **194.7532 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6448 ns |  0.1393 ns | 0.0076 ns |   0.6395 ns |   0.6536 ns |         - |
| TryParseCidrString | 3      | 208.9988 ns | 11.6614 ns | 0.6392 ns | 208.4820 ns | 209.7135 ns |         - |
| TryParseCidrBytes  | 3      |   9.5586 ns |  1.1670 ns | 0.0640 ns |   9.5016 ns |   9.6278 ns |         - |
