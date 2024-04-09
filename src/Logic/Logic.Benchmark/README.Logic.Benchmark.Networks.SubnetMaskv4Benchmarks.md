```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.37 ns** |  **1.283 ns** | **0.070 ns** |  **17.29 ns** |  **17.42 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.52 ns | 15.559 ns | 0.853 ns | 119.93 ns | 121.49 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.19 ns |  5.649 ns | 0.310 ns | 116.00 ns | 116.55 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  91.67 ns |  7.009 ns | 0.384 ns |  91.40 ns |  92.11 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.67 ns |  1.721 ns | 0.094 ns |  44.57 ns |  44.76 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.47 ns |  8.723 ns | 0.478 ns |  43.02 ns |  43.97 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.06 ns |  9.858 ns | 0.540 ns | 121.48 ns | 122.55 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.60 ns** |  **2.810 ns** | **0.154 ns** |  **55.46 ns** |  **55.77 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 378.73 ns | 91.906 ns | 5.038 ns | 375.67 ns | 384.54 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.75 ns | 12.630 ns | 0.692 ns | 348.95 ns | 350.23 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 298.37 ns | 12.509 ns | 0.686 ns | 297.79 ns | 299.13 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.44 ns | 12.214 ns | 0.669 ns | 133.66 ns | 134.84 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.44 ns |  8.839 ns | 0.484 ns | 138.16 ns | 139.00 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 358.83 ns | 30.386 ns | 1.666 ns | 356.95 ns | 360.14 ns | 0.0057 |     504 B |
