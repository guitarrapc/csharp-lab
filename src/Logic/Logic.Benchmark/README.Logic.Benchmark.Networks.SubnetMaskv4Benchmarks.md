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
| **FromPrefix**          | **1**      |  **17.78 ns** |   **1.929 ns** | **0.106 ns** |  **17.68 ns** |  **17.89 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.85 ns |   6.988 ns | 0.383 ns | 125.40 ns | 126.07 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.43 ns |  47.570 ns | 2.607 ns | 117.86 ns | 122.44 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.35 ns |   3.011 ns | 0.165 ns |  93.16 ns |  93.47 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.44 ns |   1.461 ns | 0.080 ns |  45.35 ns |  45.50 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.78 ns |  29.836 ns | 1.635 ns |  44.79 ns |  47.67 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.43 ns |  55.093 ns | 3.020 ns | 121.02 ns | 126.82 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.08 ns** |   **5.612 ns** | **0.308 ns** |  **55.77 ns** |  **56.38 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.69 ns |   1.892 ns | 0.104 ns | 374.58 ns | 374.77 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 350.67 ns |  35.761 ns | 1.960 ns | 349.44 ns | 352.93 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 281.89 ns | 142.729 ns | 7.823 ns | 277.12 ns | 290.92 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.34 ns |   6.472 ns | 0.355 ns | 137.10 ns | 137.75 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 141.26 ns |  20.640 ns | 1.131 ns | 140.05 ns | 142.29 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.55 ns |  22.582 ns | 1.238 ns | 365.46 ns | 367.89 ns | 0.0057 |     504 B |
