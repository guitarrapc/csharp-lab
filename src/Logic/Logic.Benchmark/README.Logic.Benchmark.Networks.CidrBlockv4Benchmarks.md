```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.6076 ns** | **3.9453 ns** | **0.2163 ns** |  **65.4259 ns** |  **65.8468 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0217 ns | 0.0349 ns | 0.0019 ns |   0.0201 ns |   0.0238 ns |         - |
| TryParseCidrString | 1      |  73.0570 ns | 2.9223 ns | 0.1602 ns |  72.8776 ns |  73.1856 ns |         - |
| TryParseCidrBytes  | 1      |   2.7418 ns | 0.0277 ns | 0.0015 ns |   2.7408 ns |   2.7436 ns |         - |
| **NewFromCidrString**  | **3**      | **194.9969 ns** | **5.0222 ns** | **0.2753 ns** | **194.8088 ns** | **195.3128 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6421 ns | 0.1193 ns | 0.0065 ns |   0.6377 ns |   0.6496 ns |         - |
| TryParseCidrString | 3      | 210.5481 ns | 1.2917 ns | 0.0708 ns | 210.5010 ns | 210.6295 ns |         - |
| TryParseCidrBytes  | 3      |   9.4108 ns | 2.8306 ns | 0.1552 ns |   9.2546 ns |   9.5649 ns |         - |
