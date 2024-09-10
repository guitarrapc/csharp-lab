```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0319 ns** |  **2.6777 ns** | **0.1468 ns** |  **64.9412 ns** |  **65.2012 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0229 ns |  0.0571 ns | 0.0031 ns |   0.0193 ns |   0.0250 ns |         - |
| TryParseCidrString | 1      |  72.9420 ns |  0.5704 ns | 0.0313 ns |  72.9159 ns |  72.9767 ns |         - |
| TryParseCidrBytes  | 1      |   2.7480 ns |  0.0806 ns | 0.0044 ns |   2.7446 ns |   2.7530 ns |         - |
| **NewFromCidrString**  | **3**      | **197.4096 ns** | **19.9050 ns** | **1.0911 ns** | **196.5383 ns** | **198.6333 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6411 ns |  0.1810 ns | 0.0099 ns |   0.6353 ns |   0.6525 ns |         - |
| TryParseCidrString | 3      | 213.8798 ns | 46.9615 ns | 2.5741 ns | 210.9385 ns | 215.7215 ns |         - |
| TryParseCidrBytes  | 3      |   9.3010 ns |  1.6591 ns | 0.0909 ns |   9.2299 ns |   9.4034 ns |         - |
