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
| **NewFromCidrString**  | **1**      |  **65.6880 ns** |  **7.2578 ns** | **0.3978 ns** |  **65.2287 ns** |  **65.9235 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0295 ns |  0.2062 ns | 0.0113 ns |   0.0201 ns |   0.0420 ns |         - |
| TryParseCidrString | 1      |  72.8447 ns |  0.6486 ns | 0.0356 ns |  72.8140 ns |  72.8836 ns |         - |
| TryParseCidrBytes  | 1      |   2.7670 ns |  0.2582 ns | 0.0142 ns |   2.7568 ns |   2.7831 ns |         - |
| **NewFromCidrString**  | **3**      | **203.8195 ns** | **50.0741 ns** | **2.7447 ns** | **200.7965 ns** | **206.1554 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6452 ns |  0.1249 ns | 0.0068 ns |   0.6401 ns |   0.6530 ns |         - |
| TryParseCidrString | 3      | 228.6310 ns |  5.6485 ns | 0.3096 ns | 228.3153 ns | 228.9341 ns |         - |
| TryParseCidrBytes  | 3      |   9.5410 ns |  0.3920 ns | 0.0215 ns |   9.5215 ns |   9.5640 ns |         - |
