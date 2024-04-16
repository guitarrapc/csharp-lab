```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.37 ns** |  **12.690 ns** | **0.696 ns** |  **17.87 ns** |  **19.17 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.10 ns |   3.888 ns | 0.213 ns | 124.94 ns | 125.34 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.74 ns |  51.562 ns | 2.826 ns | 118.03 ns | 123.00 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.02 ns |   3.026 ns | 0.166 ns |  92.84 ns |  93.16 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.21 ns |   5.133 ns | 0.281 ns |  44.99 ns |  45.53 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.66 ns |  42.689 ns | 2.340 ns |  43.81 ns |  48.29 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.35 ns |  10.919 ns | 0.599 ns | 123.66 ns | 124.72 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **58.58 ns** |  **45.352 ns** | **2.486 ns** |  **57.13 ns** |  **61.45 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 371.30 ns | 121.785 ns | 6.675 ns | 365.49 ns | 378.59 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 362.79 ns |   4.359 ns | 0.239 ns | 362.52 ns | 362.96 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 289.62 ns |  66.900 ns | 3.667 ns | 287.22 ns | 293.84 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.23 ns |  53.875 ns | 2.953 ns | 135.51 ns | 140.64 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.63 ns |  15.607 ns | 0.855 ns | 137.00 ns | 138.60 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.55 ns |  18.176 ns | 0.996 ns | 364.57 ns | 366.57 ns | 0.0057 |     504 B |
