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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.39 ns** |   **0.831 ns** |  **0.046 ns** |    **17.34 ns** |    **17.42 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   119.90 ns |   7.539 ns |  0.413 ns |   119.61 ns |   120.37 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   119.61 ns |  18.558 ns |  1.017 ns |   119.01 ns |   120.78 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    90.58 ns |   0.187 ns |  0.010 ns |    90.57 ns |    90.59 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.99 ns |  28.530 ns |  1.564 ns |    45.05 ns |    47.80 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.04 ns |   1.179 ns |  0.065 ns |    42.99 ns |    43.11 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   126.62 ns |  41.287 ns |  2.263 ns |   125.22 ns |   129.23 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **196.82 ns** |  **13.971 ns** |  **0.766 ns** |   **196.00 ns** |   **197.51 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,219.29 ns | 550.043 ns | 30.150 ns | 1,199.83 ns | 1,254.02 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,206.97 ns | 408.151 ns | 22.372 ns | 1,192.32 ns | 1,232.73 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   934.61 ns |  21.514 ns |  1.179 ns |   933.56 ns |   935.89 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   463.11 ns |  36.800 ns |  2.017 ns |   460.80 ns |   464.55 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   459.12 ns |  12.935 ns |  0.709 ns |   458.45 ns |   459.86 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,196.74 ns | 161.661 ns |  8.861 ns | 1,187.53 ns | 1,205.21 ns | 0.0191 |    1680 B |
