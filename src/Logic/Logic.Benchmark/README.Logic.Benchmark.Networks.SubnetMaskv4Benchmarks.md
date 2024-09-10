```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.31 ns** |   **0.445 ns** | **0.024 ns** |  **17.28 ns** |  **17.33 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 127.59 ns | 142.654 ns | 7.819 ns | 123.02 ns | 136.62 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.77 ns |   4.322 ns | 0.237 ns | 117.49 ns | 117.92 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  88.73 ns |   2.450 ns | 0.134 ns |  88.64 ns |  88.88 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.71 ns |   2.167 ns | 0.119 ns |  44.59 ns |  44.83 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.18 ns |   0.778 ns | 0.043 ns |  43.13 ns |  43.22 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.54 ns |  22.865 ns | 1.253 ns | 117.72 ns | 119.99 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.01 ns** |   **6.067 ns** | **0.333 ns** |  **53.75 ns** |  **54.39 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.20 ns |  12.654 ns | 0.694 ns | 374.41 ns | 375.73 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.12 ns |  26.995 ns | 1.480 ns | 354.41 ns | 356.98 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 278.34 ns |  10.501 ns | 0.576 ns | 277.90 ns | 278.99 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.53 ns |   3.668 ns | 0.201 ns | 133.34 ns | 133.74 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.97 ns |   3.750 ns | 0.206 ns | 136.84 ns | 137.21 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.47 ns |  34.636 ns | 1.899 ns | 364.41 ns | 368.14 ns | 0.0057 |     504 B |
