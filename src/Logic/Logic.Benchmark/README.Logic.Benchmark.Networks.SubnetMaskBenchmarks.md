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
|    **SubnetMaskFromCidrNotion** |      **1** |     **17.90 ns** |     **0.659 ns** |   **0.036 ns** |     **17.86 ns** |     **17.93 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    120.82 ns |     8.292 ns |   0.455 ns |    120.34 ns |    121.25 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    108.34 ns |     4.508 ns |   0.247 ns |    108.11 ns |    108.60 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     85.19 ns |     5.386 ns |   0.295 ns |     84.96 ns |     85.53 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     45.39 ns |    10.199 ns |   0.559 ns |     44.87 ns |     45.98 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    122.27 ns |    46.825 ns |   2.567 ns |    120.57 ns |    125.23 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **193.94 ns** |    **15.244 ns** |   **0.836 ns** |    **193.16 ns** |    **194.82 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,177.34 ns |    62.570 ns |   3.430 ns |  1,174.49 ns |  1,181.15 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,119.58 ns |    73.203 ns |   4.012 ns |  1,115.32 ns |  1,123.29 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    857.67 ns |    10.276 ns |   0.563 ns |    857.12 ns |    858.24 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    451.34 ns |    36.824 ns |   2.018 ns |    450.00 ns |    453.66 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,194.82 ns |   343.192 ns |  18.812 ns |  1,173.23 ns |  1,207.65 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,801.74 ns** |    **68.252 ns** |   **3.741 ns** |  **1,799.41 ns** |  **1,806.05 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,813.88 ns |   137.264 ns |   7.524 ns | 11,806.33 ns | 11,821.38 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,701.13 ns |   367.124 ns |  20.123 ns | 10,689.25 ns | 10,724.36 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,486.13 ns |   306.099 ns |  16.778 ns |  8,473.81 ns |  8,505.24 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,439.04 ns |   140.230 ns |   7.686 ns |  4,430.51 ns |  4,445.42 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 12,107.44 ns | 5,352.088 ns | 293.366 ns | 11,827.74 ns | 12,412.79 ns | 0.1984 |  16,800 B |
