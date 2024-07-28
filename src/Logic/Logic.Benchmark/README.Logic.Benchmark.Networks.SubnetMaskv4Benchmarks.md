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
| **FromPrefix**          | **1**      |  **17.73 ns** |  **0.491 ns** | **0.027 ns** |  **17.70 ns** |  **17.75 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.43 ns |  6.113 ns | 0.335 ns | 125.20 ns | 125.82 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 120.39 ns | 46.278 ns | 2.537 ns | 118.47 ns | 123.27 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.94 ns |  3.384 ns | 0.185 ns |  91.82 ns |  92.16 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.78 ns |  2.888 ns | 0.158 ns |  45.68 ns |  45.96 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  46.23 ns | 26.957 ns | 1.478 ns |  45.12 ns |  47.91 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.54 ns | 44.482 ns | 2.438 ns | 122.61 ns | 127.28 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.85 ns** |  **6.962 ns** | **0.382 ns** |  **55.42 ns** |  **56.11 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 377.02 ns |  4.869 ns | 0.267 ns | 376.79 ns | 377.31 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.60 ns | 18.555 ns | 1.017 ns | 358.77 ns | 360.73 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 283.11 ns | 38.692 ns | 2.121 ns | 281.76 ns | 285.56 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.72 ns |  4.139 ns | 0.227 ns | 134.47 ns | 134.92 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.89 ns | 11.216 ns | 0.615 ns | 137.30 ns | 138.53 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.90 ns | 11.291 ns | 0.619 ns | 367.28 ns | 368.52 ns | 0.0057 |     504 B |
