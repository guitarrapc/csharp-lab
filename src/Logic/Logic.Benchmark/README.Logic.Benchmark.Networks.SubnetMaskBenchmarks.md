``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **18.10 ns** |     **1.238 ns** |   **0.068 ns** |     **18.02 ns** |     **18.15 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    117.52 ns |     7.080 ns |   0.388 ns |    117.24 ns |    117.96 ns | 0.0013 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    113.62 ns |     3.562 ns |   0.195 ns |    113.47 ns |    113.84 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     82.78 ns |     2.545 ns |   0.140 ns |     82.65 ns |     82.93 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     45.18 ns |    15.241 ns |   0.835 ns |     44.53 ns |     46.12 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    120.65 ns |    17.129 ns |   0.939 ns |    119.57 ns |    121.20 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **188.25 ns** |    **80.900 ns** |   **4.434 ns** |    **185.58 ns** |    **193.37 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,180.08 ns |    62.913 ns |   3.448 ns |  1,176.22 ns |  1,182.86 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,116.28 ns |    47.321 ns |   2.594 ns |  1,113.36 ns |  1,118.33 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    827.28 ns |    35.823 ns |   1.964 ns |    825.30 ns |    829.23 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    439.32 ns |    22.187 ns |   1.216 ns |    438.12 ns |    440.55 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,190.71 ns |   274.253 ns |  15.033 ns |  1,180.81 ns |  1,208.01 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,809.13 ns** |   **414.804 ns** |  **22.737 ns** |  **1,793.82 ns** |  **1,835.26 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,747.75 ns |   492.754 ns |  27.009 ns | 11,731.30 ns | 11,778.93 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,965.25 ns |   122.426 ns |   6.711 ns | 10,957.52 ns | 10,969.63 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,228.92 ns |   192.450 ns |  10.549 ns |  8,217.21 ns |  8,237.68 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,419.35 ns |   276.151 ns |  15.137 ns |  4,408.22 ns |  4,436.59 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,835.54 ns | 2,058.779 ns | 112.849 ns | 11,716.96 ns | 11,941.62 ns | 0.1984 |  16,800 B |
