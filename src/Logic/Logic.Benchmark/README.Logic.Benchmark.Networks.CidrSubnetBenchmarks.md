```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **511.20 ns** | **23.079 ns** | **1.265 ns** |   **509.75 ns** |   **512.05 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.53 ns |  2.718 ns | 0.149 ns |   114.38 ns |   114.68 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   241.45 ns | 57.724 ns | 3.164 ns |   239.53 ns |   245.10 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.03 ns |  2.963 ns | 0.162 ns |    42.84 ns |    43.12 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   152.92 ns | 28.137 ns | 1.542 ns |   151.92 ns |   154.70 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.43 ns |  0.919 ns | 0.050 ns |    40.39 ns |    40.49 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,598.35 ns** | **60.703 ns** | **3.327 ns** | **1,594.82 ns** | **1,601.42 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   353.33 ns | 26.404 ns | 1.447 ns |   352.12 ns |   354.93 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   745.48 ns | 37.707 ns | 2.067 ns |   743.44 ns |   747.58 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   130.67 ns |  5.077 ns | 0.278 ns |   130.46 ns |   130.99 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   429.03 ns | 15.403 ns | 0.844 ns |   428.48 ns |   430.00 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.27 ns | 10.882 ns | 0.596 ns |   121.65 ns |   122.84 ns | 0.0062 |     528 B |
