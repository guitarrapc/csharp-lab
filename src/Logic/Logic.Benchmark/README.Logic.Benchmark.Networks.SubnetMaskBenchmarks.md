```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.64 ns** |   **3.115 ns** | **0.171 ns** |    **17.47 ns** |    **17.81 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   125.79 ns |  11.032 ns | 0.605 ns |   125.13 ns |   126.31 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   119.02 ns |   6.529 ns | 0.358 ns |   118.80 ns |   119.44 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    91.65 ns |  19.874 ns | 1.089 ns |    90.72 ns |    92.85 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.17 ns |   6.368 ns | 0.349 ns |    44.89 ns |    45.57 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.64 ns |   5.343 ns | 0.293 ns |    43.37 ns |    43.95 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   123.08 ns |  13.734 ns | 0.753 ns |   122.38 ns |   123.88 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **197.53 ns** |   **5.400 ns** | **0.296 ns** |   **197.21 ns** |   **197.80 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,235.16 ns | 113.619 ns | 6.228 ns | 1,229.30 ns | 1,241.70 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,186.57 ns | 148.049 ns | 8.115 ns | 1,181.59 ns | 1,195.93 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   928.03 ns |  34.255 ns | 1.878 ns |   925.90 ns |   929.45 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   460.35 ns |  19.850 ns | 1.088 ns |   459.46 ns |   461.56 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   438.64 ns |  38.413 ns | 2.106 ns |   436.53 ns |   440.74 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,182.97 ns |  34.565 ns | 1.895 ns | 1,181.23 ns | 1,184.99 ns | 0.0191 |    1680 B |
