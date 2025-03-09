```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **66.4366 ns** |   **3.1183 ns** |  **0.1709 ns** |  **66.3313 ns** |  **66.6338 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0284 ns |   0.0162 ns |  0.0009 ns |   0.0274 ns |   0.0291 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.6742 ns |   0.7717 ns |  0.0423 ns |  72.6422 ns |  72.7221 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7574 ns |   0.0579 ns |  0.0032 ns |   2.7546 ns |   2.7609 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2017 ns |   0.3385 ns |  0.0186 ns |  50.1812 ns |  50.2175 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6490 ns |   0.8349 ns |  0.0458 ns |   0.6221 ns |   0.7018 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.7932 ns |   1.9957 ns |  0.1094 ns |  52.6670 ns |  52.8596 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0944 ns |   0.0367 ns |  0.0020 ns |   3.0921 ns |   3.0957 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **196.9077 ns** |   **6.3714 ns** |  **0.3492 ns** | **196.5047 ns** | **197.1219 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6437 ns |   0.0526 ns |  0.0029 ns |   0.6412 ns |   0.6469 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 238.8858 ns | 384.8139 ns | 21.0929 ns | 214.5309 ns | 251.2649 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2417 ns |   1.3183 ns |  0.0723 ns |   9.1827 ns |   9.3223 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 152.7613 ns |  22.0852 ns |  1.2106 ns | 151.5737 ns | 153.9936 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6238 ns |   0.0334 ns |  0.0018 ns |   0.6221 ns |   0.6258 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 154.9411 ns |   4.8061 ns |  0.2634 ns | 154.6967 ns | 155.2202 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.4336 ns |   0.6445 ns |  0.0353 ns |   9.3992 ns |   9.4698 ns |         - |
