```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.0508 ns** | **3.9050 ns** | **0.2140 ns** |  **65.0791 ns** |  **64.8239 ns** |  **65.2492 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0657 ns | 0.6750 ns | 0.0370 ns |   0.0839 ns |   0.0231 ns |   0.0901 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  74.0932 ns | 0.4970 ns | 0.0272 ns |  74.0824 ns |  74.0730 ns |  74.1242 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7759 ns | 0.5754 ns | 0.0315 ns |   2.7584 ns |   2.7570 ns |   2.8123 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2456 ns | 0.3088 ns | 0.0169 ns |  50.2417 ns |  50.2310 ns |  50.2642 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6261 ns | 0.1083 ns | 0.0059 ns |   0.6233 ns |   0.6222 ns |   0.6330 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  53.6897 ns | 2.9994 ns | 0.1644 ns |  53.6194 ns |  53.5722 ns |  53.8776 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0917 ns | 0.0580 ns | 0.0032 ns |   3.0913 ns |   3.0887 ns |   3.0950 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.2463 ns** | **6.2399 ns** | **0.3420 ns** | **197.3576 ns** | **196.8625 ns** | **197.5189 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6525 ns | 0.3271 ns | 0.0179 ns |   0.6445 ns |   0.6399 ns |   0.6730 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.1025 ns | 1.8174 ns | 0.0996 ns | 212.1570 ns | 211.9876 ns | 212.1630 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3507 ns | 0.9400 ns | 0.0515 ns |   9.3318 ns |   9.3112 ns |   9.4089 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.9526 ns | 7.5183 ns | 0.4121 ns | 148.9347 ns | 148.5498 ns | 149.3734 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6250 ns | 0.1007 ns | 0.0055 ns |   0.6219 ns |   0.6218 ns |   0.6314 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 158.4646 ns | 3.8462 ns | 0.2108 ns | 158.5277 ns | 158.2294 ns | 158.6366 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.7033 ns | 7.2085 ns | 0.3951 ns |   9.5165 ns |   9.4363 ns |  10.1572 ns |         - |
