```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.44 ns** |   **3.626 ns** |  **0.199 ns** |    **17.32 ns** |    **17.67 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   120.45 ns |  24.165 ns |  1.325 ns |   119.53 ns |   121.97 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   119.38 ns |  14.445 ns |  0.792 ns |   118.46 ns |   119.87 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    91.41 ns |  26.958 ns |  1.478 ns |    90.40 ns |    93.11 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.13 ns |   2.037 ns |  0.112 ns |    45.06 ns |    45.26 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.98 ns |  12.792 ns |  0.701 ns |    43.29 ns |    44.70 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   120.13 ns |  54.144 ns |  2.968 ns |   118.01 ns |   123.52 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **195.67 ns** |  **13.040 ns** |  **0.715 ns** |   **195.13 ns** |   **196.48 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,211.71 ns | 116.148 ns |  6.366 ns | 1,204.36 ns | 1,215.64 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,159.46 ns |  81.907 ns |  4.490 ns | 1,154.97 ns | 1,163.95 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   924.89 ns |  31.466 ns |  1.725 ns |   923.24 ns |   926.68 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   453.59 ns |  16.631 ns |  0.912 ns |   452.59 ns |   454.38 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   441.95 ns | 128.800 ns |  7.060 ns |   433.81 ns |   446.35 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,184.61 ns | 374.525 ns | 20.529 ns | 1,172.26 ns | 1,208.31 ns | 0.0191 |    1680 B |
