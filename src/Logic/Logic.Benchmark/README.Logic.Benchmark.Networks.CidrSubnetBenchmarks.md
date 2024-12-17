```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **434.02 ns** | **13.479 ns** | **0.739 ns** |   **433.26 ns** |   **434.74 ns** | **0.0076** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    97.79 ns |  4.185 ns | 0.229 ns |    97.56 ns |    98.02 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.16 ns |  0.849 ns | 0.047 ns |   242.11 ns |   242.19 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.29 ns |  2.227 ns | 0.122 ns |    43.16 ns |    43.39 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.21 ns |  1.584 ns | 0.087 ns |   145.11 ns |   145.27 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    34.74 ns |  5.167 ns | 0.283 ns |    34.47 ns |    35.03 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,439.10 ns** | **99.325 ns** | **5.444 ns** | **1,434.69 ns** | **1,445.19 ns** | **0.0229** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   294.59 ns |  7.916 ns | 0.434 ns |   294.10 ns |   294.92 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   740.22 ns | 41.743 ns | 2.288 ns |   738.14 ns |   742.67 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.95 ns | 17.221 ns | 0.944 ns |   127.86 ns |   129.59 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   432.82 ns | 14.874 ns | 0.815 ns |   431.88 ns |   433.31 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   102.63 ns |  8.717 ns | 0.478 ns |   102.16 ns |   103.12 ns | 0.0062 |     528 B |
