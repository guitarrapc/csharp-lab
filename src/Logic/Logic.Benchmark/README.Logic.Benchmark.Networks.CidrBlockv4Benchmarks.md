```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2444 ns** |  **2.1164 ns** | **0.1160 ns** |  **65.1609 ns** |  **65.3768 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.9533 ns |  0.5395 ns | 0.0296 ns |  73.9192 ns |  73.9708 ns |         - |
| TryParseCidrBytes  | 1      |   3.0413 ns |  0.1560 ns | 0.0085 ns |   3.0360 ns |   3.0512 ns |         - |
| **NewFromCidrString**  | **3**      | **197.5726 ns** | **22.0716 ns** | **1.2098 ns** | **196.5336 ns** | **198.9008 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6124 ns |  0.0961 ns | 0.0053 ns |   0.6071 ns |   0.6177 ns |         - |
| TryParseCidrString | 3      | 218.8864 ns |  0.9709 ns | 0.0532 ns | 218.8251 ns | 218.9211 ns |         - |
| TryParseCidrBytes  | 3      |   9.0796 ns |  0.4688 ns | 0.0257 ns |   9.0592 ns |   9.1085 ns |         - |
