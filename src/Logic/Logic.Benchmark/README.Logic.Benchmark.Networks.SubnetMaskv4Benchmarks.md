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
| **FromPrefix**          | **1**      |  **17.89 ns** |  **0.966 ns** | **0.053 ns** |  **17.85 ns** |  **17.95 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.00 ns |  3.052 ns | 0.167 ns | 120.82 ns | 121.15 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.37 ns |  0.811 ns | 0.044 ns | 115.35 ns | 115.42 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  97.45 ns |  3.981 ns | 0.218 ns |  97.27 ns |  97.69 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.09 ns |  1.915 ns | 0.105 ns |  45.02 ns |  45.21 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.29 ns |  0.767 ns | 0.042 ns |  45.26 ns |  45.34 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.55 ns | 44.331 ns | 2.430 ns | 119.79 ns | 124.39 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.98 ns** |  **9.214 ns** | **0.505 ns** |  **55.44 ns** |  **56.43 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 377.15 ns | 13.625 ns | 0.747 ns | 376.45 ns | 377.93 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.21 ns | 20.071 ns | 1.100 ns | 348.46 ns | 350.47 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 273.91 ns | 10.296 ns | 0.564 ns | 273.50 ns | 274.55 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.66 ns |  8.918 ns | 0.489 ns | 137.13 ns | 138.10 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.60 ns |  7.005 ns | 0.384 ns | 140.22 ns | 140.99 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 378.86 ns | 68.162 ns | 3.736 ns | 376.40 ns | 383.16 ns | 0.0057 |     504 B |
