```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.9325 ns** | **0.8482 ns** | **0.0465 ns** |  **64.9571 ns** |  **64.8788 ns** |  **64.9614 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.2454 ns | 2.2833 ns | 0.1252 ns |   0.3098 ns |   0.1011 ns |   0.3252 ns |         - |
| TryParseCidrString | 1      |  72.7161 ns | 4.5530 ns | 0.2496 ns |  72.6013 ns |  72.5446 ns |  73.0024 ns |         - |
| TryParseCidrBytes  | 1      |   2.7534 ns | 0.2929 ns | 0.0161 ns |   2.7464 ns |   2.7421 ns |   2.7718 ns |         - |
| **NewFromCidrString**  | **3**      | **197.4730 ns** | **3.3016 ns** | **0.1810 ns** | **197.4249 ns** | **197.3209 ns** | **197.6732 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6392 ns | 0.0421 ns | 0.0023 ns |   0.6382 ns |   0.6376 ns |   0.6419 ns |         - |
| TryParseCidrString | 3      | 210.9637 ns | 1.6100 ns | 0.0882 ns | 210.9653 ns | 210.8747 ns | 211.0512 ns |         - |
| TryParseCidrBytes  | 3      |   9.3747 ns | 3.1274 ns | 0.1714 ns |   9.3145 ns |   9.2415 ns |   9.5681 ns |         - |
