```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.55 ns** |   **0.471 ns** |  **0.026 ns** |    **17.53 ns** |    **17.57 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   112.12 ns |   6.289 ns |  0.345 ns |   111.72 ns |   112.32 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   104.84 ns |   3.016 ns |  0.165 ns |   104.65 ns |   104.95 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    78.05 ns |   3.414 ns |  0.187 ns |    77.93 ns |    78.27 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    44.78 ns |   3.081 ns |  0.169 ns |    44.65 ns |    44.97 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.68 ns |   7.987 ns |  0.438 ns |    43.21 ns |    44.08 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   118.59 ns |  33.389 ns |  1.830 ns |   117.16 ns |   120.66 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **193.71 ns** |   **3.386 ns** |  **0.186 ns** |   **193.50 ns** |   **193.84 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,126.72 ns |  39.754 ns |  2.179 ns | 1,124.64 ns | 1,128.99 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,071.90 ns |  49.388 ns |  2.707 ns | 1,068.88 ns | 1,074.12 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   810.76 ns |   7.479 ns |  0.410 ns |   810.45 ns |   811.23 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   453.52 ns |  40.498 ns |  2.220 ns |   451.68 ns |   455.99 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   433.59 ns |  28.145 ns |  1.543 ns |   432.26 ns |   435.28 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,186.62 ns | 311.566 ns | 17.078 ns | 1,175.16 ns | 1,206.25 ns | 0.0191 |    1680 B |
