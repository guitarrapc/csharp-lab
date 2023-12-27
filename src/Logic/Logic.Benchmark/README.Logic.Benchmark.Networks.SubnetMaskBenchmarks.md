```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                      | Number | Mean         | Error        | StdDev     | Min          | Max          | Gen0   | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**    | **1**      |     **17.47 ns** |     **0.605 ns** |   **0.033 ns** |     **17.43 ns** |     **17.50 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress   | 1      |    119.63 ns |    12.631 ns |   0.692 ns |    119.10 ns |    120.41 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2  | 1      |    109.27 ns |     4.802 ns |   0.263 ns |    109.06 ns |    109.56 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddress     | 1      |     84.75 ns |     2.723 ns |   0.149 ns |     84.58 ns |     84.85 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress | 1      |     44.96 ns |    18.790 ns |   1.030 ns |     44.15 ns |     46.12 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange   | 1      |    126.48 ns |    11.842 ns |   0.649 ns |    126.01 ns |    127.22 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**    | **10**     |    **193.51 ns** |    **11.262 ns** |   **0.617 ns** |    **192.86 ns** |    **194.09 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress   | 10     |  1,157.76 ns |    46.355 ns |   2.541 ns |  1,155.67 ns |  1,160.58 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2  | 10     |  1,095.37 ns |   392.530 ns |  21.516 ns |  1,080.84 ns |  1,120.09 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddress     | 10     |    847.78 ns |    28.093 ns |   1.540 ns |    846.00 ns |    848.72 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress | 10     |    438.61 ns |    24.079 ns |   1.320 ns |    437.50 ns |    440.07 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange   | 10     |  1,186.23 ns |    21.177 ns |   1.161 ns |  1,185.20 ns |  1,187.49 ns | 0.0191 |    1680 B |
| **SubnetMaskFromCidrNotion**    | **100**    |  **1,794.24 ns** |    **46.114 ns** |   **2.528 ns** |  **1,791.33 ns** |  **1,795.96 ns** | **0.0668** |    **5600 B** |
| SubnetMaskFromCidrAddress   | 100    | 12,828.56 ns |   111.776 ns |   6.127 ns | 12,824.53 ns | 12,835.61 ns | 0.1221 |   11200 B |
| SubnetMaskFromCidrAddress2  | 100    | 11,054.39 ns |   490.914 ns |  26.909 ns | 11,023.71 ns | 11,074.00 ns | 0.1221 |   11200 B |
| SubnetMaskFromIPAddress     | 100    |  8,550.75 ns |   237.852 ns |  13.037 ns |  8,537.14 ns |  8,563.12 ns | 0.0610 |    5600 B |
| SubnetMaskGetNetworkAddress | 100    |  4,522.25 ns | 3,413.726 ns | 187.118 ns |  4,403.71 ns |  4,737.96 ns | 0.0610 |    5600 B |
| SubnetMaskGetAddressRange   | 100    | 12,003.42 ns | 1,369.173 ns |  75.049 ns | 11,955.04 ns | 12,089.88 ns | 0.1984 |   16800 B |
