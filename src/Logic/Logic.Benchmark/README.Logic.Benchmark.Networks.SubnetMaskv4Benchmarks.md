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
| **FromPrefix**          | **1**      |  **18.03 ns** |  **6.946 ns** | **0.381 ns** |  **17.76 ns** |  **18.46 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 124.34 ns |  7.069 ns | 0.387 ns | 124.00 ns | 124.76 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.83 ns |  7.679 ns | 0.421 ns | 119.35 ns | 120.14 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.88 ns |  1.916 ns | 0.105 ns |  92.78 ns |  92.99 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.28 ns |  0.949 ns | 0.052 ns |  45.23 ns |  45.34 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.71 ns |  3.778 ns | 0.207 ns |  44.52 ns |  44.93 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.55 ns |  3.390 ns | 0.186 ns | 121.34 ns | 121.71 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.30 ns** |  **0.363 ns** | **0.020 ns** |  **56.28 ns** |  **56.32 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 365.05 ns | 19.973 ns | 1.095 ns | 364.38 ns | 366.31 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 364.19 ns | 25.480 ns | 1.397 ns | 362.66 ns | 365.39 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 276.41 ns | 19.212 ns | 1.053 ns | 275.47 ns | 277.55 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.04 ns | 12.994 ns | 0.712 ns | 135.60 ns | 136.86 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.00 ns |  3.249 ns | 0.178 ns | 136.82 ns | 137.18 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.10 ns |  3.575 ns | 0.196 ns | 364.88 ns | 365.23 ns | 0.0057 |     504 B |
