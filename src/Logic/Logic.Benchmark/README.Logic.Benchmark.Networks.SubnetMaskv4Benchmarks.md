```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.44 ns** |   **1.676 ns** | **0.092 ns** |  **17.37 ns** |  **17.55 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.94 ns |   5.134 ns | 0.281 ns | 120.77 ns | 121.27 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 121.02 ns |   7.587 ns | 0.416 ns | 120.60 ns | 121.43 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.94 ns |   4.442 ns | 0.243 ns |  93.70 ns |  94.18 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  47.72 ns |   1.402 ns | 0.077 ns |  47.66 ns |  47.81 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.13 ns |  12.644 ns | 0.693 ns |  43.35 ns |  44.67 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.05 ns |  30.755 ns | 1.686 ns | 122.69 ns | 125.94 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.93 ns** |   **6.094 ns** | **0.334 ns** |  **55.55 ns** |  **56.19 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.03 ns |  13.259 ns | 0.727 ns | 373.20 ns | 374.47 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.93 ns |  19.036 ns | 1.043 ns | 351.93 ns | 354.01 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 296.42 ns | 106.554 ns | 5.841 ns | 292.67 ns | 303.15 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.75 ns |  41.817 ns | 2.292 ns | 134.10 ns | 138.36 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.29 ns |  21.470 ns | 1.177 ns | 137.31 ns | 139.59 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 368.26 ns |  21.993 ns | 1.206 ns | 367.05 ns | 369.46 ns | 0.0057 |     504 B |
