```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.89 ns** |  **0.964 ns** | **0.053 ns** |  **17.86 ns** |  **17.96 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.73 ns |  6.074 ns | 0.333 ns | 122.51 ns | 123.11 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 121.50 ns | 41.816 ns | 2.292 ns | 120.15 ns | 124.15 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.23 ns |  1.932 ns | 0.106 ns |  90.13 ns |  90.34 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.23 ns |  2.710 ns | 0.149 ns |  45.07 ns |  45.37 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.17 ns | 15.504 ns | 0.850 ns |  43.31 ns |  45.00 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.01 ns | 14.077 ns | 0.772 ns | 118.12 ns | 119.50 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.17 ns** |  **0.622 ns** | **0.034 ns** |  **56.15 ns** |  **56.21 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 372.07 ns | 96.084 ns | 5.267 ns | 368.04 ns | 378.03 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 360.37 ns | 32.097 ns | 1.759 ns | 358.37 ns | 361.67 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 283.37 ns |  9.715 ns | 0.533 ns | 283.02 ns | 283.98 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.51 ns | 22.383 ns | 1.227 ns | 136.12 ns | 138.45 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.60 ns | 21.052 ns | 1.154 ns | 136.91 ns | 138.94 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.29 ns | 66.843 ns | 3.664 ns | 365.14 ns | 371.52 ns | 0.0057 |     504 B |
