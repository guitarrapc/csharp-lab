```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.63 ns** |   **0.310 ns** | **0.017 ns** |  **17.62 ns** |  **17.65 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.37 ns |   3.605 ns | 0.198 ns | 119.19 ns | 119.58 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 114.77 ns |   4.076 ns | 0.223 ns | 114.53 ns | 114.97 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.19 ns |   6.558 ns | 0.359 ns |  88.97 ns |  89.61 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.35 ns |   2.106 ns | 0.115 ns |  45.26 ns |  45.48 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.64 ns |  12.041 ns | 0.660 ns |  43.88 ns |  45.05 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.54 ns |  30.521 ns | 1.673 ns | 119.44 ns | 122.47 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.20 ns** |   **0.471 ns** | **0.026 ns** |  **55.17 ns** |  **55.22 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 365.70 ns |   3.701 ns | 0.203 ns | 365.47 ns | 365.86 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 346.08 ns |   8.498 ns | 0.466 ns | 345.68 ns | 346.59 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.45 ns |  16.940 ns | 0.929 ns | 273.41 ns | 275.20 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.29 ns |   8.095 ns | 0.444 ns | 135.99 ns | 136.80 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.08 ns |   9.376 ns | 0.514 ns | 135.73 ns | 136.67 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 377.14 ns | 105.896 ns | 5.805 ns | 370.44 ns | 380.58 ns | 0.0057 |     504 B |
