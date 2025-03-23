```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.5991 ns** | **3.9386 ns** | **0.2159 ns** |  **65.3562 ns** |  **65.7692 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0215 ns | 0.0342 ns | 0.0019 ns |   0.0201 ns |   0.0236 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  76.1676 ns | 4.0757 ns | 0.2234 ns |  75.9175 ns |  76.3475 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7607 ns | 0.1126 ns | 0.0062 ns |   2.7566 ns |   2.7678 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  51.0970 ns | 0.2617 ns | 0.0143 ns |  51.0833 ns |  51.1119 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6243 ns | 0.0701 ns | 0.0038 ns |   0.6219 ns |   0.6287 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.9131 ns | 8.4234 ns | 0.4617 ns |  52.6396 ns |  53.4462 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.1004 ns | 0.2122 ns | 0.0116 ns |   3.0899 ns |   3.1129 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **202.8475 ns** | **0.7385 ns** | **0.0405 ns** | **202.8085 ns** | **202.8893 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.3877 ns | 0.0170 ns | 0.0009 ns |   0.3869 ns |   0.3887 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 209.3243 ns | 8.0038 ns | 0.4387 ns | 208.9673 ns | 209.8140 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.0234 ns | 0.5018 ns | 0.0275 ns |   9.0048 ns |   9.0550 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.7409 ns | 0.8147 ns | 0.0447 ns | 148.6951 ns | 148.7843 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6228 ns | 0.0215 ns | 0.0012 ns |   0.6218 ns |   0.6241 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.4474 ns | 3.8574 ns | 0.2114 ns | 155.2081 ns | 155.6091 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2453 ns | 0.0955 ns | 0.0052 ns |   9.2402 ns |   9.2506 ns |         - |
