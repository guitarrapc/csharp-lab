```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **18.28 ns** |   **2.834 ns** |  **0.155 ns** |    **18.13 ns** |    **18.44 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   120.37 ns |   6.211 ns |  0.340 ns |   120.17 ns |   120.76 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   120.27 ns |   5.959 ns |  0.327 ns |   119.90 ns |   120.48 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    91.22 ns |   8.976 ns |  0.492 ns |    90.82 ns |    91.77 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    45.84 ns |   2.009 ns |  0.110 ns |    45.71 ns |    45.92 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    45.71 ns |  22.684 ns |  1.243 ns |    44.76 ns |    47.12 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   127.26 ns |  34.952 ns |  1.916 ns |   126.11 ns |   129.48 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **201.29 ns** |  **42.053 ns** |  **2.305 ns** |   **198.64 ns** |   **202.85 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,238.32 ns |  96.459 ns |  5.287 ns | 1,232.92 ns | 1,243.49 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,163.76 ns |  28.041 ns |  1.537 ns | 1,162.87 ns | 1,165.53 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   949.76 ns |  39.839 ns |  2.184 ns |   948.43 ns |   952.28 ns | 0.0057 |     560 B |
| FromIPAddressType   | 10     |   468.92 ns |  47.106 ns |  2.582 ns |   466.78 ns |   471.78 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   451.88 ns |  18.894 ns |  1.036 ns |   450.98 ns |   453.01 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,218.58 ns | 496.161 ns | 27.196 ns | 1,199.84 ns | 1,249.77 ns | 0.0191 |    1680 B |
