```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **66.3021 ns** |  **1.2091 ns** | **0.0663 ns** |  **66.2364 ns** |  **66.3689 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0261 ns |  0.0573 ns | 0.0031 ns |   0.0226 ns |   0.0286 ns |         - |
| TryParseCidrString | 1      |  74.5679 ns |  0.3344 ns | 0.0183 ns |  74.5472 ns |  74.5822 ns |         - |
| TryParseCidrBytes  | 1      |   2.7507 ns |  0.1456 ns | 0.0080 ns |   2.7451 ns |   2.7598 ns |         - |
| **NewFromCidrString**  | **3**      | **194.7103 ns** |  **3.4736 ns** | **0.1904 ns** | **194.5568 ns** | **194.9234 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6436 ns |  0.1258 ns | 0.0069 ns |   0.6382 ns |   0.6513 ns |         - |
| TryParseCidrString | 3      | 210.4438 ns | 11.2466 ns | 0.6165 ns | 209.8337 ns | 211.0665 ns |         - |
| TryParseCidrBytes  | 3      |   9.4185 ns |  2.2009 ns | 0.1206 ns |   9.3311 ns |   9.5561 ns |         - |
