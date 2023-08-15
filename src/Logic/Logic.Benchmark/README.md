# Logic.Benchmark.StopwatchBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |     Error |   StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **66.56 ns** |  **5.918 ns** | **0.324 ns** |    **66.19 ns** |    **66.79 ns** | **0.0020** |      **40 B** |
| ValueStopwatch |      1 |    55.94 ns |  2.858 ns | 0.157 ns |    55.77 ns |    56.07 ns |      - |         - |
|      **Stopwatch** |     **10** |   **329.31 ns** |  **2.558 ns** | **0.140 ns** |   **329.15 ns** |   **329.42 ns** | **0.0019** |      **40 B** |
| ValueStopwatch |     10 |   314.52 ns |  2.866 ns | 0.157 ns |   314.39 ns |   314.69 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,823.39 ns** | **12.614 ns** | **0.691 ns** | **2,822.78 ns** | **2,824.14 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,848.99 ns | 30.438 ns | 1.668 ns | 2,848.01 ns | 2,850.92 ns |      - |         - |
# Logic.Benchmark.BinaryArrayConverterBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **37.78 ns** |     **4.265 ns** |   **0.234 ns** |     **37.54 ns** |     **38.01 ns** | **0.0017** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |    104.13 ns |    12.007 ns |   0.658 ns |    103.37 ns |    104.59 ns | 0.0051 |      96 B |
|          ToBinaryArrayIntMod |      1 |     41.96 ns |     2.294 ns |   0.126 ns |     41.83 ns |     42.08 ns | 0.0017 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     21.22 ns |     6.470 ns |   0.355 ns |     20.85 ns |     21.56 ns | 0.0017 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **392.11 ns** |   **125.146 ns** |   **6.860 ns** |    **386.59 ns** |    **399.79 ns** | **0.0167** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |  1,236.20 ns |   409.253 ns |  22.433 ns |  1,218.26 ns |  1,261.35 ns | 0.0534 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    434.54 ns |    16.485 ns |   0.904 ns |    433.56 ns |    435.33 ns | 0.0167 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    278.59 ns |    46.753 ns |   2.563 ns |    275.63 ns |    280.18 ns | 0.0167 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **3,853.45 ns** |   **661.220 ns** |  **36.244 ns** |  **3,823.25 ns** |  **3,893.64 ns** | **0.1678** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 | 15,031.27 ns |   929.881 ns |  50.970 ns | 14,976.76 ns | 15,077.74 ns | 0.5798 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  4,222.46 ns |   238.522 ns |  13.074 ns |  4,207.40 ns |  4,230.86 ns | 0.1678 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  3,636.55 ns |   833.344 ns |  45.678 ns |  3,593.61 ns |  3,684.54 ns | 0.1678 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **9,628.12 ns** | **1,585.726 ns** |  **86.919 ns** |  **9,554.85 ns** |  **9,724.16 ns** | **0.4272** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 38,068.79 ns | 3,592.000 ns | 196.890 ns | 37,867.04 ns | 38,260.43 ns | 1.2207 |  23,209 B |
|          ToBinaryArrayIntMod |    255 | 10,990.05 ns | 1,768.923 ns |  96.961 ns | 10,933.92 ns | 11,102.01 ns | 0.4272 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 | 10,084.19 ns |   990.114 ns |  54.271 ns | 10,036.38 ns | 10,143.18 ns | 0.4272 |   8,160 B |
# Logic.Benchmark.ExponentialBackoffBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |      Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **12.63 ms** |   **3.571 ms** | **0.196 ms** |  **12.42 ms** |  **12.81 ms** |     **586 B** |
| **ExponentialBackoff** |     **10** | **759.60 ms** | **125.067 ms** | **6.855 ms** | **755.55 ms** | **767.51 ms** |   **4,696 B** |
# Logic.Benchmark.StringSplitBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |         Mean |       Error |     StdDev |          Min |          Max |    Gen 0 |   Allocated |
|------------------- |------- |-------------:|------------:|-----------:|-------------:|-------------:|---------:|------------:|
| **StringSplitNoAlloc** |      **1** |     **1.929 μs** |   **0.0169 μs** |  **0.0009 μs** |     **1.928 μs** |     **1.930 μs** |        **-** |           **-** |
|        StringSplit |      1 |     2.769 μs |   0.4903 μs |  0.0269 μs |     2.741 μs |     2.794 μs |   0.1717 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |    **19.300 μs** |   **0.1305 μs** |  **0.0072 μs** |    **19.292 μs** |    **19.307 μs** |        **-** |           **-** |
|        StringSplit |     10 |    27.954 μs |  13.0037 μs |  0.7128 μs |    27.295 μs |    28.710 μs |   1.7090 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |   **192.614 μs** |   **0.4808 μs** |  **0.0264 μs** |   **192.584 μs** |   **192.631 μs** |        **-** |           **-** |
|        StringSplit |    100 |   271.698 μs |  39.9524 μs |  2.1899 μs |   269.828 μs |   274.107 μs |  17.0898 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** | **1,927.896 μs** |  **10.4807 μs** |  **0.5745 μs** | **1,927.427 μs** | **1,928.537 μs** |        **-** |         **2 B** |
|        StringSplit |   1000 | 2,700.891 μs | 449.2289 μs | 24.6237 μs | 2,680.494 μs | 2,728.245 μs | 167.9688 | 3,208,003 B |
# Logic.Benchmark.StringReverseBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                 Method | Number |             Mean |            Error |         StdDev |              Min |              Max |     Gen 0 |    Allocated |
|----------------------- |------- |-----------------:|-----------------:|---------------:|-----------------:|-----------------:|----------:|-------------:|
|           **ArrayReverse** |      **1** |        **105.72 ns** |         **5.613 ns** |       **0.308 ns** |        **105.41 ns** |        **106.03 ns** |    **0.0162** |        **304 B** |
|      EnumerableReverse |      1 |      1,388.37 ns |       119.258 ns |       6.537 ns |      1,381.13 ns |      1,393.83 ns |    0.0305 |        600 B |
|       RecursiveReverse |      1 |      3,055.88 ns |     2,024.463 ns |     110.968 ns |      2,987.84 ns |      3,183.93 ns |    0.3891 |      7,272 B |
|             ReverseXor |      1 |        140.61 ns |        39.673 ns |       2.175 ns |        139.14 ns |        143.11 ns |    0.0162 |        304 B |
|           StackReverse |      1 |        717.42 ns |       250.977 ns |      13.757 ns |        703.07 ns |        730.49 ns |    0.0477 |        896 B |
|             StringSpan |      1 |         77.74 ns |        16.970 ns |       0.930 ns |         76.68 ns |         78.42 ns |    0.0081 |        152 B |
| StringExtensionReverse |      1 |        931.19 ns |        48.111 ns |       2.637 ns |        928.21 ns |        933.21 ns |    0.0372 |        696 B |
|           **ArrayReverse** |     **10** |        **872.47 ns** |       **329.832 ns** |      **18.079 ns** |        **859.32 ns** |        **893.09 ns** |    **0.1621** |      **3,040 B** |
|      EnumerableReverse |     10 |     13,606.15 ns |       303.384 ns |      16.630 ns |     13,590.18 ns |     13,623.37 ns |    0.3204 |      6,000 B |
|       RecursiveReverse |     10 |     32,174.95 ns |     6,593.415 ns |     361.407 ns |     31,892.74 ns |     32,582.29 ns |    3.8452 |     72,720 B |
|             ReverseXor |     10 |      1,337.01 ns |       650.421 ns |      35.652 ns |      1,297.39 ns |      1,366.50 ns |    0.1621 |      3,040 B |
|           StackReverse |     10 |      7,022.66 ns |     1,505.418 ns |      82.517 ns |      6,930.98 ns |      7,090.98 ns |    0.4730 |      8,960 B |
|             StringSpan |     10 |        655.68 ns |        55.991 ns |       3.069 ns |        652.42 ns |        658.52 ns |    0.0811 |      1,520 B |
| StringExtensionReverse |     10 |      9,387.86 ns |       279.404 ns |      15.315 ns |      9,370.23 ns |      9,397.87 ns |    0.3662 |      6,960 B |
|           **ArrayReverse** |    **100** |      **9,083.04 ns** |     **6,979.909 ns** |     **382.592 ns** |      **8,677.56 ns** |      **9,437.65 ns** |    **1.6174** |     **30,400 B** |
|      EnumerableReverse |    100 |    136,459.39 ns |       509.140 ns |      27.908 ns |    136,432.02 ns |    136,487.80 ns |    3.1738 |     60,000 B |
|       RecursiveReverse |    100 |    311,372.42 ns |   184,945.985 ns |  10,137.514 ns |    300,130.07 ns |    319,817.85 ns |   38.5742 |    727,200 B |
|             ReverseXor |    100 |     12,516.22 ns |     5,381.250 ns |     294.964 ns |     12,202.37 ns |     12,787.72 ns |    1.6174 |     30,400 B |
|           StackReverse |    100 |     66,783.90 ns |    18,963.374 ns |   1,039.447 ns |     65,854.65 ns |     67,906.42 ns |    4.7607 |     89,600 B |
|             StringSpan |    100 |      5,934.41 ns |     2,547.726 ns |     139.649 ns |      5,826.27 ns |      6,092.07 ns |    0.8087 |     15,200 B |
| StringExtensionReverse |    100 |     91,928.90 ns |    19,329.419 ns |   1,059.511 ns |     90,706.93 ns |     92,591.41 ns |    3.6621 |     69,600 B |
|           **ArrayReverse** |   **1000** |     **90,829.38 ns** |    **60,491.269 ns** |   **3,315.731 ns** |     **88,084.48 ns** |     **94,513.37 ns** |   **16.2354** |    **304,000 B** |
|      EnumerableReverse |   1000 |  1,358,328.89 ns |    17,120.167 ns |     938.414 ns |  1,357,724.39 ns |  1,359,409.96 ns |   31.2500 |    600,002 B |
|       RecursiveReverse |   1000 |  3,425,288.01 ns |   870,569.065 ns |  47,718.828 ns |  3,380,889.04 ns |  3,475,747.62 ns |  386.7188 |  7,272,003 B |
|             ReverseXor |   1000 |    124,466.74 ns |    91,543.378 ns |   5,017.801 ns |    119,185.71 ns |    129,171.57 ns |   16.1133 |    304,003 B |
|           StackReverse |   1000 |    712,438.80 ns |   155,414.562 ns |   8,518.797 ns |    702,836.03 ns |    719,086.80 ns |   47.8516 |    896,001 B |
|             StringSpan |   1000 |     61,768.03 ns |    27,504.440 ns |   1,507.611 ns |     60,502.64 ns |     63,436.09 ns |    8.1177 |    152,000 B |
| StringExtensionReverse |   1000 |    929,175.92 ns |    14,638.954 ns |     802.410 ns |    928,257.90 ns |    929,743.57 ns |   37.1094 |    696,001 B |
|           **ArrayReverse** |  **10000** |    **847,372.40 ns** |   **776,055.449 ns** |  **42,538.218 ns** |    **799,683.66 ns** |    **881,406.85 ns** |  **162.1094** |  **3,040,001 B** |
|      EnumerableReverse |  10000 | 13,584,104.80 ns |   759,988.770 ns |  41,657.549 ns | 13,548,134.05 ns | 13,629,747.55 ns |  312.5000 |  6,000,013 B |
|       RecursiveReverse |  10000 | 29,921,166.53 ns | 2,640,652.047 ns | 144,743.049 ns | 29,777,148.12 ns | 30,066,623.50 ns | 3875.0000 | 72,720,026 B |
|             ReverseXor |  10000 |  1,216,837.10 ns |   370,693.298 ns |  20,318.951 ns |  1,193,602.12 ns |  1,231,276.21 ns |  162.1094 |  3,040,002 B |
|           StackReverse |  10000 |  6,825,495.51 ns | 3,566,246.659 ns | 195,478.013 ns |  6,672,017.88 ns |  7,045,570.00 ns |  476.5625 |  8,960,006 B |
|             StringSpan |  10000 |    597,847.03 ns |    83,613.384 ns |   4,583.132 ns |    595,081.44 ns |    603,137.35 ns |   81.0547 |  1,520,001 B |
| StringExtensionReverse |  10000 |  9,126,992.98 ns |   869,804.533 ns |  47,676.921 ns |  9,072,137.64 ns |  9,158,452.73 ns |  359.3750 |  6,960,013 B |
# Logic.Benchmark.Networks.CidrBlockBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |       Error |     StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|------------:|-----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **111.702 ns** |   **1.0265 ns** |  **0.0563 ns** |    **111.645 ns** |    **111.757 ns** |         **-** |
|       CidrBlockNewBytes |      1 |      2.077 ns |   0.0285 ns |  0.0016 ns |      2.076 ns |      2.079 ns |         - |
| CidrBlockTryParseString |      1 |    115.072 ns |   0.9870 ns |  0.0541 ns |    115.033 ns |    115.133 ns |         - |
|  CidrBlockTryParseBytes |      1 |     14.813 ns |   0.0130 ns |  0.0007 ns |     14.812 ns |     14.813 ns |         - |
|      **CidrBlockNewString** |     **10** |  **1,151.224 ns** | **283.1668 ns** | **15.5213 ns** |  **1,141.570 ns** |  **1,169.128 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     24.102 ns |   0.8502 ns |  0.0466 ns |     24.074 ns |     24.155 ns |         - |
| CidrBlockTryParseString |     10 |  1,152.824 ns |  18.1444 ns |  0.9946 ns |  1,151.775 ns |  1,153.753 ns |         - |
|  CidrBlockTryParseBytes |     10 |    143.848 ns |   0.2147 ns |  0.0118 ns |    143.838 ns |    143.861 ns |         - |
|      **CidrBlockNewString** |    **100** | **11,494.929 ns** | **776.7616 ns** | **42.5769 ns** | **11,447.109 ns** | **11,528.725 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    243.669 ns |   0.1658 ns |  0.0091 ns |    243.662 ns |    243.679 ns |         - |
| CidrBlockTryParseString |    100 | 11,355.359 ns | 489.9345 ns | 26.8550 ns | 11,330.221 ns | 11,383.652 ns |         - |
|  CidrBlockTryParseBytes |    100 |  1,438.927 ns |   1.7808 ns |  0.0976 ns |  1,438.815 ns |  1,438.994 ns |         - |
# Logic.Benchmark.Networks.SubnetMaskBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **29.15 ns** |    **12.800 ns** |   **0.702 ns** |     **28.36 ns** |     **29.71 ns** | **0.0030** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    242.56 ns |    13.978 ns |   0.766 ns |    241.81 ns |    243.34 ns | 0.0057 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    231.75 ns |    24.666 ns |   1.352 ns |    230.93 ns |    233.31 ns | 0.0060 |     112 B |
|     SubnetMaskFromIPAddress |      1 |    182.13 ns |    11.923 ns |   0.654 ns |    181.39 ns |    182.64 ns | 0.0029 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     87.51 ns |     6.449 ns |   0.353 ns |     87.16 ns |     87.87 ns | 0.0030 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    252.10 ns |    58.628 ns |   3.214 ns |    249.37 ns |    255.64 ns | 0.0086 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **304.59 ns** |   **143.871 ns** |   **7.886 ns** |    **299.00 ns** |    **313.61 ns** | **0.0296** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  2,434.81 ns |    62.820 ns |   3.443 ns |  2,432.37 ns |  2,438.75 ns | 0.0572 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  2,321.29 ns |   118.052 ns |   6.471 ns |  2,313.95 ns |  2,326.18 ns | 0.0572 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |  1,839.28 ns |    78.611 ns |   4.309 ns |  1,834.31 ns |  1,841.82 ns | 0.0286 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    890.01 ns |    99.776 ns |   5.469 ns |    884.05 ns |    894.79 ns | 0.0296 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  2,475.02 ns |   139.259 ns |   7.633 ns |  2,466.51 ns |  2,481.27 ns | 0.0877 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **2,818.11 ns** |   **333.801 ns** |  **18.297 ns** |  **2,804.34 ns** |  **2,838.87 ns** | **0.2975** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 25,128.94 ns |   822.352 ns |  45.076 ns | 25,082.02 ns | 25,171.92 ns | 0.5798 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 23,478.85 ns |   376.309 ns |  20.627 ns | 23,460.05 ns | 23,500.91 ns | 0.5798 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 | 18,019.44 ns |   187.366 ns |  10.270 ns | 18,011.01 ns | 18,030.88 ns | 0.2747 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  8,644.91 ns |   563.309 ns |  30.877 ns |  8,610.65 ns |  8,670.59 ns | 0.2899 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 24,644.44 ns | 2,164.948 ns | 118.668 ns | 24,550.67 ns | 24,777.86 ns | 0.8850 |  16,800 B |
# Logic.Benchmark.ValueTaskDelayBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |    Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **12.66 ms** | **2.542 ms** | **0.139 ms** |  **12.54 ms** |  **12.82 ms** |     **401 B** |
| ValueTaskDelay |      1 |  10.31 ms | 0.240 ms | 0.013 ms |  10.29 ms |  10.32 ms |     209 B |
|      **TaskDelay** |     **10** | **126.01 ms** | **9.613 ms** | **0.527 ms** | **125.43 ms** | **126.45 ms** |   **2,405 B** |
| ValueTaskDelay |     10 | 101.69 ms | 1.914 ms | 0.105 ms | 101.58 ms | 101.79 ms |     421 B |
