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
| **NewFromCidrString**  | **1**      |  **65.3849 ns** | **2.7809 ns** | **0.1524 ns** |  **65.2477 ns** |  **65.5490 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0195 ns | 0.0290 ns | 0.0016 ns |   0.0183 ns |   0.0213 ns |         - |
| TryParseCidrString | 1      |  76.1769 ns | 0.6152 ns | 0.0337 ns |  76.1394 ns |  76.2047 ns |         - |
| TryParseCidrBytes  | 1      |   2.7571 ns | 0.1324 ns | 0.0073 ns |   2.7516 ns |   2.7653 ns |         - |
| **NewFromCidrString**  | **3**      | **197.1371 ns** | **5.5009 ns** | **0.3015 ns** | **196.9181 ns** | **197.4810 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6399 ns | 0.0471 ns | 0.0026 ns |   0.6377 ns |   0.6428 ns |         - |
| TryParseCidrString | 3      | 211.6287 ns | 4.0653 ns | 0.2228 ns | 211.4066 ns | 211.8523 ns |         - |
| TryParseCidrBytes  | 3      |   9.2051 ns | 1.6022 ns | 0.0878 ns |   9.1068 ns |   9.2758 ns |         - |
