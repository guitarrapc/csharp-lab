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
|         Method | Number |         Mean |      Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|--------------- |------- |-------------:|-----------:|----------:|-------------:|-------------:|-------:|----------:|
|      **Stopwatch** |      **1** |     **79.72 ns** |   **1.330 ns** |  **0.073 ns** |     **79.64 ns** |     **79.78 ns** | **0.0020** |      **40 B** |
| ValueStopwatch |      1 |     66.27 ns |   0.516 ns |  0.028 ns |     66.24 ns |     66.30 ns |      - |         - |
|      **Stopwatch** |     **10** |    **393.53 ns** |   **5.136 ns** |  **0.282 ns** |    **393.22 ns** |    **393.78 ns** | **0.0019** |      **40 B** |
| ValueStopwatch |     10 |    381.86 ns |  10.044 ns |  0.551 ns |    381.32 ns |    382.42 ns |      - |         - |
|      **Stopwatch** |    **100** |  **3,384.48 ns** |  **37.373 ns** |  **2.049 ns** |  **3,383.27 ns** |  **3,386.84 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 |  3,427.12 ns | 105.620 ns |  5.789 ns |  3,421.52 ns |  3,433.08 ns |      - |         - |
|      **Stopwatch** |   **1000** | **33,267.62 ns** | **256.659 ns** | **14.068 ns** | **33,251.52 ns** | **33,277.56 ns** |      **-** |      **40 B** |
| ValueStopwatch |   1000 | 33,814.57 ns | 121.736 ns |  6.673 ns | 33,809.23 ns | 33,822.05 ns |      - |         - |
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
|             **ToBinaryArrayInt** |      **1** |     **45.90 ns** |     **2.514 ns** |   **0.138 ns** |     **45.80 ns** |     **46.06 ns** | **0.0017** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |    125.53 ns |    13.329 ns |   0.731 ns |    124.69 ns |    125.99 ns | 0.0050 |      96 B |
|          ToBinaryArrayIntMod |      1 |     50.95 ns |     2.725 ns |   0.149 ns |     50.83 ns |     51.12 ns | 0.0017 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     25.91 ns |     8.118 ns |   0.445 ns |     25.54 ns |     26.41 ns | 0.0017 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **475.79 ns** |    **10.246 ns** |   **0.562 ns** |    **475.35 ns** |    **476.42 ns** | **0.0162** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |  1,481.17 ns |    47.131 ns |   2.583 ns |  1,478.55 ns |  1,483.71 ns | 0.0534 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    524.77 ns |    25.207 ns |   1.382 ns |    523.20 ns |    525.78 ns | 0.0162 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    329.96 ns |    68.722 ns |   3.767 ns |    326.06 ns |    333.58 ns | 0.0167 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **4,665.87 ns** |   **405.645 ns** |  **22.235 ns** |  **4,652.75 ns** |  **4,691.54 ns** | **0.1678** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 | 17,820.61 ns |   568.481 ns |  31.160 ns | 17,788.90 ns | 17,851.20 ns | 0.5798 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  5,107.41 ns |    56.107 ns |   3.075 ns |  5,103.88 ns |  5,109.55 ns | 0.1678 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  4,440.89 ns |   118.055 ns |   6.471 ns |  4,435.02 ns |  4,447.83 ns | 0.1678 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** | **11,860.84 ns** |   **329.380 ns** |  **18.054 ns** | **11,849.93 ns** | **11,881.68 ns** | **0.4272** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 45,931.26 ns | 3,325.475 ns | 182.281 ns | 45,735.53 ns | 46,096.16 ns | 1.2207 |  23,208 B |
|          ToBinaryArrayIntMod |    255 | 12,978.54 ns |   863.802 ns |  47.348 ns | 12,940.47 ns | 13,031.56 ns | 0.4272 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 | 12,236.13 ns |   408.675 ns |  22.401 ns | 12,210.65 ns | 12,252.71 ns | 0.4272 |   8,160 B |
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
| **ExponentialBackoff** |      **1** |  **12.23 ms** |  **1.907 ms** | **0.105 ms** |  **12.12 ms** |  **12.31 ms** |     **588 B** |
| **ExponentialBackoff** |     **10** | **754.71 ms** | **65.089 ms** | **3.568 ms** | **752.63 ms** | **758.83 ms** |   **4,696 B** |
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
|             Method | Number |          Mean |       Error |     StdDev |           Min |           Max |     Gen 0 |    Allocated |
|------------------- |------- |--------------:|------------:|-----------:|--------------:|--------------:|----------:|-------------:|
| **StringSplitNoAlloc** |      **1** |      **2.326 μs** |   **0.2308 μs** |  **0.0126 μs** |      **2.319 μs** |      **2.341 μs** |         **-** |            **-** |
|        StringSplit |      1 |      3.382 μs |   0.3092 μs |  0.0169 μs |      3.363 μs |      3.393 μs |    0.1678 |      3,208 B |
| **StringSplitNoAlloc** |     **10** |     **23.115 μs** |   **0.0310 μs** |  **0.0017 μs** |     **23.113 μs** |     **23.116 μs** |         **-** |            **-** |
|        StringSplit |     10 |     34.100 μs |   3.9085 μs |  0.2142 μs |     33.871 μs |     34.296 μs |    1.7090 |     32,080 B |
| **StringSplitNoAlloc** |    **100** |    **231.214 μs** |   **0.8598 μs** |  **0.0471 μs** |    **231.168 μs** |    **231.262 μs** |         **-** |            **-** |
|        StringSplit |    100 |    340.096 μs |  45.4479 μs |  2.4912 μs |    337.461 μs |    342.413 μs |   17.0898 |    320,800 B |
| **StringSplitNoAlloc** |   **1000** |  **2,311.036 μs** |  **10.0053 μs** |  **0.5484 μs** |  **2,310.406 μs** |  **2,311.405 μs** |         **-** |          **3 B** |
|        StringSplit |   1000 |  3,416.793 μs |  38.7480 μs |  2.1239 μs |  3,414.344 μs |  3,418.123 μs |  167.9688 |  3,208,003 B |
| **StringSplitNoAlloc** |  **10000** | **23,158.178 μs** | **139.9697 μs** |  **7.6722 μs** | **23,149.969 μs** | **23,165.167 μs** |         **-** |         **26 B** |
|        StringSplit |  10000 | 34,525.184 μs | 883.1357 μs | 48.4076 μs | 34,470.285 μs | 34,561.737 μs | 1666.6667 | 32,080,054 B |
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
|                 Method | Number |            Mean |           Error |        StdDev |             Min |             Max |     Gen 0 |    Allocated |
|----------------------- |------- |----------------:|----------------:|--------------:|----------------:|----------------:|----------:|-------------:|
|           **ArrayReverse** |      **1** |        **132.9 ns** |        **50.78 ns** |       **2.78 ns** |        **131.2 ns** |        **136.1 ns** |    **0.0162** |        **304 B** |
|      EnumerableReverse |      1 |      1,655.8 ns |        10.20 ns |       0.56 ns |      1,655.4 ns |      1,656.4 ns |    0.0305 |        600 B |
|       RecursiveReverse |      1 |      3,577.9 ns |     1,465.51 ns |      80.33 ns |      3,524.9 ns |      3,670.3 ns |    0.3891 |      7,272 B |
|             ReverseXor |      1 |        185.2 ns |         1.77 ns |       0.10 ns |        185.1 ns |        185.3 ns |    0.0162 |        304 B |
|           StackReverse |      1 |        885.3 ns |        29.15 ns |       1.60 ns |        883.9 ns |        887.0 ns |    0.0477 |        896 B |
|             StringSpan |      1 |        102.0 ns |        11.29 ns |       0.62 ns |        101.4 ns |        102.6 ns |    0.0081 |        152 B |
| StringExtensionReverse |      1 |      1,106.2 ns |        39.43 ns |       2.16 ns |      1,103.9 ns |      1,108.2 ns |    0.0362 |        696 B |
|           **ArrayReverse** |     **10** |      **1,179.7 ns** |       **698.85 ns** |      **38.31 ns** |      **1,143.1 ns** |      **1,219.6 ns** |    **0.1621** |      **3,040 B** |
|      EnumerableReverse |     10 |     16,342.2 ns |       361.17 ns |      19.80 ns |     16,323.8 ns |     16,363.2 ns |    0.3052 |      6,000 B |
|       RecursiveReverse |     10 |     37,881.8 ns |     8,308.83 ns |     455.44 ns |     37,441.6 ns |     38,351.1 ns |    3.8452 |     72,720 B |
|             ReverseXor |     10 |      1,666.6 ns |       394.65 ns |      21.63 ns |      1,644.4 ns |      1,687.6 ns |    0.1621 |      3,040 B |
|           StackReverse |     10 |      8,562.5 ns |       744.44 ns |      40.81 ns |      8,518.4 ns |      8,598.9 ns |    0.4730 |      8,960 B |
|             StringSpan |     10 |        820.4 ns |       125.45 ns |       6.88 ns |        812.5 ns |        825.1 ns |    0.0811 |      1,520 B |
| StringExtensionReverse |     10 |     11,177.9 ns |       396.11 ns |      21.71 ns |     11,155.8 ns |     11,199.2 ns |    0.3662 |      6,960 B |
|           **ArrayReverse** |    **100** |     **11,288.7 ns** |     **6,054.66 ns** |     **331.88 ns** |     **10,961.4 ns** |     **11,625.0 ns** |    **1.6174** |     **30,400 B** |
|      EnumerableReverse |    100 |    162,650.0 ns |     3,061.42 ns |     167.81 ns |    162,489.0 ns |    162,823.9 ns |    3.1738 |     60,000 B |
|       RecursiveReverse |    100 |    371,813.9 ns |    59,263.31 ns |   3,248.42 ns |    369,175.3 ns |    375,442.0 ns |   38.5742 |    727,200 B |
|             ReverseXor |    100 |     15,969.8 ns |     1,253.05 ns |      68.68 ns |     15,911.3 ns |     16,045.4 ns |    1.6174 |     30,400 B |
|           StackReverse |    100 |     84,807.0 ns |     1,169.16 ns |      64.09 ns |     84,747.9 ns |     84,875.1 ns |    4.7607 |     89,600 B |
|             StringSpan |    100 |      8,277.2 ns |     4,830.39 ns |     264.77 ns |      7,987.8 ns |      8,507.3 ns |    0.8087 |     15,200 B |
| StringExtensionReverse |    100 |    110,952.1 ns |     1,506.93 ns |      82.60 ns |    110,873.0 ns |    111,037.8 ns |    3.6621 |     69,600 B |
|           **ArrayReverse** |   **1000** |    **108,674.2 ns** |    **39,852.55 ns** |   **2,184.45 ns** |    **106,786.7 ns** |    **111,067.0 ns** |   **16.2354** |    **304,000 B** |
|      EnumerableReverse |   1000 |  1,625,085.0 ns |    14,115.09 ns |     773.70 ns |  1,624,553.9 ns |  1,625,972.7 ns |   31.2500 |    600,002 B |
|       RecursiveReverse |   1000 |  3,621,275.0 ns | 1,406,522.39 ns |  77,096.24 ns |  3,563,569.1 ns |  3,708,833.6 ns |  386.7188 |  7,272,003 B |
|             ReverseXor |   1000 |    168,881.5 ns |    19,607.70 ns |   1,074.76 ns |    167,702.5 ns |    169,806.6 ns |   16.1133 |    304,000 B |
|           StackReverse |   1000 |    907,146.3 ns |    15,239.39 ns |     835.32 ns |    906,577.4 ns |    908,105.3 ns |   47.8516 |    896,001 B |
|             StringSpan |   1000 |     75,182.8 ns |    17,179.69 ns |     941.68 ns |     74,117.7 ns |     75,904.9 ns |    8.0566 |    152,000 B |
| StringExtensionReverse |   1000 |  1,097,845.8 ns |   125,364.63 ns |   6,871.66 ns |  1,093,212.0 ns |  1,105,740.9 ns |   37.1094 |    696,002 B |
|           **ArrayReverse** |  **10000** |  **1,130,216.2 ns** |   **178,444.96 ns** |   **9,781.17 ns** |  **1,119,891.4 ns** |  **1,139,343.4 ns** |  **162.1094** |  **3,040,002 B** |
|      EnumerableReverse |  10000 | 16,137,585.1 ns |   344,553.63 ns |  18,886.15 ns | 16,120,233.1 ns | 16,157,700.8 ns |  312.5000 |  6,000,026 B |
|       RecursiveReverse |  10000 | 34,841,980.4 ns | 4,847,386.15 ns | 265,701.59 ns | 34,644,583.7 ns | 35,144,082.9 ns | 3857.1429 | 72,720,166 B |
|             ReverseXor |  10000 |  1,575,923.3 ns |   366,798.66 ns |  20,105.47 ns |  1,558,285.9 ns |  1,597,815.7 ns |  162.1094 |  3,040,002 B |
|           StackReverse |  10000 |  8,876,652.6 ns | 1,491,575.19 ns |  81,758.27 ns |  8,825,982.1 ns |  8,970,971.8 ns |  468.7500 |  8,960,013 B |
|             StringSpan |  10000 |    787,292.3 ns |   518,756.83 ns |  28,434.81 ns |    767,208.0 ns |    819,829.0 ns |   81.0547 |  1,520,001 B |
| StringExtensionReverse |  10000 | 10,855,719.7 ns |   506,389.35 ns |  27,756.91 ns | 10,830,423.5 ns | 10,885,412.5 ns |  359.3750 |  6,960,013 B |
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
|                  Method | Number |          Mean |       Error |     StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|------------:|-----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **138.597 ns** |   **5.5007 ns** |  **0.3015 ns** |    **138.268 ns** |    **138.861 ns** |         **-** |
|       CidrBlockNewBytes |      1 |      2.504 ns |   0.2856 ns |  0.0157 ns |      2.495 ns |      2.522 ns |         - |
| CidrBlockTryParseString |      1 |    142.421 ns |   4.9742 ns |  0.2727 ns |    142.247 ns |    142.735 ns |         - |
|  CidrBlockTryParseBytes |      1 |     17.797 ns |   0.1370 ns |  0.0075 ns |     17.791 ns |     17.806 ns |         - |
|      **CidrBlockNewString** |     **10** |  **1,369.249 ns** |  **29.4456 ns** |  **1.6140 ns** |  **1,368.237 ns** |  **1,371.110 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     28.936 ns |   0.1207 ns |  0.0066 ns |     28.931 ns |     28.944 ns |         - |
| CidrBlockTryParseString |     10 |  1,415.791 ns |  11.2057 ns |  0.6142 ns |  1,415.307 ns |  1,416.482 ns |         - |
|  CidrBlockTryParseBytes |     10 |    172.869 ns |   2.9602 ns |  0.1623 ns |    172.770 ns |    173.056 ns |         - |
|      **CidrBlockNewString** |    **100** | **14,026.561 ns** | **387.2855 ns** | **21.2284 ns** | **14,003.484 ns** | **14,045.257 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    292.540 ns |   0.4024 ns |  0.0221 ns |    292.517 ns |    292.561 ns |         - |
| CidrBlockTryParseString |    100 | 13,752.409 ns | 945.9312 ns | 51.8497 ns | 13,693.244 ns | 13,789.929 ns |         - |
|  CidrBlockTryParseBytes |    100 |  1,727.836 ns |   7.2813 ns |  0.3991 ns |  1,727.376 ns |  1,728.098 ns |         - |
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
|                      Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **35.84 ns** |    **10.049 ns** |   **0.551 ns** |     **35.35 ns** |     **36.44 ns** | **0.0030** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    301.69 ns |    15.162 ns |   0.831 ns |    300.74 ns |    302.27 ns | 0.0057 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    279.42 ns |     7.427 ns |   0.407 ns |    279.05 ns |    279.85 ns | 0.0057 |     112 B |
|     SubnetMaskFromIPAddress |      1 |    215.57 ns |     2.335 ns |   0.128 ns |    215.42 ns |    215.66 ns | 0.0029 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |    105.38 ns |     1.934 ns |   0.106 ns |    105.26 ns |    105.46 ns | 0.0030 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    299.19 ns |    10.333 ns |   0.566 ns |    298.76 ns |    299.83 ns | 0.0086 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **375.71 ns** |    **88.588 ns** |   **4.856 ns** |    **370.18 ns** |    **379.28 ns** | **0.0296** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  2,902.01 ns |    40.895 ns |   2.242 ns |  2,899.42 ns |  2,903.35 ns | 0.0572 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  2,820.78 ns |   101.812 ns |   5.581 ns |  2,817.11 ns |  2,827.20 ns | 0.0572 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |  2,161.34 ns |    24.381 ns |   1.336 ns |  2,160.08 ns |  2,162.74 ns | 0.0267 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |  1,061.82 ns |    64.065 ns |   3.512 ns |  1,057.90 ns |  1,064.68 ns | 0.0286 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  2,999.45 ns |    52.840 ns |   2.896 ns |  2,996.67 ns |  3,002.45 ns | 0.0877 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **3,601.95 ns** | **1,986.945 ns** | **108.911 ns** |  **3,500.65 ns** |  **3,717.14 ns** | **0.2975** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 30,103.19 ns |   203.749 ns |  11.168 ns | 30,092.59 ns | 30,114.85 ns | 0.5798 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 27,712.61 ns |   320.280 ns |  17.556 ns | 27,692.53 ns | 27,725.06 ns | 0.5798 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 | 21,843.60 ns | 1,420.772 ns |  77.877 ns | 21,757.36 ns | 21,908.78 ns | 0.2747 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 | 10,497.32 ns |   764.669 ns |  41.914 ns | 10,469.66 ns | 10,545.55 ns | 0.2899 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 29,684.51 ns | 1,811.167 ns |  99.276 ns | 29,572.99 ns | 29,763.27 ns | 0.8850 |  16,800 B |
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
|         Method | Number |        Mean |      Error |    StdDev |         Min |         Max | Allocated |
|--------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
|      **TaskDelay** |      **1** |    **11.97 ms** |   **0.503 ms** |  **0.028 ms** |    **11.95 ms** |    **12.00 ms** |     **401 B** |
| ValueTaskDelay |      1 |    10.22 ms |   0.266 ms |  0.015 ms |    10.20 ms |    10.23 ms |     194 B |
|      **TaskDelay** |     **10** |   **124.84 ms** |  **38.736 ms** |  **2.123 ms** |   **122.46 ms** |   **126.53 ms** |   **2,460 B** |
| ValueTaskDelay |     10 |   101.35 ms |   2.016 ms |  0.110 ms |   101.22 ms |   101.42 ms |     421 B |
|      **TaskDelay** |    **100** | **1,242.17 ms** | **246.836 ms** | **13.530 ms** | **1,227.74 ms** | **1,254.57 ms** |  **21,288 B** |
| ValueTaskDelay |    100 | 1,013.97 ms |  14.436 ms |  0.791 ms | 1,013.46 ms | 1,014.88 ms |   1,296 B |
