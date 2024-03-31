```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.1457 ns** | **5.7489 ns** | **0.3151 ns** |  **64.7973 ns** |  **65.4108 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.0800 ns | 0.2002 ns | 0.0110 ns |  74.0699 ns |  74.0917 ns |         - |
| TryParseCidrBytes  | 1      |   3.1001 ns | 1.7251 ns | 0.0946 ns |   3.0334 ns |   3.2083 ns |         - |
| **NewFromCidrString**  | **3**      | **193.8313 ns** | **6.2130 ns** | **0.3406 ns** | **193.4545 ns** | **194.1173 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6006 ns | 0.0468 ns | 0.0026 ns |   0.5981 ns |   0.6032 ns |         - |
| TryParseCidrString | 3      | 211.9392 ns | 4.1248 ns | 0.2261 ns | 211.6915 ns | 212.1346 ns |         - |
| TryParseCidrBytes  | 3      |   9.1861 ns | 1.2735 ns | 0.0698 ns |   9.1175 ns |   9.2570 ns |         - |
