```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.49 ns** |   **1.735 ns** |  **0.095 ns** |    **17.42 ns** |    **17.60 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   123.06 ns |  42.325 ns |  2.320 ns |   121.52 ns |   125.73 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   117.96 ns |   1.033 ns |  0.057 ns |   117.90 ns |   118.00 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    91.39 ns |   1.200 ns |  0.066 ns |    91.32 ns |    91.44 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    44.93 ns |   2.207 ns |  0.121 ns |    44.81 ns |    45.05 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    44.99 ns |  15.810 ns |  0.867 ns |    44.42 ns |    45.99 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   125.87 ns |  12.805 ns |  0.702 ns |   125.46 ns |   126.68 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **197.62 ns** |  **40.353 ns** |  **2.212 ns** |   **195.07 ns** |   **199.00 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,223.86 ns |  43.783 ns |  2.400 ns | 1,222.00 ns | 1,226.57 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,194.13 ns | 150.695 ns |  8.260 ns | 1,185.95 ns | 1,202.47 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   935.94 ns |  34.965 ns |  1.917 ns |   933.74 ns |   937.24 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   458.57 ns |  22.884 ns |  1.254 ns |   457.25 ns |   459.74 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   438.52 ns |  37.016 ns |  2.029 ns |   436.96 ns |   440.81 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,207.15 ns | 296.395 ns | 16.246 ns | 1,193.96 ns | 1,225.30 ns | 0.0191 |    1680 B |
