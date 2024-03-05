```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.52 ns** |   **5.017 ns** | **0.275 ns** |    **17.28 ns** |    **17.82 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   123.53 ns |  48.132 ns | 2.638 ns |   121.88 ns |   126.57 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   118.14 ns |   5.649 ns | 0.310 ns |   117.84 ns |   118.46 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    89.67 ns |   3.302 ns | 0.181 ns |    89.52 ns |    89.87 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    45.09 ns |   2.750 ns | 0.151 ns |    45.00 ns |    45.27 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    43.35 ns |   8.659 ns | 0.475 ns |    43.07 ns |    43.90 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   125.90 ns |   7.158 ns | 0.392 ns |   125.49 ns |   126.28 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **193.01 ns** |  **18.432 ns** | **1.010 ns** |   **192.39 ns** |   **194.17 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,240.86 ns | 100.709 ns | 5.520 ns | 1,236.70 ns | 1,247.12 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,190.35 ns |   2.248 ns | 0.123 ns | 1,190.26 ns | 1,190.49 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   948.13 ns |  59.961 ns | 3.287 ns |   944.63 ns |   951.15 ns | 0.0057 |     560 B |
| FromIPAddressType   | 10     |   457.12 ns |  19.300 ns | 1.058 ns |   456.22 ns |   458.28 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   436.90 ns |  31.097 ns | 1.705 ns |   434.95 ns |   438.12 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,174.96 ns |  54.082 ns | 2.964 ns | 1,171.63 ns | 1,177.31 ns | 0.0191 |    1680 B |
