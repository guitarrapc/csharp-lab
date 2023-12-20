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
|    **SubnetMaskFromCidrNotion** |      **1** |     **17.87 ns** |     **2.069 ns** |   **0.113 ns** |     **17.79 ns** |     **18.00 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    117.75 ns |    14.752 ns |   0.809 ns |    117.15 ns |    118.67 ns | 0.0013 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    108.71 ns |     5.079 ns |   0.278 ns |    108.51 ns |    109.03 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     83.82 ns |    33.163 ns |   1.818 ns |     82.60 ns |     85.91 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     45.48 ns |     7.902 ns |   0.433 ns |     45.19 ns |     45.97 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    122.99 ns |    19.972 ns |   1.095 ns |    121.78 ns |    123.92 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **191.75 ns** |    **76.220 ns** |   **4.178 ns** |    **186.94 ns** |    **194.43 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,141.03 ns |    47.239 ns |   2.589 ns |  1,138.04 ns |  1,142.60 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,091.99 ns |    87.238 ns |   4.782 ns |  1,086.47 ns |  1,094.85 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    833.29 ns |    34.397 ns |   1.885 ns |    831.47 ns |    835.23 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    448.91 ns |    98.114 ns |   5.378 ns |    442.70 ns |    452.24 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,271.61 ns | 1,295.243 ns |  70.997 ns |  1,219.85 ns |  1,352.55 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,788.94 ns** |   **174.373 ns** |   **9.558 ns** |  **1,777.96 ns** |  **1,795.44 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,717.59 ns |   484.007 ns |  26.530 ns | 11,698.37 ns | 11,747.86 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 11,039.18 ns |   125.365 ns |   6.872 ns | 11,031.72 ns | 11,045.26 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,518.43 ns |   298.577 ns |  16.366 ns |  8,505.17 ns |  8,536.72 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,417.82 ns |    89.586 ns |   4.911 ns |  4,412.43 ns |  4,422.03 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,780.31 ns | 3,755.274 ns | 205.839 ns | 11,624.82 ns | 12,013.73 ns | 0.1984 |  16,800 B |
