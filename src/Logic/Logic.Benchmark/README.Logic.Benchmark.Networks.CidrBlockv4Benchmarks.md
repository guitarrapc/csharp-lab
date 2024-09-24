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
| **NewFromCidrString**  | **1**      |  **71.0560 ns** |  **2.9297 ns** | **0.1606 ns** |  **70.9460 ns** |  **71.2403 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0228 ns |  0.0505 ns | 0.0028 ns |   0.0200 ns |   0.0255 ns |         - |
| TryParseCidrString | 1      |  73.2052 ns | 10.8534 ns | 0.5949 ns |  72.7376 ns |  73.8748 ns |         - |
| TryParseCidrBytes  | 1      |   2.7672 ns |  0.2302 ns | 0.0126 ns |   2.7586 ns |   2.7817 ns |         - |
| **NewFromCidrString**  | **3**      | **212.2248 ns** | **10.1121 ns** | **0.5543 ns** | **211.5872 ns** | **212.5916 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6600 ns |  0.2365 ns | 0.0130 ns |   0.6514 ns |   0.6749 ns |         - |
| TryParseCidrString | 3      | 212.8332 ns |  7.9363 ns | 0.4350 ns | 212.5403 ns | 213.3330 ns |         - |
| TryParseCidrBytes  | 3      |   9.3490 ns |  1.0522 ns | 0.0577 ns |   9.2915 ns |   9.4069 ns |         - |
