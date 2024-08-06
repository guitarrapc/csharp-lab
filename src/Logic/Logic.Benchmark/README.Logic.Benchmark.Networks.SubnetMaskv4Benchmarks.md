```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.71 ns** |  **1.601 ns** | **0.088 ns** |  **17.62 ns** |  **17.80 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.71 ns |  3.614 ns | 0.198 ns | 123.54 ns | 123.92 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.79 ns |  5.563 ns | 0.305 ns | 118.61 ns | 119.15 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.49 ns |  4.785 ns | 0.262 ns |  90.24 ns |  90.76 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.43 ns |  1.799 ns | 0.099 ns |  45.35 ns |  45.54 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  46.13 ns | 29.361 ns | 1.609 ns |  45.04 ns |  47.98 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.59 ns | 19.603 ns | 1.074 ns | 118.40 ns | 120.49 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.77 ns** |  **0.993 ns** | **0.054 ns** |  **55.71 ns** |  **55.80 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 372.21 ns | 90.888 ns | 4.982 ns | 369.12 ns | 377.95 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 350.31 ns | 91.831 ns | 5.034 ns | 346.57 ns | 356.03 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 286.69 ns |  4.697 ns | 0.257 ns | 286.40 ns | 286.89 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 143.80 ns |  7.899 ns | 0.433 ns | 143.48 ns | 144.29 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 141.44 ns | 33.922 ns | 1.859 ns | 139.96 ns | 143.53 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.52 ns |  4.604 ns | 0.252 ns | 365.30 ns | 365.80 ns | 0.0057 |     504 B |
