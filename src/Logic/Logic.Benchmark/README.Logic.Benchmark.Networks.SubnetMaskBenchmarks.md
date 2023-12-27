```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                      | Number | Mean         | Error      | StdDev    | Min          | Max          | Gen0   | Allocated |
|---------------------------- |------- |-------------:|-----------:|----------:|-------------:|-------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**    | **1**      |     **18.21 ns** |   **0.985 ns** |  **0.054 ns** |     **18.15 ns** |     **18.26 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress   | 1      |    123.49 ns |  10.500 ns |  0.576 ns |    122.97 ns |    124.11 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2  | 1      |    109.67 ns |   1.747 ns |  0.096 ns |    109.60 ns |    109.78 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddress     | 1      |     82.24 ns |   2.202 ns |  0.121 ns |     82.13 ns |     82.37 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress | 1      |     46.00 ns |  12.201 ns |  0.669 ns |     45.45 ns |     46.75 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange   | 1      |    124.33 ns |  11.706 ns |  0.642 ns |    123.61 ns |    124.83 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**    | **10**     |    **184.82 ns** |  **28.092 ns** |  **1.540 ns** |    **183.78 ns** |    **186.59 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress   | 10     |  1,192.08 ns | 199.735 ns | 10.948 ns |  1,184.76 ns |  1,204.66 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2  | 10     |  1,090.48 ns | 364.659 ns | 19.988 ns |  1,077.02 ns |  1,113.44 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddress     | 10     |    868.20 ns |  14.728 ns |  0.807 ns |    867.35 ns |    868.95 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress | 10     |    447.93 ns |   5.371 ns |  0.294 ns |    447.72 ns |    448.27 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange   | 10     |  1,186.60 ns |  16.907 ns |  0.927 ns |  1,185.73 ns |  1,187.57 ns | 0.0191 |    1680 B |
| **SubnetMaskFromCidrNotion**    | **100**    |  **1,791.94 ns** | **218.029 ns** | **11.951 ns** |  **1,780.46 ns** |  **1,804.31 ns** | **0.0668** |    **5600 B** |
| SubnetMaskFromCidrAddress   | 100    | 11,680.65 ns | 670.959 ns | 36.778 ns | 11,652.19 ns | 11,722.17 ns | 0.1221 |   11200 B |
| SubnetMaskFromCidrAddress2  | 100    | 10,694.67 ns | 472.612 ns | 25.905 ns | 10,678.19 ns | 10,724.53 ns | 0.1221 |   11200 B |
| SubnetMaskFromIPAddress     | 100    |  8,468.27 ns | 175.145 ns |  9.600 ns |  8,457.20 ns |  8,474.27 ns | 0.0610 |    5600 B |
| SubnetMaskGetNetworkAddress | 100    |  4,387.18 ns | 296.734 ns | 16.265 ns |  4,368.59 ns |  4,398.80 ns | 0.0610 |    5600 B |
| SubnetMaskGetAddressRange   | 100    | 11,630.70 ns | 895.737 ns | 49.098 ns | 11,589.20 ns | 11,684.90 ns | 0.1984 |   16800 B |
