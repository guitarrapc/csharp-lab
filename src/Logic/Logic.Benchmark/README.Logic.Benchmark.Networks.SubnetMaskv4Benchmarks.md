```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.65 ns** |   **2.069 ns** | **0.113 ns** |  **17.53 ns** |  **17.76 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.72 ns |   2.771 ns | 0.152 ns | 121.59 ns | 121.89 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.72 ns |   1.481 ns | 0.081 ns | 115.66 ns | 115.81 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  90.37 ns |   6.272 ns | 0.344 ns |  90.11 ns |  90.76 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.85 ns |   5.817 ns | 0.319 ns |  44.48 ns |  45.04 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  46.41 ns |   8.123 ns | 0.445 ns |  45.92 ns |  46.79 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.23 ns | 108.907 ns | 5.970 ns | 121.16 ns | 132.08 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.76 ns** |   **5.678 ns** | **0.311 ns** |  **55.44 ns** |  **56.06 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.07 ns |  46.641 ns | 2.557 ns | 373.55 ns | 378.03 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 367.47 ns |  22.183 ns | 1.216 ns | 366.50 ns | 368.83 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 289.74 ns |   5.044 ns | 0.276 ns | 289.54 ns | 290.06 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.15 ns |   8.433 ns | 0.462 ns | 136.82 ns | 137.68 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.68 ns |  25.130 ns | 1.377 ns | 135.81 ns | 138.27 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.76 ns |  27.590 ns | 1.512 ns | 365.26 ns | 368.29 ns | 0.0057 |     504 B |
