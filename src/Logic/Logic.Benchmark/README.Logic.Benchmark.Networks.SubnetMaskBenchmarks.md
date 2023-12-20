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
|    **SubnetMaskFromCidrNotion** |      **1** |     **18.21 ns** |     **7.168 ns** |   **0.393 ns** |     **17.96 ns** |     **18.67 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    117.48 ns |     3.435 ns |   0.188 ns |    117.27 ns |    117.63 ns | 0.0013 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    112.43 ns |     3.838 ns |   0.210 ns |    112.19 ns |    112.59 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     86.17 ns |     5.192 ns |   0.285 ns |     85.97 ns |     86.50 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     45.48 ns |    13.840 ns |   0.759 ns |     44.67 ns |     46.17 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    120.39 ns |     6.168 ns |   0.338 ns |    120.00 ns |    120.59 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **192.65 ns** |    **30.352 ns** |   **1.664 ns** |    **191.26 ns** |    **194.49 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,187.92 ns |    40.270 ns |   2.207 ns |  1,185.57 ns |  1,189.95 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,080.34 ns |    39.994 ns |   2.192 ns |  1,077.99 ns |  1,082.32 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    830.30 ns |     4.428 ns |   0.243 ns |    830.03 ns |    830.48 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    448.47 ns |   109.061 ns |   5.978 ns |    441.57 ns |    452.19 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,203.16 ns |   473.449 ns |  25.951 ns |  1,176.44 ns |  1,228.27 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,794.64 ns** |   **115.286 ns** |   **6.319 ns** |  **1,787.35 ns** |  **1,798.45 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,670.35 ns |   237.862 ns |  13.038 ns | 11,655.30 ns | 11,678.18 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,990.07 ns |    87.696 ns |   4.807 ns | 10,986.69 ns | 10,995.58 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,554.15 ns |   274.483 ns |  15.045 ns |  8,545.30 ns |  8,571.53 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,410.81 ns |   887.025 ns |  48.621 ns |  4,355.19 ns |  4,445.23 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,839.20 ns | 1,993.130 ns | 109.250 ns | 11,728.25 ns | 11,946.67 ns | 0.1984 |  16,800 B |
