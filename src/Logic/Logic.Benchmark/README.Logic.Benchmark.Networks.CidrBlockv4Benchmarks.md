```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.9703 ns** | **3.0565 ns** | **0.1675 ns** |  **65.8594 ns** |  **66.1630 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0192 ns | 0.0060 ns | 0.0003 ns |   0.0190 ns |   0.0196 ns |         - |
| TryParseCidrString | 1      |  72.9019 ns | 0.4289 ns | 0.0235 ns |  72.8751 ns |  72.9187 ns |         - |
| TryParseCidrBytes  | 1      |   2.7469 ns | 0.0156 ns | 0.0009 ns |   2.7459 ns |   2.7475 ns |         - |
| **NewFromCidrString**  | **3**      | **194.4709 ns** | **6.4026 ns** | **0.3509 ns** | **194.0752 ns** | **194.7442 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6418 ns | 0.0424 ns | 0.0023 ns |   0.6395 ns |   0.6441 ns |         - |
| TryParseCidrString | 3      | 207.9196 ns | 8.2107 ns | 0.4501 ns | 207.5967 ns | 208.4337 ns |         - |
| TryParseCidrBytes  | 3      |   9.3015 ns | 1.2268 ns | 0.0672 ns |   9.2345 ns |   9.3690 ns |         - |
