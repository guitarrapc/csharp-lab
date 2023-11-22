# Logic.Benchmark.ExponentialBackoffBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **12.09 ms** |  **1.538 ms** | **0.084 ms** |  **12.04 ms** |  **12.18 ms** |     **585 B** |
| **ExponentialBackoff** |     **10** | **758.41 ms** | **57.724 ms** | **3.164 ms** | **755.65 ms** | **761.86 ms** |   **4,696 B** |
# Logic.Benchmark.StopwatchBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |     Error |   StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **61.05 ns** |  **1.589 ns** | **0.087 ns** |    **60.95 ns** |    **61.12 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.57 ns | 10.624 ns | 0.582 ns |    56.17 ns |    57.23 ns |      - |         - |
|      **Stopwatch** |     **10** |   **313.58 ns** |  **3.190 ns** | **0.175 ns** |   **313.45 ns** |   **313.78 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   312.12 ns |  8.699 ns | 0.477 ns |   311.76 ns |   312.66 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,852.71 ns** |  **9.412 ns** | **0.516 ns** | **2,852.11 ns** | **2,853.06 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,873.14 ns | 20.397 ns | 1.118 ns | 2,871.99 ns | 2,874.22 ns |      - |         - |
# Logic.Benchmark.Networks.CidrBlockBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |         Mean |       Error |     StdDev |          Min |          Max | Allocated |
|------------------------ |------- |-------------:|------------:|-----------:|-------------:|-------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **75.629 ns** |   **2.0276 ns** |  **0.1111 ns** |    **75.500 ns** |    **75.696 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     2.046 ns |   0.0369 ns |  0.0020 ns |     2.045 ns |     2.049 ns |         - |
| CidrBlockTryParseString |      1 |    79.792 ns |   2.2547 ns |  0.1236 ns |    79.656 ns |    79.896 ns |         - |
|  CidrBlockTryParseBytes |      1 |    10.508 ns |   1.3533 ns |  0.0742 ns |    10.463 ns |    10.594 ns |         - |
|      **CidrBlockNewString** |     **10** |   **761.197 ns** |  **10.6885 ns** |  **0.5859 ns** |   **760.719 ns** |   **761.850 ns** |         **-** |
|       CidrBlockNewBytes |     10 |    24.834 ns |   0.1460 ns |  0.0080 ns |    24.825 ns |    24.841 ns |         - |
| CidrBlockTryParseString |     10 |   792.811 ns | 408.7603 ns | 22.4055 ns |   779.137 ns |   818.669 ns |         - |
|  CidrBlockTryParseBytes |     10 |   110.344 ns |   0.9573 ns |  0.0525 ns |   110.310 ns |   110.404 ns |         - |
|      **CidrBlockNewString** |    **100** | **7,516.481 ns** | **581.9765 ns** | **31.9001 ns** | **7,492.358 ns** | **7,552.650 ns** |         **-** |
|       CidrBlockNewBytes |    100 |   253.743 ns |   1.9112 ns |  0.1048 ns |   253.623 ns |   253.816 ns |         - |
| CidrBlockTryParseString |    100 | 7,978.555 ns | 207.8374 ns | 11.3923 ns | 7,966.070 ns | 7,988.387 ns |         - |
|  CidrBlockTryParseBytes |    100 | 1,051.878 ns |   8.6008 ns |  0.4714 ns | 1,051.350 ns | 1,052.259 ns |         - |
# Logic.Benchmark.ValueTaskDelayBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |    Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **11.98 ms** | **0.332 ms** | **0.018 ms** |  **11.96 ms** |  **12.00 ms** |     **401 B** |
| ValueTaskDelay |      1 |  10.15 ms | 0.078 ms | 0.004 ms |  10.14 ms |  10.15 ms |     209 B |
|      **TaskDelay** |     **10** | **119.71 ms** | **2.496 ms** | **0.137 ms** | **119.55 ms** | **119.79 ms** |   **2,405 B** |
| ValueTaskDelay |     10 | 101.16 ms | 0.378 ms | 0.021 ms | 101.13 ms | 101.17 ms |     413 B |
# Logic.Benchmark.StringSplitBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |         Mean |       Error |     StdDev |          Min |          Max |   Gen 0 |   Allocated |
|------------------- |------- |-------------:|------------:|-----------:|-------------:|-------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |     **1.407 μs** |   **0.1185 μs** |  **0.0065 μs** |     **1.403 μs** |     **1.415 μs** |       **-** |           **-** |
|        StringSplit |      1 |     1.633 μs |   0.3013 μs |  0.0165 μs |     1.622 μs |     1.652 μs |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |    **14.031 μs** |   **0.1055 μs** |  **0.0058 μs** |    **14.026 μs** |    **14.037 μs** |       **-** |           **-** |
|        StringSplit |     10 |    16.048 μs |   1.1013 μs |  0.0604 μs |    15.987 μs |    16.107 μs |  0.3662 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |   **140.474 μs** |   **6.4670 μs** |  **0.3545 μs** |   **140.259 μs** |   **140.884 μs** |       **-** |           **-** |
|        StringSplit |    100 |   161.532 μs |   2.9340 μs |  0.1608 μs |   161.347 μs |   161.635 μs |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** | **1,401.492 μs** |   **6.4702 μs** |  **0.3547 μs** | **1,401.149 μs** | **1,401.857 μs** |       **-** |         **2 B** |
|        StringSplit |   1000 | 1,613.086 μs | 386.3759 μs | 21.1786 μs | 1,598.578 μs | 1,637.389 μs | 37.1094 | 3,208,002 B |
# Logic.Benchmark.Networks.SubnetMaskBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **28.00 ns** |     **4.924 ns** |   **0.270 ns** |     **27.69 ns** |     **28.20 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    147.47 ns |    10.218 ns |   0.560 ns |    147.03 ns |    148.10 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    144.16 ns |     9.897 ns |   0.543 ns |    143.71 ns |    144.76 ns | 0.0012 |     112 B |
|     SubnetMaskFromIPAddress |      1 |    110.19 ns |     8.614 ns |   0.472 ns |    109.90 ns |    110.73 ns | 0.0005 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     64.85 ns |     0.990 ns |   0.054 ns |     64.80 ns |     64.91 ns | 0.0006 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    158.04 ns |    36.010 ns |   1.974 ns |    156.46 ns |    160.25 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **286.68 ns** |     **4.541 ns** |   **0.249 ns** |    **286.41 ns** |    **286.90 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,490.23 ns |    49.230 ns |   2.698 ns |  1,487.12 ns |  1,491.94 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,452.94 ns |   280.271 ns |  15.363 ns |  1,435.48 ns |  1,464.36 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |  1,145.90 ns |    63.220 ns |   3.465 ns |  1,143.29 ns |  1,149.83 ns | 0.0057 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    643.98 ns |    21.890 ns |   1.200 ns |    642.78 ns |    645.18 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,591.82 ns |   775.241 ns |  42.494 ns |  1,562.82 ns |  1,640.60 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **2,774.35 ns** |    **50.182 ns** |   **2.751 ns** |  **2,772.50 ns** |  **2,777.51 ns** | **0.0648** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 15,080.25 ns | 2,038.090 ns | 111.715 ns | 14,986.89 ns | 15,204.02 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 14,612.32 ns |   170.248 ns |   9.332 ns | 14,601.72 ns | 14,619.29 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 | 11,233.87 ns | 5,083.331 ns | 278.635 ns | 11,023.65 ns | 11,549.91 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  6,320.02 ns |   630.366 ns |  34.553 ns |  6,284.60 ns |  6,353.64 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 15,647.95 ns | 1,037.438 ns |  56.865 ns | 15,594.37 ns | 15,707.61 ns | 0.1831 |  16,800 B |
# Logic.Benchmark.StringReverseBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                 Method | Number |             Mean |            Error |        StdDev |              Min |              Max |    Gen 0 |    Allocated |
|----------------------- |------- |-----------------:|-----------------:|--------------:|-----------------:|-----------------:|---------:|-------------:|
|           **ArrayReverse** |      **1** |         **89.44 ns** |        **14.390 ns** |      **0.789 ns** |         **88.57 ns** |         **90.11 ns** |   **0.0036** |        **304 B** |
|      EnumerableReverse |      1 |        899.59 ns |        14.233 ns |      0.780 ns |        898.69 ns |        900.08 ns |   0.0067 |        600 B |
|       RecursiveReverse |      1 |      1,772.56 ns |       325.678 ns |     17.852 ns |      1,762.21 ns |      1,793.17 ns |   0.0858 |      7,272 B |
|             ReverseXor |      1 |        124.31 ns |        14.069 ns |      0.771 ns |        123.49 ns |        125.02 ns |   0.0036 |        304 B |
|           StackReverse |      1 |        494.97 ns |        20.652 ns |      1.132 ns |        494.07 ns |        496.24 ns |   0.0105 |        896 B |
|             StringSpan |      1 |         71.35 ns |         2.340 ns |      0.128 ns |         71.21 ns |         71.45 ns |   0.0018 |        152 B |
| StringExtensionReverse |      1 |        608.15 ns |        44.788 ns |      2.455 ns |        605.46 ns |        610.28 ns |   0.0076 |        696 B |
|           **ArrayReverse** |     **10** |        **789.70 ns** |         **2.651 ns** |      **0.145 ns** |        **789.58 ns** |        **789.86 ns** |   **0.0362** |      **3,040 B** |
|      EnumerableReverse |     10 |      9,403.61 ns |     9,056.003 ns |    496.390 ns |      9,093.77 ns |      9,976.14 ns |   0.0610 |      6,000 B |
|       RecursiveReverse |     10 |     17,936.76 ns |     2,677.947 ns |    146.787 ns |     17,768.71 ns |     18,039.95 ns |   0.8545 |     72,720 B |
|             ReverseXor |     10 |      1,190.52 ns |       108.276 ns |      5.935 ns |      1,186.55 ns |      1,197.34 ns |   0.0362 |      3,040 B |
|           StackReverse |     10 |      4,560.17 ns |       301.525 ns |     16.528 ns |      4,541.69 ns |      4,573.52 ns |   0.1068 |      8,960 B |
|             StringSpan |     10 |        591.24 ns |       159.030 ns |      8.717 ns |        586.17 ns |        601.30 ns |   0.0181 |      1,520 B |
| StringExtensionReverse |     10 |      6,326.44 ns |     3,150.605 ns |    172.695 ns |      6,193.21 ns |      6,521.55 ns |   0.0763 |      6,960 B |
|           **ArrayReverse** |    **100** |      **7,798.39 ns** |       **655.273 ns** |     **35.918 ns** |      **7,757.15 ns** |      **7,822.80 ns** |   **0.3510** |     **30,400 B** |
|      EnumerableReverse |    100 |     90,695.57 ns |     1,496.935 ns |     82.052 ns |     90,627.82 ns |     90,786.80 ns |   0.6104 |     60,000 B |
|       RecursiveReverse |    100 |    174,001.58 ns |     7,691.211 ns |    421.581 ns |    173,639.79 ns |    174,464.54 ns |   8.5449 |    727,200 B |
|             ReverseXor |    100 |     11,277.70 ns |        88.095 ns |      4.829 ns |     11,272.25 ns |     11,281.45 ns |   0.3510 |     30,400 B |
|           StackReverse |    100 |     48,120.37 ns |     4,885.677 ns |    267.800 ns |     47,929.48 ns |     48,426.50 ns |   1.0376 |     89,600 B |
|             StringSpan |    100 |      5,689.04 ns |       640.469 ns |     35.106 ns |      5,650.00 ns |      5,718.02 ns |   0.1755 |     15,200 B |
| StringExtensionReverse |    100 |     64,812.55 ns |    32,105.995 ns |  1,759.838 ns |     63,021.20 ns |     66,539.09 ns |   0.7324 |     69,602 B |
|           **ArrayReverse** |   **1000** |     **78,221.84 ns** |    **22,289.710 ns** |  **1,221.774 ns** |     **77,065.29 ns** |     **79,499.78 ns** |   **3.5400** |    **304,000 B** |
|      EnumerableReverse |   1000 |    915,395.58 ns |    99,141.992 ns |  5,434.307 ns |    909,387.47 ns |    919,967.64 ns |   6.8359 |    600,001 B |
|       RecursiveReverse |   1000 |  1,734,812.79 ns |   209,042.656 ns | 11,458.333 ns |  1,726,483.16 ns |  1,747,880.21 ns |  85.9375 |  7,272,002 B |
|             ReverseXor |   1000 |    115,966.56 ns |    52,435.031 ns |  2,874.141 ns |    113,711.71 ns |    119,202.87 ns |   3.5400 |    304,000 B |
|           StackReverse |   1000 |    475,759.27 ns |     4,095.388 ns |    224.482 ns |    475,506.12 ns |    475,934.09 ns |  10.2539 |    896,000 B |
|             StringSpan |   1000 |     57,501.36 ns |    19,743.823 ns |  1,082.226 ns |     56,534.99 ns |     58,670.70 ns |   1.7700 |    152,000 B |
| StringExtensionReverse |   1000 |    613,921.91 ns |     8,215.932 ns |    450.343 ns |    613,481.70 ns |    614,381.75 ns |   7.8125 |    696,001 B |
|           **ArrayReverse** |  **10000** |    **772,515.29 ns** |    **22,750.018 ns** |  **1,247.005 ns** |    **771,101.40 ns** |    **773,458.26 ns** |  **36.1328** |  **3,040,001 B** |
|      EnumerableReverse |  10000 |  9,072,495.16 ns | 1,537,074.929 ns | 84,252.264 ns |  8,988,260.80 ns |  9,156,765.31 ns |  62.5000 |  6,000,013 B |
|       RecursiveReverse |  10000 | 17,234,245.83 ns |   581,171.286 ns | 31,855.959 ns | 17,197,665.47 ns | 17,255,884.12 ns | 843.7500 | 72,720,026 B |
|             ReverseXor |  10000 |  1,120,242.80 ns |    54,892.460 ns |  3,008.841 ns |  1,118,091.77 ns |  1,123,681.13 ns |  35.1563 |  3,040,023 B |
|           StackReverse |  10000 |  4,795,379.95 ns |   303,480.516 ns | 16,634.791 ns |  4,776,288.92 ns |  4,806,760.08 ns | 101.5625 |  8,960,006 B |
|             StringSpan |  10000 |    565,450.00 ns |   139,588.012 ns |  7,651.290 ns |    558,041.82 ns |    573,323.19 ns |  17.5781 |  1,520,001 B |
| StringExtensionReverse |  10000 |  6,210,346.34 ns |   932,340.131 ns | 51,104.709 ns |  6,155,954.20 ns |  6,257,361.91 ns |  78.1250 |  6,960,006 B |
# Logic.Benchmark.BinaryArrayConverterBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.09 ns** |     **0.781 ns** |  **0.043 ns** |     **18.05 ns** |     **18.13 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     70.08 ns |     7.787 ns |  0.427 ns |     69.72 ns |     70.55 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     20.41 ns |     4.808 ns |  0.264 ns |     20.10 ns |     20.58 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     13.84 ns |     6.197 ns |  0.340 ns |     13.48 ns |     14.16 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **193.12 ns** |     **8.657 ns** |  **0.475 ns** |    **192.73 ns** |    **193.64 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    838.89 ns |    36.833 ns |  2.019 ns |    837.32 ns |    841.17 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    216.13 ns |   100.801 ns |  5.525 ns |    211.33 ns |    222.17 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    146.20 ns |    26.053 ns |  1.428 ns |    144.98 ns |    147.77 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,852.63 ns** |   **269.045 ns** | **14.747 ns** |  **1,837.09 ns** |  **1,866.43 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  9,268.48 ns | 1,411.734 ns | 77.382 ns |  9,215.76 ns |  9,357.32 ns | 0.1221 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,065.79 ns |   622.446 ns | 34.118 ns |  2,042.16 ns |  2,104.90 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,786.48 ns |    28.188 ns |  1.545 ns |  1,785.36 ns |  1,788.24 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,692.39 ns** |   **576.248 ns** | **31.586 ns** |  **4,660.20 ns** |  **4,723.34 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 21,687.65 ns |   407.099 ns | 22.314 ns | 21,668.20 ns | 21,712.01 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,204.25 ns |   137.375 ns |  7.530 ns |  5,196.44 ns |  5,211.46 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  4,950.06 ns |   741.950 ns | 40.669 ns |  4,924.62 ns |  4,996.97 ns | 0.0916 |   8,160 B |
