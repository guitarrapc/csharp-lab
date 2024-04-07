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
| **FromPrefix**          | **1**      |  **17.68 ns** |   **2.932 ns** |  **0.161 ns** |  **17.53 ns** |  **17.85 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.73 ns |  47.119 ns |  2.583 ns | 119.18 ns | 123.71 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.13 ns |  15.190 ns |  0.833 ns | 116.22 ns | 117.86 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.39 ns |   1.972 ns |  0.108 ns |  91.28 ns |  91.49 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.04 ns |   3.680 ns |  0.202 ns |  44.85 ns |  45.25 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.49 ns |  15.428 ns |  0.846 ns |  44.55 ns |  46.17 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.40 ns |  15.757 ns |  0.864 ns | 121.72 ns | 123.37 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.24 ns** |   **9.667 ns** |  **0.530 ns** |  **54.83 ns** |  **55.84 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 365.37 ns |  85.599 ns |  4.692 ns | 362.42 ns | 370.78 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 348.88 ns |  22.877 ns |  1.254 ns | 348.02 ns | 350.32 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 280.62 ns |  11.116 ns |  0.609 ns | 280.14 ns | 281.31 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.62 ns |   4.329 ns |  0.237 ns | 134.47 ns | 134.90 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.04 ns |   8.334 ns |  0.457 ns | 135.77 ns | 136.56 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.16 ns | 190.127 ns | 10.422 ns | 360.60 ns | 379.18 ns | 0.0057 |     504 B |
