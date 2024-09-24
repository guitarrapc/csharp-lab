```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.05 ns** |   **0.805 ns** | **0.044 ns** |  **18.00 ns** |  **18.09 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.71 ns |  10.632 ns | 0.583 ns | 123.33 ns | 124.38 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.17 ns |   7.722 ns | 0.423 ns | 118.90 ns | 119.66 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.70 ns |   4.611 ns | 0.253 ns |  89.43 ns |  89.93 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.22 ns |   3.141 ns | 0.172 ns |  45.10 ns |  45.42 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.02 ns |   0.669 ns | 0.037 ns |  45.00 ns |  45.07 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.88 ns |  21.922 ns | 1.202 ns | 119.77 ns | 122.16 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.50 ns** |   **6.711 ns** | **0.368 ns** |  **56.10 ns** |  **56.81 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 377.65 ns |  23.948 ns | 1.313 ns | 376.56 ns | 379.10 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 347.53 ns |  17.864 ns | 0.979 ns | 346.81 ns | 348.65 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 275.34 ns |  19.521 ns | 1.070 ns | 274.51 ns | 276.54 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.55 ns |  17.908 ns | 0.982 ns | 136.53 ns | 138.48 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.44 ns |  31.249 ns | 1.713 ns | 138.46 ns | 141.51 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 379.72 ns | 155.708 ns | 8.535 ns | 369.87 ns | 384.97 ns | 0.0057 |     504 B |
