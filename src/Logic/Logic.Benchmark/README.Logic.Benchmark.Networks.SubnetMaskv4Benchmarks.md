```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.74 ns** |  **5.752 ns** | **0.315 ns** |  **17.46 ns** |  **18.09 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.13 ns |  1.874 ns | 0.103 ns | 120.01 ns | 120.19 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.44 ns |  0.779 ns | 0.043 ns | 118.40 ns | 118.48 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.72 ns |  3.874 ns | 0.212 ns |  90.60 ns |  90.97 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.15 ns |  0.560 ns | 0.031 ns |  45.11 ns |  45.17 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.83 ns |  6.439 ns | 0.353 ns |  43.46 ns |  44.17 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.32 ns | 13.099 ns | 0.718 ns | 124.69 ns | 126.10 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.19 ns** |  **3.375 ns** | **0.185 ns** |  **54.97 ns** |  **55.30 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 366.22 ns |  8.623 ns | 0.473 ns | 365.85 ns | 366.75 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 357.32 ns | 11.070 ns | 0.607 ns | 356.65 ns | 357.83 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.75 ns |  7.248 ns | 0.397 ns | 274.52 ns | 275.21 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.51 ns |  3.363 ns | 0.184 ns | 134.33 ns | 134.70 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.19 ns | 23.294 ns | 1.277 ns | 136.95 ns | 139.50 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.88 ns | 27.349 ns | 1.499 ns | 368.73 ns | 371.57 ns | 0.0057 |     504 B |
