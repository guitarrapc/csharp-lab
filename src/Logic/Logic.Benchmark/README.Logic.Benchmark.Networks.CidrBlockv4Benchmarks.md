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
| **NewFromCidrString**  | **1**      |  **67.6417 ns** |  **0.4090 ns** | **0.0224 ns** |  **67.6237 ns** |  **67.6668 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0237 ns |  0.0481 ns | 0.0026 ns |   0.0211 ns |   0.0263 ns |         - |
| TryParseCidrString | 1      |  74.4280 ns |  1.9125 ns | 0.1048 ns |  74.3074 ns |  74.4976 ns |         - |
| TryParseCidrBytes  | 1      |   2.7600 ns |  0.0495 ns | 0.0027 ns |   2.7573 ns |   2.7627 ns |         - |
| **NewFromCidrString**  | **3**      | **200.7216 ns** | **32.8408 ns** | **1.8001 ns** | **199.6402 ns** | **202.7996 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6573 ns |  0.4242 ns | 0.0233 ns |   0.6391 ns |   0.6835 ns |         - |
| TryParseCidrString | 3      | 209.0942 ns |  3.0268 ns | 0.1659 ns | 208.9149 ns | 209.2423 ns |         - |
| TryParseCidrBytes  | 3      |   9.3156 ns |  0.2519 ns | 0.0138 ns |   9.3029 ns |   9.3303 ns |         - |
