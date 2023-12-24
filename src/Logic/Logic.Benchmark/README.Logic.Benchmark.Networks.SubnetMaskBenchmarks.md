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
|    **SubnetMaskFromCidrNotion** |      **1** |     **17.88 ns** |     **2.365 ns** |   **0.130 ns** |     **17.80 ns** |     **18.03 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    120.57 ns |     3.412 ns |   0.187 ns |    120.39 ns |    120.77 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    111.46 ns |     3.310 ns |   0.181 ns |    111.34 ns |    111.67 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     84.87 ns |     2.142 ns |   0.117 ns |     84.78 ns |     85.00 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     46.61 ns |     7.993 ns |   0.438 ns |     46.12 ns |     46.97 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    119.90 ns |    32.889 ns |   1.803 ns |    118.44 ns |    121.91 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **185.13 ns** |     **4.259 ns** |   **0.233 ns** |    **184.88 ns** |    **185.34 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,171.42 ns |     6.983 ns |   0.383 ns |  1,171.08 ns |  1,171.84 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,120.22 ns |    38.613 ns |   2.117 ns |  1,118.68 ns |  1,122.64 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    854.67 ns |    15.956 ns |   0.875 ns |    854.13 ns |    855.67 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    439.27 ns |    19.265 ns |   1.056 ns |    438.52 ns |    440.47 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,190.27 ns |   102.333 ns |   5.609 ns |  1,184.32 ns |  1,195.47 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,795.99 ns** |    **53.655 ns** |   **2.941 ns** |  **1,792.63 ns** |  **1,798.09 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,674.42 ns |   196.305 ns |  10.760 ns | 11,663.03 ns | 11,684.42 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,938.02 ns |   539.732 ns |  29.585 ns | 10,918.32 ns | 10,972.04 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,521.73 ns |   327.267 ns |  17.939 ns |  8,501.19 ns |  8,534.31 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,434.43 ns |   275.718 ns |  15.113 ns |  4,419.88 ns |  4,450.05 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,943.97 ns | 2,744.213 ns | 150.420 ns | 11,771.31 ns | 12,046.63 ns | 0.1984 |  16,800 B |
