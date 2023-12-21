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
|    **SubnetMaskFromCidrNotion** |      **1** |     **18.22 ns** |     **1.534 ns** |   **0.084 ns** |     **18.15 ns** |     **18.32 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    116.67 ns |     5.102 ns |   0.280 ns |    116.35 ns |    116.88 ns | 0.0013 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    108.19 ns |     5.512 ns |   0.302 ns |    107.90 ns |    108.51 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     85.10 ns |     2.492 ns |   0.137 ns |     84.95 ns |     85.20 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     45.37 ns |     5.890 ns |   0.323 ns |     45.13 ns |     45.74 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    119.18 ns |    12.971 ns |   0.711 ns |    118.76 ns |    120.00 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **191.38 ns** |     **7.570 ns** |   **0.415 ns** |    **191.10 ns** |    **191.86 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,180.06 ns |    78.412 ns |   4.298 ns |  1,176.42 ns |  1,184.80 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,080.22 ns |    65.553 ns |   3.593 ns |  1,077.88 ns |  1,084.36 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    859.96 ns |    19.134 ns |   1.049 ns |    858.93 ns |    861.02 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    440.73 ns |   111.348 ns |   6.103 ns |    436.62 ns |    447.74 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,198.02 ns |   541.098 ns |  29.659 ns |  1,172.73 ns |  1,230.67 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,794.76 ns** |   **203.347 ns** |  **11.146 ns** |  **1,782.09 ns** |  **1,803.05 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,926.69 ns |   506.523 ns |  27.764 ns | 11,905.47 ns | 11,958.12 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,974.15 ns |   210.694 ns |  11.549 ns | 10,963.28 ns | 10,986.28 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,249.14 ns |   133.231 ns |   7.303 ns |  8,243.61 ns |  8,257.42 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,446.23 ns |   915.661 ns |  50.190 ns |  4,412.17 ns |  4,503.87 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,878.28 ns | 3,165.399 ns | 173.506 ns | 11,699.47 ns | 12,045.95 ns | 0.1984 |  16,800 B |
