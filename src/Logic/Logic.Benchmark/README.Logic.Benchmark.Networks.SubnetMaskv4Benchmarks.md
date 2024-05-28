```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.44 ns** |   **0.291 ns** | **0.016 ns** |  **17.42 ns** |  **17.45 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.30 ns |   7.737 ns | 0.424 ns | 119.86 ns | 120.70 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.99 ns |   2.972 ns | 0.163 ns | 117.86 ns | 118.17 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.92 ns |   5.593 ns | 0.307 ns |  91.70 ns |  92.27 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.20 ns |   2.244 ns | 0.123 ns |  45.07 ns |  45.31 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.95 ns |  14.096 ns | 0.773 ns |  44.29 ns |  45.80 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 127.70 ns |  30.658 ns | 1.680 ns | 125.82 ns | 129.07 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.77 ns** |   **6.283 ns** | **0.344 ns** |  **54.54 ns** |  **55.17 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.20 ns |  25.688 ns | 1.408 ns | 373.93 ns | 376.71 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.59 ns |  12.534 ns | 0.687 ns | 357.80 ns | 359.05 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.49 ns |   6.969 ns | 0.382 ns | 287.05 ns | 287.73 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.69 ns |   0.335 ns | 0.018 ns | 134.68 ns | 134.71 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.54 ns |   7.695 ns | 0.422 ns | 137.06 ns | 137.82 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.68 ns | 115.319 ns | 6.321 ns | 365.57 ns | 376.96 ns | 0.0057 |     504 B |
