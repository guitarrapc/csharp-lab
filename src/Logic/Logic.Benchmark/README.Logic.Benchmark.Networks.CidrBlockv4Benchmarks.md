```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.2035 ns** |  **1.1119 ns** | **0.0609 ns** |  **65.1365 ns** |  **65.2556 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0289 ns |  0.0785 ns | 0.0043 ns |   0.0244 ns |   0.0330 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.4540 ns |  2.1267 ns | 0.1166 ns |  73.3596 ns |  73.5843 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7717 ns |  0.3204 ns | 0.0176 ns |   2.7608 ns |   2.7920 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1734 ns |  0.2493 ns | 0.0137 ns |  50.1643 ns |  50.1891 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6257 ns |  0.1147 ns | 0.0063 ns |   0.6217 ns |   0.6329 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.7289 ns |  2.1381 ns | 0.1172 ns |  52.6258 ns |  52.8563 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0903 ns |  0.0141 ns | 0.0008 ns |   3.0895 ns |   3.0911 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **196.5873 ns** |  **3.6066 ns** | **0.1977 ns** | **196.4218 ns** | **196.8062 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6486 ns |  0.1267 ns | 0.0069 ns |   0.6406 ns |   0.6532 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.4341 ns |  9.1511 ns | 0.5016 ns | 211.8718 ns | 212.8353 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2670 ns |  0.2496 ns | 0.0137 ns |   9.2565 ns |   9.2825 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.2100 ns | 12.4996 ns | 0.6851 ns | 148.7940 ns | 150.0007 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.5277 ns |  0.0244 ns | 0.0013 ns |   0.5263 ns |   0.5290 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 156.0022 ns |  4.2513 ns | 0.2330 ns | 155.8434 ns | 156.2697 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2901 ns |  0.4745 ns | 0.0260 ns |   9.2672 ns |   9.3184 ns |         - |
