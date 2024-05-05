```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.28 ns** |   **6.307 ns** | **0.346 ns** |  **18.07 ns** |  **18.68 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.72 ns |   5.920 ns | 0.324 ns | 121.46 ns | 122.08 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 121.18 ns |   3.068 ns | 0.168 ns | 121.00 ns | 121.34 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  94.30 ns |   1.586 ns | 0.087 ns |  94.24 ns |  94.40 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  46.20 ns |   2.695 ns | 0.148 ns |  46.04 ns |  46.33 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.54 ns |   6.724 ns | 0.369 ns |  45.28 ns |  45.96 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.24 ns |  51.362 ns | 2.815 ns | 119.67 ns | 125.25 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **57.47 ns** |   **1.418 ns** | **0.078 ns** |  **57.40 ns** |  **57.55 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.27 ns |  11.502 ns | 0.630 ns | 373.66 ns | 374.92 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 369.01 ns |  15.588 ns | 0.854 ns | 368.04 ns | 369.67 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 291.19 ns |  13.465 ns | 0.738 ns | 290.52 ns | 291.98 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.01 ns |   3.164 ns | 0.173 ns | 136.90 ns | 137.21 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.95 ns |  46.724 ns | 2.561 ns | 137.40 ns | 141.91 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 370.11 ns | 126.062 ns | 6.910 ns | 363.05 ns | 376.86 ns | 0.0057 |     504 B |
