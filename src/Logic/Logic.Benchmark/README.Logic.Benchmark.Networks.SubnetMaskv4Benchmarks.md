```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.79 ns** |  **1.205 ns** | **0.066 ns** |  **17.73 ns** |  **17.86 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.07 ns | 19.808 ns | 1.086 ns | 120.39 ns | 122.32 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.32 ns |  7.111 ns | 0.390 ns | 116.87 ns | 117.58 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.37 ns |  2.040 ns | 0.112 ns |  90.25 ns |  90.45 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.80 ns |  1.312 ns | 0.072 ns |  44.73 ns |  44.87 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.89 ns |  0.331 ns | 0.018 ns |  44.87 ns |  44.91 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.83 ns | 41.495 ns | 2.274 ns | 119.23 ns | 123.44 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.51 ns** |  **4.823 ns** | **0.264 ns** |  **55.22 ns** |  **55.72 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 372.01 ns | 21.589 ns | 1.183 ns | 371.23 ns | 373.37 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.42 ns |  5.102 ns | 0.280 ns | 356.13 ns | 356.69 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.35 ns |  5.923 ns | 0.325 ns | 274.09 ns | 274.71 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 138.06 ns |  7.572 ns | 0.415 ns | 137.74 ns | 138.53 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.93 ns | 20.744 ns | 1.137 ns | 139.85 ns | 142.12 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 376.44 ns | 15.518 ns | 0.851 ns | 375.88 ns | 377.42 ns | 0.0057 |     504 B |
