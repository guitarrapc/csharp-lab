```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **503.45 ns** |  **87.656 ns** | **4.805 ns** |   **499.44 ns** |   **508.78 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.55 ns |   1.665 ns | 0.091 ns |   113.48 ns |   113.65 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.79 ns |  16.386 ns | 0.898 ns |   236.15 ns |   237.82 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.81 ns |   2.884 ns | 0.158 ns |    41.71 ns |    41.99 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.10 ns |  47.453 ns | 2.601 ns |   141.46 ns |   146.10 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.95 ns |   1.985 ns | 0.109 ns |    39.83 ns |    40.05 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,619.53 ns** |  **35.979 ns** | **1.972 ns** | **1,617.26 ns** | **1,620.88 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   355.27 ns | 166.399 ns | 9.121 ns |   349.52 ns |   365.78 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   754.59 ns |  27.082 ns | 1.484 ns |   753.53 ns |   756.29 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.73 ns |  41.424 ns | 2.271 ns |   125.78 ns |   130.22 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   444.58 ns | 116.602 ns | 6.391 ns |   438.72 ns |   451.40 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.25 ns |  15.865 ns | 0.870 ns |   119.26 ns |   120.88 ns | 0.0062 |     528 B |
