``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **28.46 ns** |    **10.820 ns** |   **0.593 ns** |     **27.98 ns** |     **29.12 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    150.78 ns |    15.113 ns |   0.828 ns |    150.22 ns |    151.73 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    146.86 ns |    17.767 ns |   0.974 ns |    146.22 ns |    147.98 ns | 0.0012 |     112 B |
|     SubnetMaskFromIPAddress |      1 |    110.77 ns |     4.197 ns |   0.230 ns |    110.50 ns |    110.93 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     64.00 ns |     2.609 ns |   0.143 ns |     63.87 ns |     64.15 ns | 0.0006 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    158.34 ns |    51.421 ns |   2.819 ns |    156.35 ns |    161.56 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **285.12 ns** |    **15.692 ns** |   **0.860 ns** |    **284.33 ns** |    **286.04 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,476.94 ns |    10.709 ns |   0.587 ns |  1,476.32 ns |  1,477.49 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,434.79 ns |     2.516 ns |   0.138 ns |  1,434.66 ns |  1,434.93 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |  1,148.06 ns |   224.296 ns |  12.294 ns |  1,137.83 ns |  1,161.70 ns | 0.0057 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    636.21 ns |    14.405 ns |   0.790 ns |    635.37 ns |    636.94 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,556.85 ns |     7.082 ns |   0.388 ns |  1,556.42 ns |  1,557.19 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **2,803.75 ns** |   **774.315 ns** |  **42.443 ns** |  **2,767.52 ns** |  **2,850.45 ns** | **0.0648** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 14,624.09 ns |   358.239 ns |  19.636 ns | 14,606.99 ns | 14,645.54 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 14,352.97 ns |   134.168 ns |   7.354 ns | 14,345.46 ns | 14,360.16 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 | 11,353.19 ns | 1,158.945 ns |  63.526 ns | 11,301.63 ns | 11,424.15 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  6,307.84 ns |   290.910 ns |  15.946 ns |  6,291.43 ns |  6,323.28 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 15,624.61 ns | 2,080.918 ns | 114.062 ns | 15,537.98 ns | 15,753.84 ns | 0.1831 |  16,800 B |
