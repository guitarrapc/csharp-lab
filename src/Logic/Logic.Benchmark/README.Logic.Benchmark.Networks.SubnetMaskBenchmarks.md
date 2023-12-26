```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                      | Number | Mean         | Error        | StdDev    | Min          | Max          | Gen0   | Allocated |
|---------------------------- |------- |-------------:|-------------:|----------:|-------------:|-------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**    | **1**      |     **17.59 ns** |     **1.430 ns** |  **0.078 ns** |     **17.50 ns** |     **17.65 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress   | 1      |    116.05 ns |     2.150 ns |  0.118 ns |    115.98 ns |    116.19 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2  | 1      |    109.16 ns |     5.212 ns |  0.286 ns |    108.90 ns |    109.47 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddress     | 1      |     81.65 ns |     2.744 ns |  0.150 ns |     81.55 ns |     81.83 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress | 1      |     45.22 ns |     1.181 ns |  0.065 ns |     45.16 ns |     45.29 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange   | 1      |    124.75 ns |    27.425 ns |  1.503 ns |    123.02 ns |    125.64 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**    | **10**     |    **191.85 ns** |    **82.139 ns** |  **4.502 ns** |    **186.66 ns** |    **194.70 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress   | 10     |  1,169.20 ns |    12.301 ns |  0.674 ns |  1,168.71 ns |  1,169.97 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2  | 10     |  1,113.06 ns |    49.570 ns |  2.717 ns |  1,110.50 ns |  1,115.91 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddress     | 10     |    864.40 ns |     8.544 ns |  0.468 ns |    864.03 ns |    864.93 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress | 10     |    445.42 ns |   167.957 ns |  9.206 ns |    434.81 ns |    451.36 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange   | 10     |  1,218.12 ns |    51.223 ns |  2.808 ns |  1,215.62 ns |  1,221.16 ns | 0.0191 |    1680 B |
| **SubnetMaskFromCidrNotion**    | **100**    |  **1,809.30 ns** |   **424.921 ns** | **23.291 ns** |  **1,790.60 ns** |  **1,835.39 ns** | **0.0668** |    **5600 B** |
| SubnetMaskFromCidrAddress   | 100    | 11,378.25 ns |   762.292 ns | 41.784 ns | 11,338.42 ns | 11,421.75 ns | 0.1221 |   11200 B |
| SubnetMaskFromCidrAddress2  | 100    | 10,971.15 ns |   450.105 ns | 24.672 ns | 10,953.11 ns | 10,999.27 ns | 0.1221 |   11200 B |
| SubnetMaskFromIPAddress     | 100    |  8,509.81 ns | 1,184.325 ns | 64.917 ns |  8,468.21 ns |  8,584.62 ns | 0.0610 |    5600 B |
| SubnetMaskGetNetworkAddress | 100    |  4,282.15 ns |    95.609 ns |  5.241 ns |  4,276.80 ns |  4,287.27 ns | 0.0610 |    5600 B |
| SubnetMaskGetAddressRange   | 100    | 11,669.80 ns |   196.652 ns | 10.779 ns | 11,657.66 ns | 11,678.25 ns | 0.1984 |   16800 B |
