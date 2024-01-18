```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **18.56 ns** |   **7.614 ns** |  **0.417 ns** |    **18.30 ns** |    **19.04 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   119.27 ns |   1.291 ns |  0.071 ns |   119.19 ns |   119.33 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   120.34 ns |   4.260 ns |  0.233 ns |   120.10 ns |   120.57 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    91.74 ns |   3.507 ns |  0.192 ns |    91.60 ns |    91.96 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.18 ns |   1.437 ns |  0.079 ns |    45.12 ns |    45.27 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.54 ns |   6.939 ns |  0.380 ns |    43.30 ns |    43.98 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   121.16 ns |  19.112 ns |  1.048 ns |   120.09 ns |   122.18 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **194.54 ns** |  **40.621 ns** |  **2.227 ns** |   **193.09 ns** |   **197.10 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,259.43 ns | 285.337 ns | 15.640 ns | 1,242.70 ns | 1,273.69 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,193.18 ns |  22.337 ns |  1.224 ns | 1,191.91 ns | 1,194.36 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   943.07 ns |  26.178 ns |  1.435 ns |   941.44 ns |   944.16 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   458.73 ns |   9.703 ns |  0.532 ns |   458.18 ns |   459.24 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   436.05 ns |  23.038 ns |  1.263 ns |   435.23 ns |   437.51 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,190.49 ns |  70.797 ns |  3.881 ns | 1,187.91 ns | 1,194.95 ns | 0.0191 |    1680 B |
