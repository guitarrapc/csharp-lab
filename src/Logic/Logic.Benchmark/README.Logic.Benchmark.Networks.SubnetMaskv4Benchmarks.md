```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.76 ns** |  **1.267 ns** | **0.069 ns** |  **17.71 ns** |  **17.84 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.13 ns |  8.232 ns | 0.451 ns | 121.71 ns | 122.60 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.59 ns | 11.439 ns | 0.627 ns | 118.04 ns | 119.27 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.64 ns |  2.733 ns | 0.150 ns |  89.54 ns |  89.82 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.72 ns |  1.045 ns | 0.057 ns |  45.67 ns |  45.79 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.41 ns | 13.397 ns | 0.734 ns |  43.89 ns |  45.25 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.53 ns |  4.507 ns | 0.247 ns | 123.29 ns | 123.78 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.00 ns** |  **4.642 ns** | **0.254 ns** |  **55.77 ns** |  **56.27 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 370.15 ns |  9.021 ns | 0.494 ns | 369.60 ns | 370.56 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 348.26 ns | 13.000 ns | 0.713 ns | 347.44 ns | 348.72 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 285.69 ns | 18.119 ns | 0.993 ns | 285.02 ns | 286.83 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.89 ns |  3.202 ns | 0.176 ns | 133.78 ns | 134.09 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.68 ns | 25.547 ns | 1.400 ns | 139.09 ns | 141.72 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.22 ns | 12.720 ns | 0.697 ns | 365.77 ns | 367.02 ns | 0.0057 |     504 B |
