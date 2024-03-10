```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.41 ns** |   **2.942 ns** |  **0.161 ns** |  **17.30 ns** |  **17.59 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.60 ns |  14.353 ns |  0.787 ns | 121.84 ns | 123.41 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.43 ns |  16.260 ns |  0.891 ns | 115.78 ns | 117.45 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.62 ns |   7.848 ns |  0.430 ns |  90.27 ns |  91.10 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.78 ns |   4.317 ns |  0.237 ns |  44.59 ns |  45.04 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  46.10 ns |   4.370 ns |  0.240 ns |  45.82 ns |  46.25 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.00 ns |  32.857 ns |  1.801 ns | 122.92 ns | 126.11 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.95 ns** |   **9.332 ns** |  **0.512 ns** |  **54.51 ns** |  **55.51 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 379.00 ns |   9.649 ns |  0.529 ns | 378.52 ns | 379.57 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.24 ns | 112.763 ns |  6.181 ns | 348.15 ns | 359.35 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.88 ns |  23.385 ns |  1.282 ns | 286.57 ns | 289.13 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.48 ns |  18.333 ns |  1.005 ns | 134.84 ns | 136.63 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.39 ns |   1.840 ns |  0.101 ns | 138.27 ns | 138.46 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 376.77 ns | 296.948 ns | 16.277 ns | 362.76 ns | 394.62 ns | 0.0057 |     504 B |
