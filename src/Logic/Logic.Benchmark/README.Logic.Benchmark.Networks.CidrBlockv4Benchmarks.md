```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.6817 ns** | **4.2793 ns** | **0.2346 ns** |  **65.5074 ns** |  **65.9484 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.3087 ns | 0.8715 ns | 0.0478 ns |  74.2642 ns |  74.3592 ns |         - |
| TryParseCidrBytes  | 1      |   3.0490 ns | 0.4890 ns | 0.0268 ns |   3.0334 ns |   3.0800 ns |         - |
| **NewFromCidrString**  | **3**      | **196.0561 ns** | **4.4052 ns** | **0.2415 ns** | **195.7821 ns** | **196.2380 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5995 ns | 0.0057 ns | 0.0003 ns |   0.5991 ns |   0.5997 ns |         - |
| TryParseCidrString | 3      | 218.7939 ns | 2.3107 ns | 0.1267 ns | 218.6611 ns | 218.9133 ns |         - |
| TryParseCidrBytes  | 3      |   9.2382 ns | 1.8367 ns | 0.1007 ns |   9.1711 ns |   9.3540 ns |         - |
