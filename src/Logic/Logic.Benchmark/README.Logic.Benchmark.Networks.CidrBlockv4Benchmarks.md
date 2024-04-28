```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **74.1999 ns** |  **4.0867 ns** | **0.2240 ns** |  **74.0334 ns** |  **74.4546 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8217 ns |  2.6728 ns | 0.1465 ns |  73.7121 ns |  73.9881 ns |         - |
| TryParseCidrBytes  | 1      |   3.0436 ns |  0.2025 ns | 0.0111 ns |   3.0323 ns |   3.0545 ns |         - |
| **NewFromCidrString**  | **3**      | **196.8556 ns** | **16.0523 ns** | **0.8799 ns** | **196.2435 ns** | **197.8639 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6408 ns |  1.2681 ns | 0.0695 ns |   0.6005 ns |   0.7211 ns |         - |
| TryParseCidrString | 3      | 211.8995 ns |  5.6194 ns | 0.3080 ns | 211.7137 ns | 212.2551 ns |         - |
| TryParseCidrBytes  | 3      |   9.1255 ns |  1.9031 ns | 0.1043 ns |   9.0521 ns |   9.2449 ns |         - |
