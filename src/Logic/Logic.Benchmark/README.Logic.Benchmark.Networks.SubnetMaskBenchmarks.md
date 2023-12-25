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
|    **SubnetMaskFromCidrNotion** |      **1** |     **17.72 ns** |     **0.925 ns** |   **0.051 ns** |     **17.67 ns** |     **17.77 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    121.60 ns |    38.555 ns |   2.113 ns |    120.37 ns |    124.04 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    110.52 ns |     5.742 ns |   0.315 ns |    110.25 ns |    110.87 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     82.83 ns |     1.252 ns |   0.069 ns |     82.76 ns |     82.89 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     45.31 ns |     5.218 ns |   0.286 ns |     45.05 ns |     45.61 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    120.46 ns |    31.508 ns |   1.727 ns |    119.02 ns |    122.37 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **191.64 ns** |    **16.212 ns** |   **0.889 ns** |    **190.79 ns** |    **192.56 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,283.54 ns |     5.840 ns |   0.320 ns |  1,283.18 ns |  1,283.78 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,087.35 ns |   288.648 ns |  15.822 ns |  1,076.54 ns |  1,105.51 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    861.86 ns |    28.435 ns |   1.559 ns |    860.56 ns |    863.59 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    450.32 ns |    26.060 ns |   1.428 ns |    448.72 ns |    451.46 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,217.20 ns |   650.277 ns |  35.644 ns |  1,181.25 ns |  1,252.53 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,786.66 ns** |    **75.372 ns** |   **4.131 ns** |  **1,782.31 ns** |  **1,790.53 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,207.41 ns |   483.050 ns |  26.478 ns | 11,178.04 ns | 11,229.46 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,880.25 ns |   402.500 ns |  22.062 ns | 10,856.64 ns | 10,900.33 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,433.84 ns |   139.178 ns |   7.629 ns |  8,427.63 ns |  8,442.35 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,421.77 ns |   671.907 ns |  36.829 ns |  4,391.40 ns |  4,462.74 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,926.01 ns | 2,806.022 ns | 153.808 ns | 11,788.03 ns | 12,091.84 ns | 0.1984 |  16,800 B |
