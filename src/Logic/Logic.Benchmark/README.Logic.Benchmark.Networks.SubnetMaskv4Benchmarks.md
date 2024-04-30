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
| **FromPrefix**          | **1**      |  **17.91 ns** |  **1.483 ns** | **0.081 ns** |  **17.85 ns** |  **18.00 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 124.37 ns | 24.101 ns | 1.321 ns | 122.85 ns | 125.21 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.16 ns |  9.791 ns | 0.537 ns | 116.73 ns | 117.76 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  93.70 ns |  2.885 ns | 0.158 ns |  93.52 ns |  93.81 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.04 ns |  2.337 ns | 0.128 ns |  44.89 ns |  45.12 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.14 ns | 11.243 ns | 0.616 ns |  44.53 ns |  45.76 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.69 ns | 26.385 ns | 1.446 ns | 122.82 ns | 125.36 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.72 ns** |  **2.970 ns** | **0.163 ns** |  **55.53 ns** |  **55.84 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.65 ns | 13.712 ns | 0.752 ns | 375.21 ns | 376.52 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.24 ns |  2.824 ns | 0.155 ns | 349.06 ns | 349.35 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 279.27 ns | 40.852 ns | 2.239 ns | 277.14 ns | 281.61 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.44 ns | 26.833 ns | 1.471 ns | 134.05 ns | 136.98 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.37 ns |  4.852 ns | 0.266 ns | 140.17 ns | 140.67 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.04 ns | 70.763 ns | 3.879 ns | 360.60 ns | 367.78 ns | 0.0057 |     504 B |
