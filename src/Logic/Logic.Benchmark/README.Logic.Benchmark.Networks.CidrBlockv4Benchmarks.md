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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **68.5210 ns** | **4.6666 ns** | **0.2558 ns** |  **68.3614 ns** |  **68.8161 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0214 ns | 0.0839 ns | 0.0046 ns |   0.0182 ns |   0.0267 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.3554 ns | 5.9843 ns | 0.3280 ns |  73.1379 ns |  73.7327 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7715 ns | 0.3657 ns | 0.0200 ns |   2.7581 ns |   2.7946 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.0865 ns | 2.6530 ns | 0.1454 ns |  49.9606 ns |  50.2457 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6262 ns | 0.1576 ns | 0.0086 ns |   0.6208 ns |   0.6361 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.7103 ns | 4.7960 ns | 0.2629 ns |  52.5097 ns |  53.0079 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0921 ns | 0.2149 ns | 0.0118 ns |   3.0845 ns |   3.1057 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **198.5695 ns** | **1.5414 ns** | **0.0845 ns** | **198.4976 ns** | **198.6626 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6449 ns | 0.1143 ns | 0.0063 ns |   0.6406 ns |   0.6521 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 210.5999 ns | 8.2183 ns | 0.4505 ns | 210.0903 ns | 210.9450 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2676 ns | 0.3925 ns | 0.0215 ns |   9.2447 ns |   9.2873 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.3101 ns | 7.1962 ns | 0.3945 ns | 148.0804 ns | 148.7655 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.4759 ns | 0.1089 ns | 0.0060 ns |   0.4690 ns |   0.4794 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.4889 ns | 3.5237 ns | 0.1931 ns | 155.2693 ns | 155.6323 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.4055 ns | 1.0390 ns | 0.0569 ns |   9.3624 ns |   9.4701 ns |         - |
