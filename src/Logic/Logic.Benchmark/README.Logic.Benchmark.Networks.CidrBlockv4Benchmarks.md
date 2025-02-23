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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.1170 ns** | **0.1266 ns** | **0.0069 ns** |  **65.1090 ns** |  **65.1213 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0210 ns | 0.0056 ns | 0.0003 ns |   0.0208 ns |   0.0214 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.8697 ns | 0.8768 ns | 0.0481 ns |  73.8150 ns |  73.9051 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7617 ns | 0.0394 ns | 0.0022 ns |   2.7593 ns |   2.7636 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  51.6215 ns | 1.3643 ns | 0.0748 ns |  51.5670 ns |  51.7067 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6315 ns | 0.1673 ns | 0.0092 ns |   0.6209 ns |   0.6368 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.5296 ns | 0.8162 ns | 0.0447 ns |  52.4780 ns |  52.5578 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0949 ns | 0.2077 ns | 0.0114 ns |   3.0875 ns |   3.1080 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **200.0695 ns** | **3.8092 ns** | **0.2088 ns** | **199.8559 ns** | **200.2731 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6459 ns | 0.0770 ns | 0.0042 ns |   0.6426 ns |   0.6506 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 214.5839 ns | 1.5902 ns | 0.0872 ns | 214.4975 ns | 214.6718 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2873 ns | 1.2530 ns | 0.0687 ns |   9.2084 ns |   9.3339 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 151.7313 ns | 5.1200 ns | 0.2806 ns | 151.5061 ns | 152.0457 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6255 ns | 0.0797 ns | 0.0044 ns |   0.6221 ns |   0.6304 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 154.5415 ns | 2.2529 ns | 0.1235 ns | 154.4343 ns | 154.6765 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3020 ns | 0.3617 ns | 0.0198 ns |   9.2812 ns |   9.3206 ns |         - |
