```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.67 ns** |   **1.075 ns** | **0.059 ns** |  **17.60 ns** |  **17.71 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.80 ns |  19.535 ns | 1.071 ns | 120.10 ns | 122.03 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 120.06 ns |   8.875 ns | 0.486 ns | 119.68 ns | 120.60 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.75 ns |   2.817 ns | 0.154 ns |  91.59 ns |  91.90 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.47 ns |   1.769 ns | 0.097 ns |  45.40 ns |  45.58 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  50.19 ns |   1.386 ns | 0.076 ns |  50.13 ns |  50.28 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.56 ns |  37.422 ns | 2.051 ns | 117.33 ns | 121.35 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.79 ns** |   **1.608 ns** | **0.088 ns** |  **55.70 ns** |  **55.87 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 364.32 ns |   5.019 ns | 0.275 ns | 364.04 ns | 364.59 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 350.07 ns |  10.170 ns | 0.557 ns | 349.57 ns | 350.67 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 281.79 ns |  96.181 ns | 5.272 ns | 278.74 ns | 287.88 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.93 ns |   4.688 ns | 0.257 ns | 134.76 ns | 135.23 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.41 ns |   5.679 ns | 0.311 ns | 137.18 ns | 137.76 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 371.34 ns | 102.998 ns | 5.646 ns | 364.82 ns | 374.61 ns | 0.0057 |     504 B |
