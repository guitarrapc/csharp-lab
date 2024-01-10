```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.90 ns** |  **4.539 ns** | **0.249 ns** |    **17.64 ns** |    **18.13 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   110.09 ns |  3.549 ns | 0.195 ns |   109.95 ns |   110.31 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   108.97 ns |  2.309 ns | 0.127 ns |   108.87 ns |   109.11 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    79.85 ns |  3.803 ns | 0.208 ns |    79.62 ns |    80.03 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.29 ns |  2.981 ns | 0.163 ns |    45.15 ns |    45.47 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    44.62 ns | 34.300 ns | 1.880 ns |    43.14 ns |    46.73 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   121.40 ns | 36.585 ns | 2.005 ns |   120.09 ns |   123.71 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **198.36 ns** | **22.444 ns** | **1.230 ns** |   **196.95 ns** |   **199.25 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,089.93 ns | 68.915 ns | 3.777 ns | 1,086.05 ns | 1,093.59 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,056.73 ns | 10.836 ns | 0.594 ns | 1,056.04 ns | 1,057.12 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   811.38 ns |  7.064 ns | 0.387 ns |   810.95 ns |   811.71 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   511.48 ns |  9.616 ns | 0.527 ns |   511.09 ns |   512.08 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   447.76 ns | 38.715 ns | 2.122 ns |   445.34 ns |   449.31 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,191.37 ns | 83.132 ns | 4.557 ns | 1,187.04 ns | 1,196.12 ns | 0.0191 |    1680 B |
