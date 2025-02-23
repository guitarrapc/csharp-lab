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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.9269 ns** |  **7.3377 ns** | **0.4022 ns** |  **65.5862 ns** |  **66.3706 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0272 ns |  0.2135 ns | 0.0117 ns |   0.0179 ns |   0.0403 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.6858 ns |  0.4260 ns | 0.0234 ns |  72.6697 ns |  72.7126 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7984 ns |  0.4484 ns | 0.0246 ns |   2.7823 ns |   2.8267 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  51.6452 ns |  1.8084 ns | 0.0991 ns |  51.5705 ns |  51.7577 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6208 ns |  0.0632 ns | 0.0035 ns |   0.6185 ns |   0.6248 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  53.0167 ns |  8.2846 ns | 0.4541 ns |  52.4965 ns |  53.3340 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.1290 ns |  0.6458 ns | 0.0354 ns |   3.0887 ns |   3.1552 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **202.6268 ns** | **74.1571 ns** | **4.0648 ns** | **200.0898 ns** | **207.3152 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6394 ns |  0.0392 ns | 0.0021 ns |   0.6372 ns |   0.6415 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 213.8589 ns | 17.8752 ns | 0.9798 ns | 212.8500 ns | 214.8068 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.5411 ns |  1.9189 ns | 0.1052 ns |   9.4212 ns |   9.6180 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.0018 ns | 10.2161 ns | 0.5600 ns | 147.6307 ns | 148.6459 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.5654 ns |  1.0303 ns | 0.0565 ns |   0.5322 ns |   0.6306 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 156.1998 ns | 25.0140 ns | 1.3711 ns | 155.2199 ns | 157.7667 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.1474 ns |  0.7504 ns | 0.0411 ns |   9.1017 ns |   9.1816 ns |         - |
