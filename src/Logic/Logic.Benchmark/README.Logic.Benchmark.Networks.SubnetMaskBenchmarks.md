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
|    **SubnetMaskFromCidrNotion** |      **1** |     **18.39 ns** |     **1.394 ns** |   **0.076 ns** |     **18.31 ns** |     **18.47 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    124.20 ns |    32.914 ns |   1.804 ns |    122.13 ns |    125.47 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    110.02 ns |     2.401 ns |   0.132 ns |    109.92 ns |    110.17 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     86.79 ns |     2.405 ns |   0.132 ns |     86.64 ns |     86.88 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     45.59 ns |    11.140 ns |   0.611 ns |     45.01 ns |     46.22 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    124.68 ns |    30.521 ns |   1.673 ns |    122.84 ns |    126.10 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **198.03 ns** |     **8.304 ns** |   **0.455 ns** |    **197.63 ns** |    **198.53 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,197.65 ns |    30.539 ns |   1.674 ns |  1,196.33 ns |  1,199.53 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,124.74 ns |    50.644 ns |   2.776 ns |  1,121.54 ns |  1,126.54 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    857.18 ns |    22.480 ns |   1.232 ns |    855.82 ns |    858.21 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    452.88 ns |    95.666 ns |   5.244 ns |    447.03 ns |    457.15 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,219.45 ns |   357.517 ns |  19.597 ns |  1,207.52 ns |  1,242.07 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,813.71 ns** |   **278.232 ns** |  **15.251 ns** |  **1,798.86 ns** |  **1,829.33 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,593.93 ns |   380.151 ns |  20.837 ns | 11,577.20 ns | 11,617.27 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,925.13 ns | 4,673.189 ns | 256.153 ns | 10,763.88 ns | 11,220.49 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,281.32 ns |   604.336 ns |  33.126 ns |  8,258.50 ns |  8,319.31 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,465.64 ns |    88.411 ns |   4.846 ns |  4,460.27 ns |  4,469.68 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,935.00 ns | 2,155.793 ns | 118.166 ns | 11,817.82 ns | 12,054.12 ns | 0.1984 |  16,800 B |
