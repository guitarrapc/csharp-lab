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
| **FromPrefix**          | **1**      |  **17.89 ns** |   **6.097 ns** | **0.334 ns** |  **17.51 ns** |  **18.15 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.13 ns |   9.190 ns | 0.504 ns | 121.74 ns | 122.70 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.24 ns |  19.669 ns | 1.078 ns | 117.50 ns | 119.48 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  88.69 ns |   5.301 ns | 0.291 ns |  88.48 ns |  89.02 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.51 ns |   0.314 ns | 0.017 ns |  45.50 ns |  45.53 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.05 ns |   1.227 ns | 0.067 ns |  44.00 ns |  44.13 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.38 ns |   4.210 ns | 0.231 ns | 119.14 ns | 119.59 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.52 ns** |  **32.486 ns** | **1.781 ns** |  **55.06 ns** |  **58.51 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 369.56 ns |  41.470 ns | 2.273 ns | 367.08 ns | 371.54 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 360.74 ns | 169.173 ns | 9.273 ns | 354.74 ns | 371.42 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.16 ns |  71.592 ns | 3.924 ns | 284.65 ns | 291.68 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.05 ns |  25.207 ns | 1.382 ns | 132.98 ns | 135.61 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.91 ns |   7.143 ns | 0.392 ns | 139.59 ns | 140.35 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 370.16 ns |  30.520 ns | 1.673 ns | 368.27 ns | 371.44 ns | 0.0057 |     504 B |
