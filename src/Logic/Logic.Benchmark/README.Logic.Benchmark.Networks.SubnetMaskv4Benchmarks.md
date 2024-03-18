```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.75 ns** |   **0.799 ns** |  **0.044 ns** |  **17.71 ns** |  **17.80 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 130.45 ns | 190.702 ns | 10.453 ns | 123.90 ns | 142.51 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.64 ns |   6.866 ns |  0.376 ns | 119.25 ns | 119.99 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.51 ns |   4.612 ns |  0.253 ns |  90.35 ns |  90.80 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.04 ns |   4.414 ns |  0.242 ns |  44.82 ns |  45.30 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  46.40 ns |   9.941 ns |  0.545 ns |  45.98 ns |  47.02 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.26 ns |   5.344 ns |  0.293 ns | 122.93 ns | 123.47 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.97 ns** |   **6.210 ns** |  **0.340 ns** |  **55.58 ns** |  **56.21 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 365.40 ns |  11.673 ns |  0.640 ns | 364.71 ns | 365.96 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 354.66 ns |  76.207 ns |  4.177 ns | 351.40 ns | 359.37 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 288.10 ns |  18.432 ns |  1.010 ns | 286.94 ns | 288.83 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.14 ns |   5.685 ns |  0.312 ns | 136.84 ns | 137.46 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.52 ns |  18.392 ns |  1.008 ns | 139.37 ns | 141.21 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.63 ns |  64.174 ns |  3.518 ns | 363.36 ns | 369.68 ns | 0.0057 |     504 B |
