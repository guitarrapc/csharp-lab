```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.66 ns** |   **0.813 ns** | **0.045 ns** |    **17.61 ns** |    **17.70 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   126.13 ns |  50.832 ns | 2.786 ns |   124.34 ns |   129.34 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   121.39 ns |  42.813 ns | 2.347 ns |   119.93 ns |   124.10 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    89.92 ns |   0.999 ns | 0.055 ns |    89.86 ns |    89.97 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    45.38 ns |   0.613 ns | 0.034 ns |    45.35 ns |    45.42 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    44.92 ns |   7.017 ns | 0.385 ns |    44.63 ns |    45.36 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   125.11 ns |   5.301 ns | 0.291 ns |   124.89 ns |   125.44 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **196.15 ns** |  **45.303 ns** | **2.483 ns** |   **194.52 ns** |   **199.00 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,207.46 ns | 115.090 ns | 6.308 ns | 1,202.01 ns | 1,214.37 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,165.46 ns |  90.685 ns | 4.971 ns | 1,162.29 ns | 1,171.19 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   944.50 ns |  34.513 ns | 1.892 ns |   943.01 ns |   946.63 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   461.66 ns |   2.441 ns | 0.134 ns |   461.53 ns |   461.80 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   444.42 ns |  22.460 ns | 1.231 ns |   443.01 ns |   445.27 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,176.78 ns |  51.170 ns | 2.805 ns | 1,174.15 ns | 1,179.73 ns | 0.0191 |    1680 B |
