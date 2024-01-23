```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.3558 ns** |   **8.8216 ns** | **0.4835 ns** |  **65.0559 ns** |  **65.9136 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8738 ns |   1.4519 ns | 0.0796 ns |  73.8087 ns |  73.9625 ns |         - |
| TryParseCidrBytes  | 1      |   3.0360 ns |   0.0932 ns | 0.0051 ns |   3.0319 ns |   3.0417 ns |         - |
| **NewFromCidrString**  | **10**     | **658.8209 ns** |  **14.6649 ns** | **0.8038 ns** | **658.3262 ns** | **659.7484 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3390 ns |   0.1779 ns | 0.0097 ns |   3.3281 ns |   3.3468 ns |         - |
| TryParseCidrString | 10     | 725.8563 ns | 105.0711 ns | 5.7593 ns | 719.8545 ns | 731.3378 ns |         - |
| TryParseCidrBytes  | 10     |  28.4221 ns |   1.8281 ns | 0.1002 ns |  28.3064 ns |  28.4811 ns |         - |
