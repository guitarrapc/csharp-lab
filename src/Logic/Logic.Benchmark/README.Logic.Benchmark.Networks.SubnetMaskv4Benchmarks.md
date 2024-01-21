```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.37 ns** |   **0.741 ns** | **0.041 ns** |    **17.33 ns** |    **17.40 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   119.80 ns |   9.173 ns | 0.503 ns |   119.41 ns |   120.37 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   116.38 ns |   6.745 ns | 0.370 ns |   115.98 ns |   116.71 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |    90.59 ns |   6.103 ns | 0.335 ns |    90.38 ns |    90.98 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.37 ns |   1.211 ns | 0.066 ns |    44.32 ns |    44.44 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    42.99 ns |   3.057 ns | 0.168 ns |    42.83 ns |    43.16 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   123.70 ns |  27.715 ns | 1.519 ns |   122.17 ns |   125.21 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **195.33 ns** |  **52.738 ns** | **2.891 ns** |   **192.82 ns** |   **198.49 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,233.31 ns |  98.507 ns | 5.400 ns | 1,229.20 ns | 1,239.43 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,193.82 ns |  58.498 ns | 3.206 ns | 1,191.73 ns | 1,197.51 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   922.52 ns |  24.125 ns | 1.322 ns |   921.39 ns |   923.97 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   460.02 ns |  18.464 ns | 1.012 ns |   459.12 ns |   461.11 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   435.34 ns |  18.972 ns | 1.040 ns |   434.53 ns |   436.52 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,175.04 ns | 179.573 ns | 9.843 ns | 1,167.24 ns | 1,186.10 ns | 0.0191 |    1680 B |
