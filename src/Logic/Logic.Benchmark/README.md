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
| **ExponentialBackoff** |      **1** |  **12.08 ms** |  **0.365 ms** | **0.020 ms** |  **12.07 ms** |  **12.10 ms** |     **585 B** |
| **ExponentialBackoff** |     **10** | **755.79 ms** | **36.443 ms** | **1.998 ms** | **753.79 ms** | **757.78 ms** |   **4,696 B** |
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
|         Method | Number |        Mean |      Error |    StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **60.71 ns** |   **6.724 ns** |  **0.369 ns** |    **60.29 ns** |    **61.00 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.20 ns |   0.467 ns |  0.026 ns |    56.19 ns |    56.23 ns |      - |         - |
|      **Stopwatch** |     **10** |   **314.49 ns** |  **30.031 ns** |  **1.646 ns** |   **313.45 ns** |   **316.39 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   312.08 ns |   9.781 ns |  0.536 ns |   311.63 ns |   312.67 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,871.29 ns** | **634.560 ns** | **34.782 ns** | **2,850.95 ns** | **2,911.46 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,871.80 ns |   0.709 ns |  0.039 ns | 2,871.76 ns | 2,871.83 ns |      - |         - |
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
|      **CidrBlockNewString** |      **1** |    **75.452 ns** |   **6.4629 ns** |  **0.3543 ns** |    **75.215 ns** |    **75.859 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     2.153 ns |   0.1627 ns |  0.0089 ns |     2.148 ns |     2.163 ns |         - |
| CidrBlockTryParseString |      1 |    80.227 ns |   2.3121 ns |  0.1267 ns |    80.090 ns |    80.341 ns |         - |
|  CidrBlockTryParseBytes |      1 |    10.479 ns |   0.5045 ns |  0.0277 ns |    10.463 ns |    10.511 ns |         - |
|      **CidrBlockNewString** |     **10** |   **761.676 ns** |   **3.4051 ns** |  **0.1866 ns** |   **761.475 ns** |   **761.844 ns** |         **-** |
|       CidrBlockNewBytes |     10 |    24.829 ns |   0.0675 ns |  0.0037 ns |    24.825 ns |    24.833 ns |         - |
| CidrBlockTryParseString |     10 |   810.625 ns |   6.8910 ns |  0.3777 ns |   810.270 ns |   811.022 ns |         - |
|  CidrBlockTryParseBytes |     10 |   104.536 ns |   0.5786 ns |  0.0317 ns |   104.506 ns |   104.569 ns |         - |
|      **CidrBlockNewString** |    **100** | **7,558.904 ns** | **380.9320 ns** | **20.8802 ns** | **7,545.937 ns** | **7,582.991 ns** |         **-** |
|       CidrBlockNewBytes |    100 |   253.331 ns |   1.6978 ns |  0.0931 ns |   253.225 ns |   253.397 ns |         - |
| CidrBlockTryParseString |    100 | 7,952.988 ns |  26.7880 ns |  1.4683 ns | 7,951.629 ns | 7,954.546 ns |         - |
|  CidrBlockTryParseBytes |    100 | 1,051.485 ns |   3.6633 ns |  0.2008 ns | 1,051.313 ns | 1,051.706 ns |         - |
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
|         Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **12.68 ms** |  **5.416 ms** | **0.297 ms** |  **12.50 ms** |  **13.02 ms** |     **401 B** |
| ValueTaskDelay |      1 |  10.15 ms |  0.041 ms | 0.002 ms |  10.15 ms |  10.15 ms |     209 B |
|      **TaskDelay** |     **10** | **125.89 ms** | **58.953 ms** | **3.231 ms** | **122.96 ms** | **129.36 ms** |   **2,405 B** |
| ValueTaskDelay |     10 | 101.17 ms |  0.848 ms | 0.046 ms | 101.13 ms | 101.22 ms |     413 B |
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
|             Method | Number |         Mean |       Error |    StdDev |          Min |          Max |   Gen 0 |   Allocated |
|------------------- |------- |-------------:|------------:|----------:|-------------:|-------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |     **1.403 μs** |   **0.0128 μs** | **0.0007 μs** |     **1.402 μs** |     **1.403 μs** |       **-** |           **-** |
|        StringSplit |      1 |     1.609 μs |   0.0809 μs | 0.0044 μs |     1.605 μs |     1.614 μs |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |    **14.012 μs** |   **0.0178 μs** | **0.0010 μs** |    **14.011 μs** |    **14.013 μs** |       **-** |           **-** |
|        StringSplit |     10 |    16.277 μs |   6.2116 μs | 0.3405 μs |    16.078 μs |    16.670 μs |  0.3662 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |   **144.911 μs** | **102.6909 μs** | **5.6288 μs** |   **140.196 μs** |   **151.143 μs** |       **-** |           **-** |
|        StringSplit |    100 |   160.097 μs |   8.4374 μs | 0.4625 μs |   159.729 μs |   160.616 μs |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** | **1,406.591 μs** | **129.1522 μs** | **7.0793 μs** | **1,402.303 μs** | **1,414.762 μs** |       **-** |         **2 B** |
|        StringSplit |   1000 | 1,615.449 μs |  28.8080 μs | 1.5791 μs | 1,613.692 μs | 1,616.749 μs | 37.1094 | 3,208,002 B |
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
|    **SubnetMaskFromCidrNotion** |      **1** |     **28.00 ns** |     **1.130 ns** |   **0.062 ns** |     **27.96 ns** |     **28.07 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    147.42 ns |    15.515 ns |   0.850 ns |    146.80 ns |    148.39 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    146.01 ns |     0.591 ns |   0.032 ns |    145.98 ns |    146.04 ns | 0.0012 |     112 B |
|     SubnetMaskFromIPAddress |      1 |    113.73 ns |    10.554 ns |   0.579 ns |    113.27 ns |    114.38 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     64.16 ns |     4.006 ns |   0.220 ns |     63.91 ns |     64.31 ns | 0.0006 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    156.11 ns |     1.951 ns |   0.107 ns |    156.01 ns |    156.22 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **283.65 ns** |    **28.305 ns** |   **1.552 ns** |    **282.58 ns** |    **285.43 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,575.89 ns |    39.764 ns |   2.180 ns |  1,573.40 ns |  1,577.47 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,450.71 ns |   367.124 ns |  20.123 ns |  1,436.39 ns |  1,473.71 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |  1,158.86 ns |   304.350 ns |  16.682 ns |  1,146.25 ns |  1,177.77 ns | 0.0057 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    662.58 ns |   386.956 ns |  21.210 ns |    638.89 ns |    679.81 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,569.86 ns |   144.829 ns |   7.939 ns |  1,561.00 ns |  1,576.34 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **2,787.11 ns** |   **488.138 ns** |  **26.757 ns** |  **2,769.41 ns** |  **2,817.89 ns** | **0.0648** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 14,733.76 ns | 1,187.971 ns |  65.117 ns | 14,658.92 ns | 14,777.45 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 14,379.88 ns |   267.318 ns |  14.653 ns | 14,364.45 ns | 14,393.61 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 | 11,403.99 ns | 2,470.246 ns | 135.403 ns | 11,310.61 ns | 11,559.28 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  6,284.19 ns |   144.171 ns |   7.903 ns |  6,278.75 ns |  6,293.26 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 15,766.99 ns | 6,155.759 ns | 337.418 ns | 15,548.79 ns | 16,155.63 ns | 0.1831 |  16,800 B |
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
|                 Method | Number |             Mean |            Error |         StdDev |              Min |              Max |    Gen 0 |    Allocated |
|----------------------- |------- |-----------------:|-----------------:|---------------:|-----------------:|-----------------:|---------:|-------------:|
|           **ArrayReverse** |      **1** |         **87.13 ns** |         **9.791 ns** |       **0.537 ns** |         **86.61 ns** |         **87.68 ns** |   **0.0036** |        **304 B** |
|      EnumerableReverse |      1 |        963.70 ns |       411.283 ns |      22.544 ns |        950.64 ns |        989.73 ns |   0.0057 |        600 B |
|       RecursiveReverse |      1 |      1,794.38 ns |        65.388 ns |       3.584 ns |      1,791.08 ns |      1,798.20 ns |   0.0858 |      7,272 B |
|             ReverseXor |      1 |        122.48 ns |        10.549 ns |       0.578 ns |        122.09 ns |        123.15 ns |   0.0036 |        304 B |
|           StackReverse |      1 |        466.94 ns |        26.502 ns |       1.453 ns |        465.74 ns |        468.55 ns |   0.0105 |        896 B |
|             StringSpan |      1 |         73.43 ns |         0.893 ns |       0.049 ns |         73.38 ns |         73.48 ns |   0.0018 |        152 B |
| StringExtensionReverse |      1 |        595.95 ns |       186.302 ns |      10.212 ns |        588.20 ns |        607.52 ns |   0.0076 |        696 B |
|           **ArrayReverse** |     **10** |        **793.03 ns** |        **10.663 ns** |       **0.584 ns** |        **792.38 ns** |        **793.51 ns** |   **0.0362** |      **3,040 B** |
|      EnumerableReverse |     10 |      9,115.14 ns |       549.656 ns |      30.129 ns |      9,088.62 ns |      9,147.90 ns |   0.0610 |      6,000 B |
|       RecursiveReverse |     10 |     17,400.08 ns |     3,716.561 ns |     203.717 ns |     17,251.18 ns |     17,632.24 ns |   0.8545 |     72,720 B |
|             ReverseXor |     10 |      1,173.35 ns |        75.371 ns |       4.131 ns |      1,168.93 ns |      1,177.11 ns |   0.0362 |      3,040 B |
|           StackReverse |     10 |      4,531.30 ns |        45.214 ns |       2.478 ns |      4,528.50 ns |      4,533.20 ns |   0.1068 |      8,960 B |
|             StringSpan |     10 |        578.05 ns |         4.575 ns |       0.251 ns |        577.87 ns |        578.34 ns |   0.0181 |      1,520 B |
| StringExtensionReverse |     10 |      6,257.12 ns |       197.896 ns |      10.847 ns |      6,245.27 ns |      6,266.56 ns |   0.0763 |      6,960 B |
|           **ArrayReverse** |    **100** |      **7,814.50 ns** |       **989.308 ns** |      **54.227 ns** |      **7,779.06 ns** |      **7,876.93 ns** |   **0.3510** |     **30,400 B** |
|      EnumerableReverse |    100 |     90,401.67 ns |     5,341.275 ns |     292.773 ns |     90,194.79 ns |     90,736.66 ns |   0.6104 |     60,000 B |
|       RecursiveReverse |    100 |    171,901.74 ns |    26,735.527 ns |   1,465.464 ns |    170,924.02 ns |    173,586.69 ns |   8.5449 |    727,200 B |
|             ReverseXor |    100 |     11,367.18 ns |     1,064.924 ns |      58.372 ns |     11,328.01 ns |     11,434.27 ns |   0.3510 |     30,400 B |
|           StackReverse |    100 |     48,001.65 ns |     2,574.122 ns |     141.096 ns |     47,856.31 ns |     48,138.08 ns |   1.0376 |     89,600 B |
|             StringSpan |    100 |      5,716.32 ns |       112.526 ns |       6.168 ns |      5,709.23 ns |      5,720.47 ns |   0.1755 |     15,200 B |
| StringExtensionReverse |    100 |     63,147.38 ns |    23,444.673 ns |   1,285.082 ns |     62,366.69 ns |     64,630.58 ns |   0.7935 |     69,600 B |
|           **ArrayReverse** |   **1000** |     **76,839.40 ns** |       **603.196 ns** |      **33.063 ns** |     **76,811.96 ns** |     **76,876.11 ns** |   **3.5400** |    **304,000 B** |
|      EnumerableReverse |   1000 |    904,197.90 ns |    48,958.537 ns |   2,683.583 ns |    902,351.20 ns |    907,276.21 ns |   6.8359 |    600,001 B |
|       RecursiveReverse |   1000 |  1,727,586.52 ns |    66,544.937 ns |   3,647.553 ns |  1,725,180.91 ns |  1,731,783.39 ns |  85.9375 |  7,272,002 B |
|             ReverseXor |   1000 |    112,843.97 ns |     1,953.520 ns |     107.079 ns |    112,724.45 ns |    112,931.15 ns |   3.5400 |    304,000 B |
|           StackReverse |   1000 |    482,452.76 ns |    44,425.990 ns |   2,435.138 ns |    481,021.17 ns |    485,264.46 ns |  10.2539 |    896,000 B |
|             StringSpan |   1000 |     57,912.87 ns |    13,066.800 ns |     716.235 ns |     57,112.20 ns |     58,492.63 ns |   1.7700 |    152,000 B |
| StringExtensionReverse |   1000 |    630,331.24 ns |   158,186.150 ns |   8,670.717 ns |    621,518.99 ns |    638,853.13 ns |   7.8125 |    696,001 B |
|           **ArrayReverse** |  **10000** |    **765,384.44 ns** |   **109,152.211 ns** |   **5,983.001 ns** |    **761,252.20 ns** |    **772,245.32 ns** |  **36.1328** |  **3,040,001 B** |
|      EnumerableReverse |  10000 |  9,323,365.50 ns | 3,392,358.980 ns | 185,946.643 ns |  9,148,437.31 ns |  9,518,654.69 ns |  62.5000 |  6,000,013 B |
|       RecursiveReverse |  10000 | 17,217,237.66 ns | 1,460,720.616 ns |  80,067.026 ns | 17,152,637.75 ns | 17,306,816.47 ns | 843.7500 | 72,720,026 B |
|             ReverseXor |  10000 |  1,134,059.59 ns |   156,907.960 ns |   8,600.655 ns |  1,124,390.44 ns |  1,140,856.79 ns |  35.1563 |  3,040,002 B |
|           StackReverse |  10000 |  4,489,055.22 ns |   108,361.565 ns |   5,939.663 ns |  4,482,207.74 ns |  4,492,816.07 ns | 101.5625 |  8,960,006 B |
|             StringSpan |  10000 |    566,854.58 ns |   146,335.777 ns |   8,021.158 ns |    561,622.79 ns |    576,089.40 ns |  17.5781 |  1,520,001 B |
| StringExtensionReverse |  10000 |  6,266,697.53 ns |    90,911.417 ns |   4,983.162 ns |  6,261,123.84 ns |  6,270,722.27 ns |  78.1250 |  6,960,006 B |
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
|                       Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.44 ns** |     **2.808 ns** |   **0.154 ns** |     **18.30 ns** |     **18.61 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     85.20 ns |     3.769 ns |   0.207 ns |     84.98 ns |     85.39 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     21.11 ns |    12.728 ns |   0.698 ns |     20.54 ns |     21.89 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     13.50 ns |     1.287 ns |   0.071 ns |     13.43 ns |     13.57 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **195.44 ns** |    **58.563 ns** |   **3.210 ns** |    **193.52 ns** |    **199.15 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    838.33 ns |     1.241 ns |   0.068 ns |    838.25 ns |    838.39 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    215.91 ns |    85.475 ns |   4.685 ns |    212.53 ns |    221.26 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    146.40 ns |    23.833 ns |   1.306 ns |    145.32 ns |    147.85 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,859.78 ns** |   **122.652 ns** |   **6.723 ns** |  **1,853.09 ns** |  **1,866.53 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  9,304.70 ns | 1,293.210 ns |  70.885 ns |  9,236.38 ns |  9,377.90 ns | 0.1221 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,101.54 ns |    61.010 ns |   3.344 ns |  2,098.56 ns |  2,105.16 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,785.37 ns |   157.914 ns |   8.656 ns |  1,779.33 ns |  1,795.28 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,731.36 ns** |    **98.222 ns** |   **5.384 ns** |  **4,727.86 ns** |  **4,737.56 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 22,768.06 ns | 6,634.836 ns | 363.678 ns | 22,530.94 ns | 23,186.78 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,271.66 ns |   336.392 ns |  18.439 ns |  5,259.11 ns |  5,292.83 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  4,973.48 ns |   100.221 ns |   5.493 ns |  4,969.33 ns |  4,979.71 ns | 0.0916 |   8,160 B |
