```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.98 ns** |   **1.733 ns** |  **0.095 ns** |  **17.90 ns** |  **18.08 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.66 ns |   7.028 ns |  0.385 ns | 120.23 ns | 120.98 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.38 ns |  29.966 ns |  1.643 ns | 116.39 ns | 119.28 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.78 ns |   4.992 ns |  0.274 ns |  93.60 ns |  94.09 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.88 ns |   1.310 ns |  0.072 ns |  45.80 ns |  45.94 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.62 ns |  19.344 ns |  1.060 ns |  44.95 ns |  46.84 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.67 ns |  47.728 ns |  2.616 ns | 118.20 ns | 123.41 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.74 ns** |   **1.423 ns** |  **0.078 ns** |  **56.65 ns** |  **56.79 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 377.64 ns |  13.932 ns |  0.764 ns | 377.07 ns | 378.51 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 361.67 ns |  15.252 ns |  0.836 ns | 360.87 ns | 362.54 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 299.77 ns |  21.379 ns |  1.172 ns | 298.99 ns | 301.12 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.96 ns |   8.964 ns |  0.491 ns | 135.39 ns | 136.26 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.83 ns |  67.415 ns |  3.695 ns | 137.22 ns | 144.60 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.33 ns | 203.412 ns | 11.150 ns | 360.81 ns | 381.95 ns | 0.0057 |     504 B |
