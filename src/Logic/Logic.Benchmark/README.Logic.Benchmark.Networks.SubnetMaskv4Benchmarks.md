```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **16.58 ns** |   **9.898 ns** |  **0.543 ns** |  **16.11 ns** |  **17.18 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 115.55 ns |   9.966 ns |  0.546 ns | 115.05 ns | 116.13 ns | 0.0013 |     112 B |
| FromCidrAddress2    | 1      | 110.37 ns |  21.078 ns |  1.155 ns | 109.06 ns | 111.23 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  86.45 ns |   5.555 ns |  0.305 ns |  86.20 ns |  86.79 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  41.70 ns |   5.749 ns |  0.315 ns |  41.48 ns |  42.06 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.92 ns |   6.459 ns |  0.354 ns |  43.62 ns |  44.31 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.59 ns |  55.289 ns |  3.031 ns | 116.34 ns | 122.04 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **53.27 ns** |   **9.452 ns** |  **0.518 ns** |  **52.83 ns** |  **53.84 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 348.38 ns |  75.776 ns |  4.154 ns | 343.74 ns | 351.73 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 333.26 ns |  29.904 ns |  1.639 ns | 331.39 ns | 334.44 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 269.27 ns |  21.932 ns |  1.202 ns | 268.37 ns | 270.63 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 125.89 ns |  20.445 ns |  1.121 ns | 124.62 ns | 126.71 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 131.44 ns |  14.979 ns |  0.821 ns | 130.91 ns | 132.39 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 351.67 ns | 225.008 ns | 12.333 ns | 343.79 ns | 365.88 ns | 0.0057 |     504 B |
