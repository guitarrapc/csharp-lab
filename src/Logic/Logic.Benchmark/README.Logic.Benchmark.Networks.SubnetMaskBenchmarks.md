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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.55 ns** |   **1.508 ns** |  **0.083 ns** |    **17.45 ns** |    **17.61 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   125.61 ns |   9.186 ns |  0.504 ns |   125.04 ns |   125.97 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   118.87 ns |  26.059 ns |  1.428 ns |   117.25 ns |   119.95 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    92.15 ns |   5.538 ns |  0.304 ns |    91.93 ns |    92.50 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.33 ns |   3.541 ns |  0.194 ns |    45.20 ns |    45.55 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    45.79 ns |  19.190 ns |  1.052 ns |    45.06 ns |    47.00 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   126.28 ns |  54.397 ns |  2.982 ns |   123.95 ns |   129.64 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **195.39 ns** |   **9.556 ns** |  **0.524 ns** |   **194.80 ns** |   **195.81 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,258.35 ns | 474.995 ns | 26.036 ns | 1,242.07 ns | 1,288.38 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,197.79 ns |  32.146 ns |  1.762 ns | 1,196.25 ns | 1,199.71 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   937.57 ns |  26.367 ns |  1.445 ns |   936.60 ns |   939.23 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   464.33 ns |   5.697 ns |  0.312 ns |   463.97 ns |   464.53 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   440.20 ns |  15.582 ns |  0.854 ns |   439.37 ns |   441.08 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,196.34 ns | 520.918 ns | 28.553 ns | 1,177.53 ns | 1,229.20 ns | 0.0191 |    1680 B |
