# Logic.Benchmark.StopwatchBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |      Error |    StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **65.70 ns** |  **32.064 ns** |  **1.758 ns** |    **64.52 ns** |    **67.72 ns** | **0.0020** |      **40 B** |
| ValueStopwatch |      1 |    57.00 ns |   9.553 ns |  0.524 ns |    56.41 ns |    57.43 ns |      - |         - |
|      **Stopwatch** |     **10** |   **355.63 ns** | **159.353 ns** |  **8.735 ns** |   **345.85 ns** |   **362.66 ns** | **0.0019** |      **40 B** |
| ValueStopwatch |     10 |   329.85 ns |  58.895 ns |  3.228 ns |   327.08 ns |   333.40 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,873.05 ns** | **617.059 ns** | **33.823 ns** | **2,835.52 ns** | **2,901.17 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,914.41 ns | 358.192 ns | 19.634 ns | 2,897.13 ns | 2,935.76 ns |      - |         - |
# Logic.Benchmark.BinaryArrayConverterBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **39.28 ns** |     **9.330 ns** |   **0.511 ns** |     **38.72 ns** |     **39.72 ns** | **0.0017** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |    103.77 ns |    16.265 ns |   0.892 ns |    103.18 ns |    104.80 ns | 0.0051 |      96 B |
|          ToBinaryArrayIntMod |      1 |     42.14 ns |    31.637 ns |   1.734 ns |     40.14 ns |     43.17 ns | 0.0017 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     20.34 ns |     7.695 ns |   0.422 ns |     19.85 ns |     20.58 ns | 0.0017 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **387.98 ns** |    **58.471 ns** |   **3.205 ns** |    **385.42 ns** |    **391.57 ns** | **0.0167** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |  1,192.05 ns |   733.372 ns |  40.199 ns |  1,166.38 ns |  1,238.38 ns | 0.0534 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    422.23 ns |    81.525 ns |   4.469 ns |    417.33 ns |    426.08 ns | 0.0167 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    262.91 ns |   152.920 ns |   8.382 ns |    254.07 ns |    270.74 ns | 0.0167 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **3,765.12 ns** |   **287.359 ns** |  **15.751 ns** |  **3,747.81 ns** |  **3,778.62 ns** | **0.1678** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 | 14,804.65 ns | 7,507.749 ns | 411.525 ns | 14,442.40 ns | 15,252.11 ns | 0.5798 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  4,380.59 ns | 3,204.927 ns | 175.673 ns |  4,180.29 ns |  4,508.51 ns | 0.1678 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  3,601.68 ns |   395.765 ns |  21.693 ns |  3,576.78 ns |  3,616.52 ns | 0.1678 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** | **10,699.73 ns** | **1,161.938 ns** |  **63.690 ns** | **10,640.94 ns** | **10,767.39 ns** | **0.4272** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 42,330.27 ns | 5,959.672 ns | 326.670 ns | 41,977.05 ns | 42,621.50 ns | 1.2207 |  23,208 B |
|          ToBinaryArrayIntMod |    255 | 12,371.63 ns | 1,342.567 ns |  73.591 ns | 12,288.38 ns | 12,428.03 ns | 0.4272 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 | 11,171.99 ns | 2,312.073 ns | 126.733 ns | 11,043.72 ns | 11,297.13 ns | 0.4272 |   8,160 B |
# Logic.Benchmark.ExponentialBackoffBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **12.22 ms** |  **0.859 ms** | **0.047 ms** |  **12.17 ms** |  **12.27 ms** |     **585 B** |
| **ExponentialBackoff** |     **10** | **756.69 ms** | **20.730 ms** | **1.136 ms** | **755.88 ms** | **757.99 ms** |   **4,696 B** |
# Logic.Benchmark.StringSplitBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |         Mean |       Error |     StdDev |          Min |          Max |    Gen 0 |   Allocated |
|------------------- |------- |-------------:|------------:|-----------:|-------------:|-------------:|---------:|------------:|
| **StringSplitNoAlloc** |      **1** |     **2.165 μs** |   **0.3020 μs** |  **0.0166 μs** |     **2.149 μs** |     **2.182 μs** |        **-** |           **-** |
|        StringSplit |      1 |     2.984 μs |   1.3091 μs |  0.0718 μs |     2.910 μs |     3.053 μs |   0.1678 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |    **22.053 μs** |   **8.7729 μs** |  **0.4809 μs** |    **21.744 μs** |    **22.607 μs** |        **-** |           **-** |
|        StringSplit |     10 |    30.988 μs |  10.1350 μs |  0.5555 μs |    30.449 μs |    31.559 μs |   1.7090 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |   **210.353 μs** | **158.4049 μs** |  **8.6827 μs** |   **201.512 μs** |   **218.868 μs** |        **-** |           **-** |
|        StringSplit |    100 |   279.160 μs |  81.7577 μs |  4.4814 μs |   275.362 μs |   284.103 μs |  17.0898 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** | **1,993.014 μs** | **270.4963 μs** | **14.8268 μs** | **1,982.180 μs** | **2,009.911 μs** |        **-** |         **3 B** |
|        StringSplit |   1000 | 2,681.585 μs | 635.4910 μs | 34.8334 μs | 2,641.375 μs | 2,702.519 μs | 167.9688 | 3,208,003 B |
# Logic.Benchmark.StringReverseBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                 Method | Number |             Mean |           Error |         StdDev |              Min |              Max |     Gen 0 |    Allocated |
|----------------------- |------- |-----------------:|----------------:|---------------:|-----------------:|-----------------:|----------:|-------------:|
|           **ArrayReverse** |      **1** |        **101.01 ns** |        **27.08 ns** |       **1.484 ns** |         **99.86 ns** |        **102.68 ns** |    **0.0162** |        **304 B** |
|      EnumerableReverse |      1 |      1,401.23 ns |       311.28 ns |      17.062 ns |      1,381.99 ns |      1,414.52 ns |    0.0305 |        600 B |
|       RecursiveReverse |      1 |      2,809.86 ns |       487.56 ns |      26.725 ns |      2,791.68 ns |      2,840.55 ns |    0.3891 |      7,272 B |
|             ReverseXor |      1 |        140.43 ns |        69.72 ns |       3.822 ns |        137.02 ns |        144.56 ns |    0.0162 |        304 B |
|           StackReverse |      1 |        752.17 ns |       500.92 ns |      27.457 ns |        733.55 ns |        783.70 ns |    0.0477 |        896 B |
|             StringSpan |      1 |         81.37 ns |        86.75 ns |       4.755 ns |         75.89 ns |         84.40 ns |    0.0081 |        152 B |
| StringExtensionReverse |      1 |        992.41 ns |       557.73 ns |      30.571 ns |        970.79 ns |      1,027.39 ns |    0.0362 |        696 B |
|           **ArrayReverse** |     **10** |        **916.74 ns** |     **1,660.95 ns** |      **91.043 ns** |        **817.84 ns** |        **997.06 ns** |    **0.1621** |      **3,040 B** |
|      EnumerableReverse |     10 |     13,681.24 ns |     5,266.60 ns |     288.680 ns |     13,478.01 ns |     14,011.68 ns |    0.3204 |      6,000 B |
|       RecursiveReverse |     10 |     27,557.56 ns |    22,540.75 ns |   1,235.535 ns |     26,710.31 ns |     28,975.25 ns |    3.8757 |     72,720 B |
|             ReverseXor |     10 |      1,227.15 ns |       220.44 ns |      12.083 ns |      1,217.24 ns |      1,240.61 ns |    0.1621 |      3,040 B |
|           StackReverse |     10 |      7,223.78 ns |     4,823.58 ns |     264.397 ns |      7,069.72 ns |      7,529.07 ns |    0.4730 |      8,960 B |
|             StringSpan |     10 |        597.59 ns |       331.50 ns |      18.171 ns |        585.07 ns |        618.43 ns |    0.0811 |      1,520 B |
| StringExtensionReverse |     10 |      9,132.85 ns |     5,813.61 ns |     318.664 ns |      8,897.59 ns |      9,495.50 ns |    0.3662 |      6,960 B |
|           **ArrayReverse** |    **100** |      **8,262.19 ns** |     **4,696.88 ns** |     **257.452 ns** |      **8,081.28 ns** |      **8,556.93 ns** |    **1.6174** |     **30,400 B** |
|      EnumerableReverse |    100 |    137,009.63 ns |    64,088.20 ns |   3,512.890 ns |    132,980.55 ns |    139,430.76 ns |    3.1738 |     60,000 B |
|       RecursiveReverse |    100 |    278,192.04 ns |    18,035.57 ns |     988.590 ns |    277,307.46 ns |    279,259.19 ns |   38.5742 |    727,200 B |
|             ReverseXor |    100 |     12,204.05 ns |     1,542.66 ns |      84.558 ns |     12,114.84 ns |     12,283.03 ns |    1.6174 |     30,400 B |
|           StackReverse |    100 |     67,059.01 ns |    31,365.32 ns |   1,719.239 ns |     65,977.39 ns |     69,041.47 ns |    4.7607 |     89,600 B |
|             StringSpan |    100 |      5,792.76 ns |       828.52 ns |      45.414 ns |      5,747.27 ns |      5,838.10 ns |    0.8087 |     15,200 B |
| StringExtensionReverse |    100 |     90,542.83 ns |    69,451.87 ns |   3,806.891 ns |     87,342.61 ns |     94,752.79 ns |    3.6621 |     69,600 B |
|           **ArrayReverse** |   **1000** |     **89,897.86 ns** |    **15,295.21 ns** |     **838.382 ns** |     **89,064.07 ns** |     **90,740.76 ns** |   **16.2354** |    **304,000 B** |
|      EnumerableReverse |   1000 |  1,397,524.27 ns |   364,808.81 ns |  19,996.402 ns |  1,375,337.02 ns |  1,414,154.20 ns |   31.2500 |    600,002 B |
|       RecursiveReverse |   1000 |  2,687,112.79 ns | 1,227,427.47 ns |  67,279.441 ns |  2,644,389.82 ns |  2,764,666.66 ns |  386.7188 |  7,272,003 B |
|             ReverseXor |   1000 |    127,604.86 ns |   179,775.44 ns |   9,854.099 ns |    117,961.91 ns |    137,657.34 ns |   16.1133 |    304,000 B |
|           StackReverse |   1000 |    682,995.35 ns |   613,281.53 ns |  33,616.030 ns |    652,109.37 ns |    718,799.57 ns |   47.8516 |    896,001 B |
|             StringSpan |   1000 |     56,518.12 ns |     8,447.08 ns |     463.013 ns |     56,201.76 ns |     57,049.55 ns |    8.1177 |    152,000 B |
| StringExtensionReverse |   1000 |    910,935.51 ns |    69,343.29 ns |   3,800.940 ns |    907,321.75 ns |    914,899.40 ns |   37.1094 |    696,001 B |
|           **ArrayReverse** |  **10000** |    **800,912.21 ns** |   **362,760.83 ns** |  **19,884.145 ns** |    **786,293.05 ns** |    **823,554.41 ns** |  **162.1094** |  **3,040,001 B** |
|      EnumerableReverse |  10000 | 13,655,822.15 ns | 6,915,738.79 ns | 379,074.979 ns | 13,291,361.36 ns | 14,047,990.84 ns |  312.5000 |  6,000,013 B |
|       RecursiveReverse |  10000 | 27,857,862.35 ns | 6,748,822.99 ns | 369,925.761 ns | 27,500,987.47 ns | 28,239,586.06 ns | 3875.0000 | 72,720,026 B |
|             ReverseXor |  10000 |  1,230,530.83 ns |   234,419.24 ns |  12,849.310 ns |  1,221,603.53 ns |  1,245,257.63 ns |  162.1094 |  3,040,002 B |
|           StackReverse |  10000 |  6,905,524.92 ns | 1,748,604.48 ns |  95,846.912 ns |  6,815,725.03 ns |  7,006,448.21 ns |  476.5625 |  8,960,006 B |
|             StringSpan |  10000 |    638,967.22 ns |   293,924.70 ns |  16,111.004 ns |    625,360.94 ns |    656,757.46 ns |   81.0547 |  1,520,001 B |
| StringExtensionReverse |  10000 |  9,245,467.48 ns | 3,395,648.95 ns | 186,126.977 ns |  9,131,605.75 ns |  9,460,258.67 ns |  359.3750 |  6,960,013 B |
# Logic.Benchmark.Networks.CidrBlockBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |        Error |      StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|-------------:|------------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **114.536 ns** |    **26.684 ns** |   **1.4627 ns** |    **112.940 ns** |    **115.813 ns** |         **-** |
|       CidrBlockNewBytes |      1 |      2.440 ns |     1.619 ns |   0.0888 ns |      2.382 ns |      2.542 ns |         - |
| CidrBlockTryParseString |      1 |    120.033 ns |    73.559 ns |   4.0320 ns |    117.188 ns |    124.648 ns |         - |
|  CidrBlockTryParseBytes |      1 |     15.433 ns |    14.656 ns |   0.8033 ns |     14.910 ns |     16.358 ns |         - |
|      **CidrBlockNewString** |     **10** |  **1,223.090 ns** |   **472.566 ns** |  **25.9029 ns** |  **1,202.984 ns** |  **1,252.320 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     28.683 ns |     2.531 ns |   0.1387 ns |     28.560 ns |     28.834 ns |         - |
| CidrBlockTryParseString |     10 |  1,272.055 ns |   480.280 ns |  26.3258 ns |  1,242.613 ns |  1,293.327 ns |         - |
|  CidrBlockTryParseBytes |     10 |    150.824 ns |    52.760 ns |   2.8920 ns |    147.567 ns |    153.090 ns |         - |
|      **CidrBlockNewString** |    **100** | **11,614.252 ns** | **3,334.712 ns** | **182.7868 ns** | **11,461.567 ns** | **11,816.795 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    255.000 ns |   174.220 ns |   9.5496 ns |    248.510 ns |    265.966 ns |         - |
| CidrBlockTryParseString |    100 | 11,882.204 ns |   367.041 ns |  20.1187 ns | 11,864.297 ns | 11,903.974 ns |         - |
|  CidrBlockTryParseBytes |    100 |  1,474.804 ns |   282.744 ns |  15.4981 ns |  1,462.192 ns |  1,492.105 ns |         - |
# Logic.Benchmark.Networks.SubnetMaskBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |       StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|-------------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **43.44 ns** |     **18.25 ns** |     **1.000 ns** |     **42.64 ns** |     **44.56 ns** | **0.0030** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    258.70 ns |    113.07 ns |     6.198 ns |    252.86 ns |    265.20 ns | 0.0057 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    242.24 ns |     66.13 ns |     3.625 ns |    240.05 ns |    246.42 ns | 0.0057 |     112 B |
|     SubnetMaskFromIPAddress |      1 |    186.91 ns |     12.16 ns |     0.666 ns |    186.19 ns |    187.49 ns | 0.0029 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     93.91 ns |     23.26 ns |     1.275 ns |     93.16 ns |     95.38 ns | 0.0030 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    259.36 ns |    123.05 ns |     6.745 ns |    254.12 ns |    266.97 ns | 0.0086 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **484.34 ns** |     **33.46 ns** |     **1.834 ns** |    **482.30 ns** |    **485.85 ns** | **0.0296** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  2,578.88 ns |  1,275.38 ns |    69.908 ns |  2,511.41 ns |  2,651.00 ns | 0.0572 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  2,499.32 ns |    294.41 ns |    16.137 ns |  2,481.78 ns |  2,513.54 ns | 0.0572 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |  1,864.49 ns |    425.96 ns |    23.348 ns |  1,845.90 ns |  1,890.70 ns | 0.0286 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    954.46 ns |     74.87 ns |     4.104 ns |    950.80 ns |    958.90 ns | 0.0296 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  2,516.32 ns |    617.98 ns |    33.874 ns |  2,480.57 ns |  2,547.94 ns | 0.0877 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **4,402.16 ns** |    **709.16 ns** |    **38.872 ns** |  **4,375.85 ns** |  **4,446.81 ns** | **0.2975** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 25,960.95 ns |  2,197.44 ns |   120.449 ns | 25,860.95 ns | 26,094.66 ns | 0.5798 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 24,788.76 ns | 20,757.72 ns | 1,137.801 ns | 23,716.28 ns | 25,982.21 ns | 0.5798 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 | 18,452.69 ns |  4,058.57 ns |   222.464 ns | 18,262.40 ns | 18,697.27 ns | 0.2747 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  9,463.08 ns |  3,226.78 ns |   176.871 ns |  9,352.99 ns |  9,667.10 ns | 0.2899 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 25,839.72 ns | 12,177.67 ns |   667.499 ns | 25,306.31 ns | 26,588.26 ns | 0.8850 |  16,800 B |
# Logic.Benchmark.ValueTaskDelayBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |    Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **12.44 ms** | **2.854 ms** | **0.156 ms** |  **12.31 ms** |  **12.61 ms** |     **401 B** |
| ValueTaskDelay |      1 |  10.31 ms | 0.217 ms | 0.012 ms |  10.30 ms |  10.32 ms |     209 B |
|      **TaskDelay** |     **10** | **120.06 ms** | **8.348 ms** | **0.458 ms** | **119.56 ms** | **120.46 ms** |   **2,413 B** |
| ValueTaskDelay |     10 | 102.16 ms | 0.462 ms | 0.025 ms | 102.13 ms | 102.18 ms |     413 B |
