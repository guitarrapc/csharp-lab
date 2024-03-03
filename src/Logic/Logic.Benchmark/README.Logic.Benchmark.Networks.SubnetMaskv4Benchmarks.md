```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.77 ns** |   **8.614 ns** |  **0.472 ns** |    **17.46 ns** |    **18.31 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   124.19 ns |   9.274 ns |  0.508 ns |   123.80 ns |   124.77 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   118.88 ns |   4.839 ns |  0.265 ns |   118.62 ns |   119.15 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    90.82 ns |   2.791 ns |  0.153 ns |    90.69 ns |    90.99 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.74 ns |   1.102 ns |  0.060 ns |    44.67 ns |    44.78 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    43.84 ns |   1.964 ns |  0.108 ns |    43.78 ns |    43.97 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   124.03 ns |  18.324 ns |  1.004 ns |   123.14 ns |   125.12 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **192.40 ns** |  **33.492 ns** |  **1.836 ns** |   **190.35 ns** |   **193.89 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,200.30 ns |  33.871 ns |  1.857 ns | 1,198.37 ns | 1,202.07 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,158.75 ns | 100.905 ns |  5.531 ns | 1,155.17 ns | 1,165.12 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   921.04 ns | 139.809 ns |  7.663 ns |   913.36 ns |   928.68 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   454.39 ns |  23.032 ns |  1.262 ns |   453.02 ns |   455.51 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   445.91 ns |   8.808 ns |  0.483 ns |   445.51 ns |   446.45 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,188.23 ns | 382.001 ns | 20.939 ns | 1,172.49 ns | 1,211.99 ns | 0.0191 |    1680 B |
