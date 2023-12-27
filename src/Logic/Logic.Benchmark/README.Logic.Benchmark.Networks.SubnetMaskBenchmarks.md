```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                      | Number | Mean         | Error        | StdDev     | Min          | Max          | Gen0   | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**    | **1**      |     **17.47 ns** |     **1.293 ns** |   **0.071 ns** |     **17.39 ns** |     **17.51 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress   | 1      |    113.13 ns |    13.213 ns |   0.724 ns |    112.51 ns |    113.93 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2  | 1      |    108.83 ns |     4.990 ns |   0.273 ns |    108.65 ns |    109.15 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddress     | 1      |     82.43 ns |     2.794 ns |   0.153 ns |     82.25 ns |     82.54 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress | 1      |     44.08 ns |    20.953 ns |   1.149 ns |     43.08 ns |     45.34 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange   | 1      |    121.11 ns |    94.320 ns |   5.170 ns |    117.77 ns |    127.07 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**    | **10**     |    **184.40 ns** |    **29.428 ns** |   **1.613 ns** |    **182.56 ns** |    **185.60 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress   | 10     |  1,178.38 ns |   301.408 ns |  16.521 ns |  1,168.07 ns |  1,197.44 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2  | 10     |  1,108.16 ns |    28.909 ns |   1.585 ns |  1,106.82 ns |  1,109.91 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddress     | 10     |    861.07 ns |    12.175 ns |   0.667 ns |    860.44 ns |    861.77 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress | 10     |    438.20 ns |    72.618 ns |   3.980 ns |    435.16 ns |    442.70 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange   | 10     |  1,208.37 ns |   370.165 ns |  20.290 ns |  1,196.16 ns |  1,231.79 ns | 0.0191 |    1680 B |
| **SubnetMaskFromCidrNotion**    | **100**    |  **1,786.28 ns** |    **40.579 ns** |   **2.224 ns** |  **1,783.81 ns** |  **1,788.13 ns** | **0.0668** |    **5600 B** |
| SubnetMaskFromCidrAddress   | 100    | 11,838.05 ns |   294.558 ns |  16.146 ns | 11,824.76 ns | 11,856.02 ns | 0.1221 |   11200 B |
| SubnetMaskFromCidrAddress2  | 100    | 10,712.90 ns |   157.379 ns |   8.626 ns | 10,703.06 ns | 10,719.19 ns | 0.1221 |   11200 B |
| SubnetMaskFromIPAddress     | 100    |  8,218.51 ns |   264.726 ns |  14.511 ns |  8,202.65 ns |  8,231.12 ns | 0.0610 |    5600 B |
| SubnetMaskGetNetworkAddress | 100    |  4,581.45 ns |    63.612 ns |   3.487 ns |  4,578.31 ns |  4,585.20 ns | 0.0610 |    5600 B |
| SubnetMaskGetAddressRange   | 100    | 11,957.77 ns | 2,635.337 ns | 144.452 ns | 11,850.56 ns | 12,122.04 ns | 0.1984 |   16800 B |
