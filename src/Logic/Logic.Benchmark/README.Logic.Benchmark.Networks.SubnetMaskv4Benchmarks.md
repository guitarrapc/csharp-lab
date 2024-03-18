```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.08 ns** |   **1.016 ns** |  **0.056 ns** |  **18.03 ns** |  **18.14 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.10 ns |  19.183 ns |  1.051 ns | 120.09 ns | 122.19 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.52 ns |   3.015 ns |  0.165 ns | 116.40 ns | 116.70 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  92.65 ns |   3.436 ns |  0.188 ns |  92.49 ns |  92.86 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  46.17 ns |  13.027 ns |  0.714 ns |  45.65 ns |  46.98 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.98 ns |   5.552 ns |  0.304 ns |  45.69 ns |  46.30 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 132.47 ns |   7.815 ns |  0.428 ns | 132.15 ns | 132.96 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **57.54 ns** |   **3.209 ns** |  **0.176 ns** |  **57.39 ns** |  **57.74 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 373.86 ns | 186.988 ns | 10.249 ns | 365.86 ns | 385.41 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 367.20 ns |  19.871 ns |  1.089 ns | 366.26 ns | 368.40 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 291.49 ns |  12.340 ns |  0.676 ns | 290.91 ns | 292.24 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 138.77 ns |   4.834 ns |  0.265 ns | 138.49 ns | 139.02 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 142.75 ns |  54.033 ns |  2.962 ns | 140.75 ns | 146.15 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.38 ns |  32.796 ns |  1.798 ns | 364.31 ns | 367.51 ns | 0.0057 |     504 B |
