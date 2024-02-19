```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.37 ns** |  **8.229 ns** | **0.451 ns** |    **17.10 ns** |    **17.89 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   120.67 ns |  4.813 ns | 0.264 ns |   120.37 ns |   120.84 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   118.18 ns |  1.533 ns | 0.084 ns |   118.12 ns |   118.27 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    89.66 ns |  3.499 ns | 0.192 ns |    89.47 ns |    89.85 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.57 ns |  0.806 ns | 0.044 ns |    44.54 ns |    44.62 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    43.42 ns |  3.327 ns | 0.182 ns |    43.21 ns |    43.53 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   124.21 ns | 27.843 ns | 1.526 ns |   122.88 ns |   125.88 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **191.58 ns** | **10.841 ns** | **0.594 ns** |   **191.02 ns** |   **192.21 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,237.68 ns | 86.220 ns | 4.726 ns | 1,233.00 ns | 1,242.45 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,194.40 ns | 30.616 ns | 1.678 ns | 1,192.60 ns | 1,195.92 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   945.57 ns | 12.065 ns | 0.661 ns |   944.81 ns |   945.98 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   452.98 ns | 21.141 ns | 1.159 ns |   451.70 ns |   453.97 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   444.94 ns |  7.499 ns | 0.411 ns |   444.58 ns |   445.39 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,182.83 ns | 29.233 ns | 1.602 ns | 1,181.71 ns | 1,184.67 ns | 0.0191 |    1680 B |
