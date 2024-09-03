```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.52 ns** |  **2.109 ns** | **0.116 ns** |  **17.40 ns** |  **17.63 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.88 ns |  3.148 ns | 0.173 ns | 123.71 ns | 124.05 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.10 ns |  4.659 ns | 0.255 ns | 117.85 ns | 118.36 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.17 ns |  3.148 ns | 0.173 ns |  90.01 ns |  90.35 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.37 ns |  0.769 ns | 0.042 ns |  44.33 ns |  44.41 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.21 ns |  4.836 ns | 0.265 ns |  43.02 ns |  43.52 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.47 ns | 26.809 ns | 1.469 ns | 117.91 ns | 120.82 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.36 ns** |  **2.047 ns** | **0.112 ns** |  **54.23 ns** |  **54.43 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 373.20 ns |  5.952 ns | 0.326 ns | 372.83 ns | 373.44 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.58 ns |  9.321 ns | 0.511 ns | 352.03 ns | 353.04 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 275.72 ns | 14.558 ns | 0.798 ns | 274.83 ns | 276.36 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.74 ns |  6.444 ns | 0.353 ns | 133.34 ns | 134.01 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.85 ns |  4.780 ns | 0.262 ns | 139.58 ns | 140.10 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 368.76 ns | 30.882 ns | 1.693 ns | 367.03 ns | 370.41 ns | 0.0057 |     504 B |
