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
| **NewFromCidrString**  | **1**      |  **64.3487 ns** | **4.2981 ns** | **0.2356 ns** |  **64.1314 ns** |  **64.5990 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0234 ns | 0.0243 ns | 0.0013 ns |   0.0220 ns |   0.0247 ns |         - |
| TryParseCidrString | 1      |  72.7144 ns | 3.2464 ns | 0.1779 ns |  72.5154 ns |  72.8582 ns |         - |
| TryParseCidrBytes  | 1      |   2.7453 ns | 0.3739 ns | 0.0205 ns |   2.7248 ns |   2.7658 ns |         - |
| **NewFromCidrString**  | **3**      | **195.1483 ns** | **9.6822 ns** | **0.5307 ns** | **194.8221 ns** | **195.7607 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6342 ns | 0.0748 ns | 0.0041 ns |   0.6298 ns |   0.6379 ns |         - |
| TryParseCidrString | 3      | 209.3359 ns | 4.4291 ns | 0.2428 ns | 209.0841 ns | 209.5685 ns |         - |
| TryParseCidrBytes  | 3      |   9.3159 ns | 0.4018 ns | 0.0220 ns |   9.2941 ns |   9.3381 ns |         - |
