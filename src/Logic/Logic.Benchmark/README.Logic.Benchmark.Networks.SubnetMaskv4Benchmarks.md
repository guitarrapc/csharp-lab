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
| **FromPrefix**          | **1**      |  **19.03 ns** |   **0.178 ns** | **0.010 ns** |  **19.02 ns** |  **19.04 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.08 ns |   3.162 ns | 0.173 ns | 121.91 ns | 122.26 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.45 ns |  16.881 ns | 0.925 ns | 117.47 ns | 119.31 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.69 ns |   5.418 ns | 0.297 ns |  89.44 ns |  90.02 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.90 ns |   0.602 ns | 0.033 ns |  45.86 ns |  45.92 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.38 ns |   0.851 ns | 0.047 ns |  44.32 ns |  44.41 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.90 ns |  12.956 ns | 0.710 ns | 120.11 ns | 121.49 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.53 ns** |   **2.755 ns** | **0.151 ns** |  **56.40 ns** |  **56.69 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 369.40 ns |   6.991 ns | 0.383 ns | 368.97 ns | 369.71 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.16 ns |   4.611 ns | 0.253 ns | 357.88 ns | 358.36 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.57 ns |  21.391 ns | 1.172 ns | 273.88 ns | 275.92 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.27 ns |   4.208 ns | 0.231 ns | 137.01 ns | 137.44 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 142.53 ns |  17.911 ns | 0.982 ns | 141.95 ns | 143.66 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 380.47 ns | 131.616 ns | 7.214 ns | 374.70 ns | 388.56 ns | 0.0057 |     504 B |
