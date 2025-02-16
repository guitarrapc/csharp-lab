```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.9279 ns** | **4.6382 ns** | **0.2542 ns** |  **65.7270 ns** |  **66.2138 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0223 ns | 0.0789 ns | 0.0043 ns |   0.0196 ns |   0.0273 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.4875 ns | 5.1577 ns | 0.2827 ns |  73.2995 ns |  73.8126 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7847 ns | 0.3868 ns | 0.0212 ns |   2.7627 ns |   2.8050 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  49.8660 ns | 1.0920 ns | 0.0599 ns |  49.7984 ns |  49.9122 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6275 ns | 0.1679 ns | 0.0092 ns |   0.6217 ns |   0.6381 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  57.6722 ns | 4.1635 ns | 0.2282 ns |  57.4770 ns |  57.9231 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.1061 ns | 0.2458 ns | 0.0135 ns |   3.0908 ns |   3.1164 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **198.3027 ns** | **1.7432 ns** | **0.0956 ns** | **198.1988 ns** | **198.3868 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6490 ns | 0.1048 ns | 0.0057 ns |   0.6424 ns |   0.6531 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 209.7563 ns | 3.5545 ns | 0.1948 ns | 209.6391 ns | 209.9812 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2560 ns | 0.5760 ns | 0.0316 ns |   9.2199 ns |   9.2786 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.3559 ns | 3.3840 ns | 0.1855 ns | 148.2137 ns | 148.5657 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6260 ns | 0.1281 ns | 0.0070 ns |   0.6205 ns |   0.6339 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.0763 ns | 5.1744 ns | 0.2836 ns | 154.8177 ns | 155.3797 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.0763 ns | 1.2030 ns | 0.0659 ns |   9.0200 ns |   9.1489 ns |         - |
