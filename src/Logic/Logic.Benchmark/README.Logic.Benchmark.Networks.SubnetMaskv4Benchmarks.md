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
| **FromPrefix**          | **1**      |  **17.33 ns** |  **1.227 ns** | **0.067 ns** |  **17.27 ns** |  **17.40 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.30 ns | 13.363 ns | 0.732 ns | 119.49 ns | 120.92 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.58 ns |  3.232 ns | 0.177 ns | 116.46 ns | 116.78 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.58 ns |  2.665 ns | 0.146 ns |  92.42 ns |  92.69 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.06 ns |  1.783 ns | 0.098 ns |  44.96 ns |  45.15 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.02 ns | 14.428 ns | 0.791 ns |  44.30 ns |  45.87 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.44 ns | 33.870 ns | 1.857 ns | 121.34 ns | 124.85 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.84 ns** |  **2.518 ns** | **0.138 ns** |  **55.69 ns** |  **55.94 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.52 ns | 33.548 ns | 1.839 ns | 372.40 ns | 375.65 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 360.03 ns | 18.379 ns | 1.007 ns | 359.06 ns | 361.07 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 279.31 ns | 27.497 ns | 1.507 ns | 278.23 ns | 281.03 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.57 ns |  5.867 ns | 0.322 ns | 134.21 ns | 134.82 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.84 ns | 41.079 ns | 2.252 ns | 139.44 ns | 143.44 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 359.28 ns | 18.649 ns | 1.022 ns | 358.13 ns | 360.06 ns | 0.0057 |     504 B |
