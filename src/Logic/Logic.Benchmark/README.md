# Logic.Benchmark.StopwatchBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |     Error |   StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **65.92 ns** |  **0.404 ns** | **0.022 ns** |    **65.90 ns** |    **65.94 ns** | **0.0015** |      **40 B** |
| ValueStopwatch |      1 |    53.05 ns |  0.599 ns | 0.033 ns |    53.01 ns |    53.08 ns |      - |         - |
|      **Stopwatch** |     **10** |   **307.84 ns** |  **0.714 ns** | **0.039 ns** |   **307.79 ns** |   **307.87 ns** | **0.0014** |      **40 B** |
| ValueStopwatch |     10 |   300.63 ns |  2.195 ns | 0.120 ns |   300.49 ns |   300.71 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,744.42 ns** | **10.135 ns** | **0.556 ns** | **2,743.86 ns** | **2,744.97 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,768.40 ns |  8.805 ns | 0.483 ns | 2,767.86 ns | 2,768.77 ns |      - |         - |
# Logic.Benchmark.BinaryArrayConverterBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **25.07 ns** |    **11.083 ns** |   **0.607 ns** |     **24.64 ns** |     **25.77 ns** | **0.0013** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     83.07 ns |    12.652 ns |   0.693 ns |     82.27 ns |     83.48 ns | 0.0038 |      96 B |
|          ToBinaryArrayIntMod |      1 |     27.62 ns |     1.957 ns |   0.107 ns |     27.54 ns |     27.74 ns | 0.0013 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     16.71 ns |     0.504 ns |   0.028 ns |     16.68 ns |     16.73 ns | 0.0013 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **267.92 ns** |    **36.448 ns** |   **1.998 ns** |    **266.20 ns** |    **270.11 ns** | **0.0124** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    986.94 ns |    74.853 ns |   4.103 ns |    983.88 ns |    991.60 ns | 0.0401 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    300.14 ns |    36.277 ns |   1.988 ns |    298.52 ns |    302.36 ns | 0.0124 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    195.03 ns |    51.581 ns |   2.827 ns |    193.33 ns |    198.29 ns | 0.0126 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **2,533.34 ns** |   **260.568 ns** |  **14.283 ns** |  **2,519.43 ns** |  **2,547.97 ns** | **0.1259** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 | 10,393.40 ns | 1,372.134 ns |  75.211 ns | 10,332.85 ns | 10,477.59 ns | 0.4272 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,839.40 ns |   242.155 ns |  13.273 ns |  2,824.71 ns |  2,850.54 ns | 0.1259 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  2,509.94 ns |   294.739 ns |  16.156 ns |  2,497.61 ns |  2,528.23 ns | 0.1259 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **6,338.43 ns** |   **110.633 ns** |   **6.064 ns** |  **6,331.68 ns** |  **6,343.42 ns** | **0.3204** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 25,766.73 ns | 2,634.197 ns | 144.389 ns | 25,665.37 ns | 25,932.06 ns | 0.9155 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  7,182.41 ns | 1,018.884 ns |  55.848 ns |  7,129.94 ns |  7,241.11 ns | 0.3204 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  6,770.08 ns |   897.978 ns |  49.221 ns |  6,724.65 ns |  6,822.37 ns | 0.3204 |   8,160 B |
# Logic.Benchmark.ExponentialBackoffBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **12.61 ms** |  **0.716 ms** | **0.039 ms** |  **12.58 ms** |  **12.66 ms** |     **588 B** |
| **ExponentialBackoff** |     **10** | **764.74 ms** | **70.186 ms** | **3.847 ms** | **761.18 ms** | **768.82 ms** |   **4,696 B** |
# Logic.Benchmark.StringSplitBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |         Mean |       Error |     StdDev |          Min |          Max |    Gen 0 |   Allocated |
|------------------- |------- |-------------:|------------:|-----------:|-------------:|-------------:|---------:|------------:|
| **StringSplitNoAlloc** |      **1** |     **1.799 μs** |   **0.0302 μs** |  **0.0017 μs** |     **1.797 μs** |     **1.800 μs** |        **-** |           **-** |
|        StringSplit |      1 |     2.063 μs |   0.2074 μs |  0.0114 μs |     2.053 μs |     2.075 μs |   0.1259 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |    **18.166 μs** |   **0.3058 μs** |  **0.0168 μs** |    **18.150 μs** |    **18.183 μs** |        **-** |           **-** |
|        StringSplit |     10 |    20.360 μs |   2.2444 μs |  0.1230 μs |    20.236 μs |    20.482 μs |   1.2512 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |   **181.344 μs** |   **1.6057 μs** |  **0.0880 μs** |   **181.248 μs** |   **181.421 μs** |        **-** |           **-** |
|        StringSplit |    100 |   207.562 μs |  22.4396 μs |  1.2300 μs |   206.237 μs |   208.667 μs |  12.6953 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** | **1,813.746 μs** |  **37.0736 μs** |  **2.0321 μs** | **1,811.798 μs** | **1,815.853 μs** |        **-** |         **2 B** |
|        StringSplit |   1000 | 2,060.670 μs | 353.1459 μs | 19.3571 μs | 2,039.130 μs | 2,076.609 μs | 125.0000 | 3,208,003 B |
# Logic.Benchmark.StringReverseBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                 Method | Number |             Mean |            Error |         StdDev |              Min |              Max |     Gen 0 |    Allocated |
|----------------------- |------- |-----------------:|-----------------:|---------------:|-----------------:|-----------------:|----------:|-------------:|
|           **ArrayReverse** |      **1** |         **88.30 ns** |         **4.097 ns** |       **0.225 ns** |         **88.04 ns** |         **88.45 ns** |    **0.0120** |        **304 B** |
|      EnumerableReverse |      1 |      1,130.91 ns |        20.633 ns |       1.131 ns |      1,129.92 ns |      1,132.14 ns |    0.0229 |        600 B |
|       RecursiveReverse |      1 |      2,407.11 ns |       305.577 ns |      16.750 ns |      2,390.88 ns |      2,424.34 ns |    0.2861 |      7,272 B |
|             ReverseXor |      1 |        143.45 ns |        27.958 ns |       1.532 ns |        141.73 ns |        144.67 ns |    0.0119 |        304 B |
|           StackReverse |      1 |        595.82 ns |        20.076 ns |       1.100 ns |        594.95 ns |        597.05 ns |    0.0353 |        896 B |
|             StringSpan |      1 |         68.61 ns |        13.436 ns |       0.736 ns |         67.84 ns |         69.31 ns |    0.0060 |        152 B |
| StringExtensionReverse |      1 |        803.51 ns |        53.525 ns |       2.934 ns |        800.29 ns |        806.02 ns |    0.0277 |        696 B |
|           **ArrayReverse** |     **10** |        **802.61 ns** |       **130.151 ns** |       **7.134 ns** |        **794.42 ns** |        **807.44 ns** |    **0.1211** |      **3,040 B** |
|      EnumerableReverse |     10 |     11,139.87 ns |       373.844 ns |      20.492 ns |     11,118.56 ns |     11,159.43 ns |    0.2289 |      6,000 B |
|       RecursiveReverse |     10 |     23,150.57 ns |     6,943.243 ns |     380.583 ns |     22,768.85 ns |     23,530.01 ns |    2.8687 |     72,720 B |
|             ReverseXor |     10 |      1,289.13 ns |       335.445 ns |      18.387 ns |      1,269.79 ns |      1,306.39 ns |    0.1202 |      3,040 B |
|           StackReverse |     10 |      6,442.48 ns |       277.818 ns |      15.228 ns |      6,425.03 ns |      6,453.12 ns |    0.3510 |      8,960 B |
|             StringSpan |     10 |        570.67 ns |       197.329 ns |      10.816 ns |        560.24 ns |        581.83 ns |    0.0601 |      1,520 B |
| StringExtensionReverse |     10 |      7,760.60 ns |       436.085 ns |      23.903 ns |      7,734.00 ns |      7,780.27 ns |    0.2747 |      6,960 B |
|           **ArrayReverse** |    **100** |      **7,470.97 ns** |     **2,813.513 ns** |     **154.218 ns** |      **7,296.71 ns** |      **7,589.87 ns** |    **1.2054** |     **30,400 B** |
|      EnumerableReverse |    100 |    110,263.93 ns |     2,565.378 ns |     140.617 ns |    110,106.33 ns |    110,376.58 ns |    2.3193 |     60,000 B |
|       RecursiveReverse |    100 |    223,264.19 ns |     2,018.327 ns |     110.631 ns |    223,139.88 ns |    223,351.82 ns |   28.8086 |    727,200 B |
|             ReverseXor |    100 |     12,537.13 ns |       449.043 ns |      24.614 ns |     12,520.82 ns |     12,565.44 ns |    1.2054 |     30,400 B |
|           StackReverse |    100 |     64,420.48 ns |    31,309.577 ns |   1,716.184 ns |     63,323.21 ns |     66,398.20 ns |    3.5400 |     89,600 B |
|             StringSpan |    100 |      5,357.70 ns |       294.485 ns |      16.142 ns |      5,339.23 ns |      5,369.11 ns |    0.6027 |     15,200 B |
| StringExtensionReverse |    100 |     77,089.23 ns |     4,828.788 ns |     264.682 ns |     76,789.75 ns |     77,291.80 ns |    2.6855 |     69,600 B |
|           **ArrayReverse** |   **1000** |     **73,935.76 ns** |    **32,367.281 ns** |   **1,774.160 ns** |     **72,094.33 ns** |     **75,633.96 ns** |   **12.0850** |    **304,000 B** |
|      EnumerableReverse |   1000 |  1,107,036.95 ns |    32,528.330 ns |   1,782.988 ns |  1,104,983.31 ns |  1,108,190.13 ns |   23.4375 |    600,002 B |
|       RecursiveReverse |   1000 |  2,243,370.72 ns |   144,394.294 ns |   7,914.738 ns |  2,234,297.18 ns |  2,248,854.17 ns |  289.0625 |  7,272,003 B |
|             ReverseXor |   1000 |    124,507.62 ns |    34,636.465 ns |   1,898.542 ns |    122,879.66 ns |    126,593.12 ns |   11.9629 |    304,000 B |
|           StackReverse |   1000 |    586,186.65 ns |    39,708.507 ns |   2,176.557 ns |    584,075.81 ns |    588,423.46 ns |   35.1563 |    896,001 B |
|             StringSpan |   1000 |     52,964.26 ns |     7,374.323 ns |     404.212 ns |     52,704.33 ns |     53,429.95 ns |    6.0425 |    152,000 B |
| StringExtensionReverse |   1000 |    773,760.41 ns |   112,879.031 ns |   6,187.281 ns |    767,585.92 ns |    779,960.40 ns |   27.3438 |    696,001 B |
|           **ArrayReverse** |  **10000** |    **709,975.68 ns** |    **87,288.671 ns** |   **4,784.587 ns** |    **704,532.86 ns** |    **713,518.09 ns** |  **121.0938** |  **3,040,001 B** |
|      EnumerableReverse |  10000 | 11,278,470.30 ns |   335,452.956 ns |  18,387.308 ns | 11,262,308.33 ns | 11,298,475.47 ns |  234.3750 |  6,000,013 B |
|       RecursiveReverse |  10000 | 22,720,918.70 ns | 2,023,994.492 ns | 110,941.968 ns | 22,594,171.12 ns | 22,800,398.69 ns | 2875.0000 | 72,720,026 B |
|             ReverseXor |  10000 |  1,242,984.59 ns |   223,556.537 ns |  12,253.888 ns |  1,231,600.58 ns |  1,255,954.03 ns |  121.0938 |  3,040,002 B |
|           StackReverse |  10000 |  5,816,725.64 ns |   109,717.961 ns |   6,014.012 ns |  5,810,531.38 ns |  5,822,541.53 ns |  351.5625 |  8,960,006 B |
|             StringSpan |  10000 |    532,345.75 ns |    42,734.191 ns |   2,342.405 ns |    529,699.82 ns |    534,154.69 ns |   60.5469 |  1,520,001 B |
| StringExtensionReverse |  10000 |  7,673,334.01 ns |   890,878.046 ns |  48,832.032 ns |  7,619,975.04 ns |  7,715,799.01 ns |  273.4375 |  6,960,006 B |
# Logic.Benchmark.Networks.CidrBlockBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |       Error |     StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|------------:|-----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **100.305 ns** |   **3.5929 ns** |  **0.1969 ns** |    **100.131 ns** |    **100.519 ns** |         **-** |
|       CidrBlockNewBytes |      1 |      2.861 ns |   0.0027 ns |  0.0001 ns |      2.861 ns |      2.861 ns |         - |
| CidrBlockTryParseString |      1 |    110.690 ns |  10.5805 ns |  0.5800 ns |    110.101 ns |    111.260 ns |         - |
|  CidrBlockTryParseBytes |      1 |     14.337 ns |   0.1321 ns |  0.0072 ns |     14.333 ns |     14.345 ns |         - |
|      **CidrBlockNewString** |     **10** |  **1,028.083 ns** | **114.9653 ns** |  **6.3016 ns** |  **1,021.690 ns** |  **1,034.289 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     24.535 ns |   0.0565 ns |  0.0031 ns |     24.533 ns |     24.539 ns |         - |
| CidrBlockTryParseString |     10 |  1,104.177 ns |  75.3427 ns |  4.1298 ns |  1,101.422 ns |  1,108.925 ns |         - |
|  CidrBlockTryParseBytes |     10 |    147.904 ns |   0.3929 ns |  0.0215 ns |    147.879 ns |    147.917 ns |         - |
|      **CidrBlockNewString** |    **100** |  **9,932.744 ns** | **487.9080 ns** | **26.7439 ns** |  **9,914.380 ns** |  **9,963.428 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    253.018 ns |   0.2513 ns |  0.0138 ns |    253.004 ns |    253.031 ns |         - |
| CidrBlockTryParseString |    100 | 10,895.755 ns | 138.3896 ns |  7.5856 ns | 10,887.010 ns | 10,900.553 ns |         - |
|  CidrBlockTryParseBytes |    100 |  1,448.483 ns | 865.3945 ns | 47.4352 ns |  1,420.305 ns |  1,503.249 ns |         - |
# Logic.Benchmark.Networks.SubnetMaskBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **34.87 ns** |     **6.229 ns** |  **0.341 ns** |     **34.63 ns** |     **35.26 ns** | **0.0022** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    195.00 ns |    14.597 ns |  0.800 ns |    194.08 ns |    195.56 ns | 0.0043 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    204.25 ns |    13.081 ns |  0.717 ns |    203.74 ns |    205.07 ns | 0.0043 |     112 B |
|     SubnetMaskFromIPAddress |      1 |    148.94 ns |     5.289 ns |  0.290 ns |    148.71 ns |    149.27 ns | 0.0021 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     80.87 ns |     2.633 ns |  0.144 ns |     80.70 ns |     80.97 ns | 0.0021 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    209.92 ns |    41.884 ns |  2.296 ns |    208.59 ns |    212.57 ns | 0.0067 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **359.28 ns** |    **48.020 ns** |  **2.632 ns** |    **356.24 ns** |    **360.80 ns** | **0.0219** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,943.76 ns |    87.596 ns |  4.801 ns |  1,939.24 ns |  1,948.80 ns | 0.0420 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  2,015.38 ns |    94.961 ns |  5.205 ns |  2,012.06 ns |  2,021.38 ns | 0.0420 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |  1,490.03 ns |    42.123 ns |  2.309 ns |  1,488.07 ns |  1,492.58 ns | 0.0210 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    806.74 ns |    49.667 ns |  2.722 ns |    803.79 ns |    809.14 ns | 0.0219 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  2,093.63 ns |    32.025 ns |  1.755 ns |  2,091.99 ns |  2,095.48 ns | 0.0648 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **3,367.23 ns** |   **362.030 ns** | **19.844 ns** |  **3,351.73 ns** |  **3,389.59 ns** | **0.2213** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 19,374.91 ns |   508.018 ns | 27.846 ns | 19,343.57 ns | 19,396.81 ns | 0.4272 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 20,157.48 ns | 1,630.423 ns | 89.369 ns | 20,074.89 ns | 20,252.35 ns | 0.4272 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 | 14,910.48 ns | 1,449.203 ns | 79.436 ns | 14,863.15 ns | 15,002.19 ns | 0.2136 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  7,937.59 ns |   114.235 ns |  6.262 ns |  7,932.20 ns |  7,944.46 ns | 0.2136 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 20,855.80 ns |   460.904 ns | 25.264 ns | 20,827.08 ns | 20,874.59 ns | 0.6409 |  16,800 B |
# Logic.Benchmark.ValueTaskDelayBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |    Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **11.97 ms** | **0.322 ms** | **0.018 ms** |  **11.96 ms** |  **11.99 ms** |     **404 B** |
| ValueTaskDelay |      1 |  10.26 ms | 0.664 ms | 0.036 ms |  10.22 ms |  10.29 ms |     209 B |
|      **TaskDelay** |     **10** | **119.68 ms** | **4.842 ms** | **0.265 ms** | **119.40 ms** | **119.93 ms** |   **2,413 B** |
| ValueTaskDelay |     10 | 101.15 ms | 1.194 ms | 0.065 ms | 101.10 ms | 101.22 ms |     413 B |
