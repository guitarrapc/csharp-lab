```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.00 ns** |  **1.911 ns** | **0.105 ns** |  **17.89 ns** |  **18.10 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.46 ns |  3.470 ns | 0.190 ns | 122.32 ns | 122.68 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.12 ns |  2.876 ns | 0.158 ns | 117.99 ns | 118.30 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.73 ns |  4.268 ns | 0.234 ns |  93.47 ns |  93.93 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.82 ns |  1.568 ns | 0.086 ns |  44.75 ns |  44.92 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.71 ns |  0.089 ns | 0.005 ns |  44.71 ns |  44.72 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.64 ns | 35.924 ns | 1.969 ns | 118.60 ns | 122.53 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.72 ns** |  **2.783 ns** | **0.153 ns** |  **55.59 ns** |  **55.89 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 367.31 ns | 21.615 ns | 1.185 ns | 366.17 ns | 368.53 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 372.33 ns | 13.787 ns | 0.756 ns | 371.73 ns | 373.18 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 291.66 ns |  2.063 ns | 0.113 ns | 291.54 ns | 291.76 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.52 ns |  3.048 ns | 0.167 ns | 136.40 ns | 136.71 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.63 ns | 28.969 ns | 1.588 ns | 137.53 ns | 140.45 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 376.57 ns | 37.497 ns | 2.055 ns | 374.91 ns | 378.87 ns | 0.0057 |     504 B |
