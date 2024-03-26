```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.94 ns** |  **2.689 ns** | **0.147 ns** |  **17.79 ns** |  **18.09 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.66 ns |  9.570 ns | 0.525 ns | 119.06 ns | 119.97 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.20 ns | 12.051 ns | 0.661 ns | 115.55 ns | 116.87 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  90.01 ns |  9.824 ns | 0.539 ns |  89.67 ns |  90.63 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.38 ns |  1.889 ns | 0.104 ns |  45.26 ns |  45.45 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.81 ns | 24.129 ns | 1.323 ns |  43.58 ns |  46.21 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.37 ns |  9.882 ns | 0.542 ns | 120.78 ns | 121.84 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.91 ns** |  **4.872 ns** | **0.267 ns** |  **55.69 ns** |  **56.20 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.33 ns | 50.454 ns | 2.766 ns | 372.71 ns | 377.52 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.57 ns | 20.361 ns | 1.116 ns | 351.29 ns | 353.29 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 285.41 ns |  6.396 ns | 0.351 ns | 285.13 ns | 285.81 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.28 ns |  4.626 ns | 0.254 ns | 135.05 ns | 135.55 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.25 ns | 18.831 ns | 1.032 ns | 137.64 ns | 139.44 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 362.75 ns | 64.295 ns | 3.524 ns | 358.88 ns | 365.77 ns | 0.0057 |     504 B |
