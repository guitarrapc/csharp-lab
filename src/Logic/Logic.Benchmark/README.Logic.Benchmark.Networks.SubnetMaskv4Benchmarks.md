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
| **FromPrefix**          | **1**      |  **17.77 ns** |  **1.547 ns** | **0.085 ns** |  **17.70 ns** |  **17.87 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.30 ns | 61.218 ns | 3.356 ns | 121.11 ns | 127.17 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.93 ns |  6.109 ns | 0.335 ns | 117.55 ns | 118.18 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.60 ns |  5.906 ns | 0.324 ns |  89.39 ns |  89.97 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.29 ns |  2.280 ns | 0.125 ns |  45.15 ns |  45.39 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.51 ns |  2.028 ns | 0.111 ns |  43.45 ns |  43.64 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.03 ns |  6.809 ns | 0.373 ns | 117.79 ns | 118.46 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.47 ns** |  **2.991 ns** | **0.164 ns** |  **55.28 ns** |  **55.56 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 369.80 ns | 14.832 ns | 0.813 ns | 368.95 ns | 370.57 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.87 ns | 21.881 ns | 1.199 ns | 358.50 ns | 360.76 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.61 ns | 17.224 ns | 0.944 ns | 273.78 ns | 275.64 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 139.04 ns |  0.175 ns | 0.010 ns | 139.03 ns | 139.05 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.59 ns | 73.149 ns | 4.010 ns | 136.19 ns | 143.22 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 373.95 ns | 59.589 ns | 3.266 ns | 370.67 ns | 377.20 ns | 0.0057 |     504 B |
