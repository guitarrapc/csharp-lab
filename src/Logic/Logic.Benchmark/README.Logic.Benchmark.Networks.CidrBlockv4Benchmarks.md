```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.9456 ns** | **2.7882 ns** | **0.1528 ns** |  **65.9829 ns** |  **65.7776 ns** |  **66.0763 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0306 ns | 0.2931 ns | 0.0161 ns |   0.0220 ns |   0.0206 ns |   0.0491 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.0488 ns | 0.4441 ns | 0.0243 ns |  73.0393 ns |  73.0306 ns |  73.0764 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7823 ns | 0.5099 ns | 0.0279 ns |   2.7801 ns |   2.7555 ns |   2.8112 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1346 ns | 3.1398 ns | 0.1721 ns |  50.0838 ns |  49.9937 ns |  50.3264 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6183 ns | 0.0120 ns | 0.0007 ns |   0.6181 ns |   0.6178 ns |   0.6191 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.5765 ns | 0.9186 ns | 0.0504 ns |  52.5559 ns |  52.5396 ns |  52.6338 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.1100 ns | 0.7488 ns | 0.0410 ns |   3.0866 ns |   3.0861 ns |   3.1574 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.2412 ns** | **4.4943 ns** | **0.2463 ns** | **197.3766 ns** | **196.9569 ns** | **197.3902 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6463 ns | 0.1178 ns | 0.0065 ns |   0.6446 ns |   0.6409 ns |   0.6535 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.7328 ns | 3.8756 ns | 0.2124 ns | 211.6845 ns | 211.5486 ns | 211.9652 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.4582 ns | 2.3931 ns | 0.1312 ns |   9.4419 ns |   9.3360 ns |   9.5968 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.5273 ns | 2.9415 ns | 0.1612 ns | 148.5965 ns | 148.3430 ns | 148.6424 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6300 ns | 0.0863 ns | 0.0047 ns |   0.6280 ns |   0.6266 ns |   0.6354 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 154.9737 ns | 1.3203 ns | 0.0724 ns | 154.9618 ns | 154.9080 ns | 155.0512 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.0424 ns | 0.4443 ns | 0.0244 ns |   9.0527 ns |   9.0146 ns |   9.0600 ns |         - |
