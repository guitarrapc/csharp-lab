```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.75 ns** |   **2.710 ns** |  **0.149 ns** |  **17.66 ns** |  **17.93 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.31 ns |  14.493 ns |  0.794 ns | 121.76 ns | 123.22 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.17 ns |   4.884 ns |  0.268 ns | 116.89 ns | 117.41 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  88.57 ns |   2.074 ns |  0.114 ns |  88.50 ns |  88.71 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  46.50 ns |   3.062 ns |  0.168 ns |  46.31 ns |  46.61 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.76 ns |   1.131 ns |  0.062 ns |  44.71 ns |  44.83 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.54 ns |  17.325 ns |  0.950 ns | 116.97 ns | 118.64 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.41 ns** |   **4.415 ns** |  **0.242 ns** |  **55.14 ns** |  **55.59 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.64 ns |  12.434 ns |  0.682 ns | 375.11 ns | 376.41 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 351.23 ns | 198.153 ns | 10.861 ns | 344.62 ns | 363.76 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 284.61 ns |  10.287 ns |  0.564 ns | 284.02 ns | 285.15 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.74 ns |   4.139 ns |  0.227 ns | 135.53 ns | 135.98 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.70 ns |  26.420 ns |  1.448 ns | 137.04 ns | 139.72 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.27 ns | 129.161 ns |  7.080 ns | 362.77 ns | 375.43 ns | 0.0057 |     504 B |
