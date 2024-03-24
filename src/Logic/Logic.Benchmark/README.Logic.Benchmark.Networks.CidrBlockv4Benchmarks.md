```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.3464 ns** |  **2.8139 ns** | **0.1542 ns** |  **65.2450 ns** |  **65.5239 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8239 ns |  1.2204 ns | 0.0669 ns |  73.7624 ns |  73.8951 ns |         - |
| TryParseCidrBytes  | 1      |   3.0444 ns |  0.2173 ns | 0.0119 ns |   3.0372 ns |   3.0582 ns |         - |
| **NewFromCidrString**  | **3**      | **196.5016 ns** | **13.3971 ns** | **0.7343 ns** | **195.7111 ns** | **197.1625 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6065 ns |  0.1486 ns | 0.0081 ns |   0.6017 ns |   0.6159 ns |         - |
| TryParseCidrString | 3      | 211.0280 ns | 12.9134 ns | 0.7078 ns | 210.2836 ns | 211.6925 ns |         - |
| TryParseCidrBytes  | 3      |   9.1922 ns |  2.5646 ns | 0.1406 ns |   9.0792 ns |   9.3496 ns |         - |
