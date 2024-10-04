```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.21 ns** |   **2.632 ns** | **0.144 ns** |  **18.10 ns** |  **18.37 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.27 ns |   1.115 ns | 0.061 ns | 123.21 ns | 123.34 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.91 ns |  11.462 ns | 0.628 ns | 118.51 ns | 119.64 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.61 ns |  22.446 ns | 1.230 ns |  91.53 ns |  93.95 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.45 ns |   0.799 ns | 0.044 ns |  45.40 ns |  45.49 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.59 ns |  16.451 ns | 0.902 ns |  43.98 ns |  45.63 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.99 ns |  43.995 ns | 2.412 ns | 119.00 ns | 123.67 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.20 ns** |   **5.139 ns** | **0.282 ns** |  **56.04 ns** |  **56.53 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 379.84 ns |  13.932 ns | 0.764 ns | 379.37 ns | 380.72 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 350.22 ns |  17.136 ns | 0.939 ns | 349.27 ns | 351.15 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 276.20 ns |  10.496 ns | 0.575 ns | 275.58 ns | 276.71 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 138.67 ns |  12.263 ns | 0.672 ns | 138.16 ns | 139.43 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.51 ns |  38.332 ns | 2.101 ns | 137.30 ns | 140.94 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 376.54 ns | 127.902 ns | 7.011 ns | 369.41 ns | 383.43 ns | 0.0057 |     504 B |
