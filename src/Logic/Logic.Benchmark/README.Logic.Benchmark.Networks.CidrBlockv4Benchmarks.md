```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.9086 ns** |  **6.3981 ns** | **0.3507 ns** |  **64.5505 ns** |  **65.2514 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.2226 ns |  0.5736 ns | 0.0314 ns |  73.1869 ns |  73.2459 ns |         - |
| TryParseCidrBytes  | 1      |   3.0348 ns |  0.0391 ns | 0.0021 ns |   3.0326 ns |   3.0369 ns |         - |
| **NewFromCidrString**  | **10**     | **657.7998 ns** | **30.4377 ns** | **1.6684 ns** | **656.7774 ns** | **659.7251 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3018 ns |  0.0747 ns | 0.0041 ns |   3.2981 ns |   3.3062 ns |         - |
| TryParseCidrString | 10     | 697.6598 ns |  9.9281 ns | 0.5442 ns | 697.0574 ns | 698.1160 ns |         - |
| TryParseCidrBytes  | 10     |  28.7585 ns |  0.5121 ns | 0.0281 ns |  28.7378 ns |  28.7904 ns |         - |
