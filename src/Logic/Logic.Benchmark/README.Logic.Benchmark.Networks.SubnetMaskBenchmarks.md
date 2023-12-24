``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **17.82 ns** |     **4.044 ns** |  **0.222 ns** |     **17.66 ns** |     **18.08 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    126.00 ns |    16.630 ns |  0.912 ns |    125.28 ns |    127.02 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    111.06 ns |     5.420 ns |  0.297 ns |    110.83 ns |    111.40 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     84.96 ns |     2.026 ns |  0.111 ns |     84.87 ns |     85.08 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     46.94 ns |     8.001 ns |  0.439 ns |     46.66 ns |     47.44 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    119.41 ns |    22.743 ns |  1.247 ns |    118.61 ns |    120.84 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **188.97 ns** |    **54.114 ns** |  **2.966 ns** |    **185.61 ns** |    **191.21 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,137.06 ns |    27.217 ns |  1.492 ns |  1,135.33 ns |  1,137.93 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,081.56 ns |    61.032 ns |  3.345 ns |  1,077.98 ns |  1,084.60 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    828.99 ns |    60.581 ns |  3.321 ns |    826.93 ns |    832.82 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    441.89 ns |    54.339 ns |  2.979 ns |    438.75 ns |    444.68 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,262.62 ns |    75.726 ns |  4.151 ns |  1,258.70 ns |  1,266.97 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,779.77 ns** |   **127.811 ns** |  **7.006 ns** |  **1,773.51 ns** |  **1,787.33 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,532.80 ns |   494.646 ns | 27.113 ns | 11,511.83 ns | 11,563.42 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 11,038.29 ns |   350.311 ns | 19.202 ns | 11,017.62 ns | 11,055.57 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,280.71 ns |   317.985 ns | 17.430 ns |  8,270.18 ns |  8,300.83 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,410.05 ns | 1,065.581 ns | 58.408 ns |  4,345.26 ns |  4,458.65 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 12,163.19 ns | 1,772.790 ns | 97.173 ns | 12,052.72 ns | 12,235.45 ns | 0.1984 |  16,800 B |
