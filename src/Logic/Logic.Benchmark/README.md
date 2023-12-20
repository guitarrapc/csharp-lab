# Logic.Benchmark.BinaryArrayConverterBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.37 ns** |     **3.971 ns** |   **0.218 ns** |     **18.19 ns** |     **18.61 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     67.49 ns |     7.968 ns |   0.437 ns |     66.99 ns |     67.75 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     20.35 ns |     1.708 ns |   0.094 ns |     20.26 ns |     20.45 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.77 ns |     0.388 ns |   0.021 ns |     11.76 ns |     11.80 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **187.93 ns** |    **25.368 ns** |   **1.390 ns** |    **186.34 ns** |    **188.89 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    702.09 ns |    26.052 ns |   1.428 ns |    700.53 ns |    703.32 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    212.40 ns |    17.984 ns |   0.986 ns |    211.54 ns |    213.48 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    156.55 ns |    16.873 ns |   0.925 ns |    155.54 ns |    157.37 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,743.42 ns** |    **71.368 ns** |   **3.912 ns** |  **1,740.99 ns** |  **1,747.93 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,269.87 ns | 1,882.176 ns | 103.168 ns |  7,209.16 ns |  7,388.99 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,026.95 ns | 1,464.148 ns |  80.255 ns |  1,976.26 ns |  2,119.48 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,853.06 ns |   113.715 ns |   6.233 ns |  1,846.44 ns |  1,858.81 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,429.87 ns** |   **393.379 ns** |  **21.562 ns** |  **4,409.35 ns** |  **4,452.34 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 17,087.52 ns |   526.032 ns |  28.834 ns | 17,066.12 ns | 17,120.31 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  5,005.32 ns |   619.043 ns |  33.932 ns |  4,972.41 ns |  5,040.19 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,097.65 ns |   965.586 ns |  52.927 ns |  5,039.22 ns |  5,142.37 ns | 0.0916 |   8,160 B |
# Logic.Benchmark.StringSplitBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |           Mean |        Error |      StdDev |            Min |            Max |   Gen 0 |   Allocated |
|------------------- |------- |---------------:|-------------:|------------:|---------------:|---------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |       **805.5 ns** |     **37.31 ns** |     **2.05 ns** |       **803.7 ns** |       **807.7 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,515.8 ns |     44.84 ns |     2.46 ns |     1,513.9 ns |     1,518.6 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,045.3 ns** |    **189.72 ns** |    **10.40 ns** |     **8,033.8 ns** |     **8,054.1 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,396.4 ns |  3,029.12 ns |   166.04 ns |    15,286.8 ns |    15,587.5 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,772.1 ns** |  **2,519.37 ns** |   **138.10 ns** |    **79,624.2 ns** |    **79,897.6 ns** |       **-** |           **-** |
|        StringSplit |    100 |   146,289.9 ns |  4,603.46 ns |   252.33 ns |   146,041.0 ns |   146,545.5 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **802,241.3 ns** | **11,576.01 ns** |   **634.52 ns** |   **801,512.1 ns** |   **802,667.5 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,477,806.9 ns | 60,717.69 ns | 3,328.14 ns | 1,473,966.6 ns | 1,479,852.3 ns | 37.1094 | 3,208,001 B |
# Logic.Benchmark.StringReverseBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                 Method | Number |             Mean |            Error |        StdDev |              Min |              Max |    Gen 0 |    Allocated |
|----------------------- |------- |-----------------:|-----------------:|--------------:|-----------------:|-----------------:|---------:|-------------:|
|           **ArrayReverse** |      **1** |         **56.22 ns** |         **6.026 ns** |      **0.330 ns** |         **55.86 ns** |         **56.50 ns** |   **0.0036** |        **304 B** |
|      EnumerableReverse |      1 |        428.61 ns |        37.081 ns |      2.033 ns |        426.82 ns |        430.82 ns |   0.0072 |        600 B |
|       RecursiveReverse |      1 |      1,577.38 ns |        93.870 ns |      5.145 ns |      1,572.60 ns |      1,582.83 ns |   0.0858 |      7,272 B |
|             ReverseXor |      1 |        126.30 ns |        10.268 ns |      0.563 ns |        125.93 ns |        126.95 ns |   0.0036 |        304 B |
|           StackReverse |      1 |        423.95 ns |        39.156 ns |      2.146 ns |        422.66 ns |        426.43 ns |   0.0105 |        896 B |
|             StringSpan |      1 |         35.76 ns |         1.440 ns |      0.079 ns |         35.71 ns |         35.85 ns |   0.0018 |        152 B |
| StringExtensionReverse |      1 |        433.10 ns |       127.587 ns |      6.993 ns |        428.89 ns |        441.18 ns |   0.0081 |        696 B |
|           **ArrayReverse** |     **10** |        **468.83 ns** |        **37.852 ns** |      **2.075 ns** |        **466.56 ns** |        **470.63 ns** |   **0.0362** |      **3,040 B** |
|      EnumerableReverse |     10 |      4,140.97 ns |       248.422 ns |     13.617 ns |      4,129.30 ns |      4,155.93 ns |   0.0687 |      6,000 B |
|       RecursiveReverse |     10 |     16,454.61 ns |       729.993 ns |     40.013 ns |     16,409.00 ns |     16,483.78 ns |   0.8545 |     72,720 B |
|             ReverseXor |     10 |      1,180.23 ns |        64.642 ns |      3.543 ns |      1,177.16 ns |      1,184.11 ns |   0.0362 |      3,040 B |
|           StackReverse |     10 |      4,201.34 ns |       806.400 ns |     44.201 ns |      4,173.57 ns |      4,252.32 ns |   0.1068 |      8,960 B |
|             StringSpan |     10 |        282.11 ns |        13.047 ns |      0.715 ns |        281.43 ns |        282.85 ns |   0.0181 |      1,520 B |
| StringExtensionReverse |     10 |      4,038.82 ns |     1,259.035 ns |     69.012 ns |      3,993.55 ns |      4,118.25 ns |   0.0763 |      6,960 B |
|           **ArrayReverse** |    **100** |      **4,635.74 ns** |     **1,828.599 ns** |    **100.232 ns** |      **4,522.62 ns** |      **4,713.48 ns** |   **0.3586** |     **30,400 B** |
|      EnumerableReverse |    100 |     40,957.09 ns |     1,899.481 ns |    104.117 ns |     40,870.60 ns |     41,072.66 ns |   0.6714 |     60,000 B |
|       RecursiveReverse |    100 |    159,758.75 ns |    12,381.936 ns |    678.696 ns |    159,056.32 ns |    160,410.92 ns |   8.5449 |    727,200 B |
|             ReverseXor |    100 |     11,544.71 ns |       434.134 ns |     23.796 ns |     11,517.38 ns |     11,560.81 ns |   0.3510 |     30,400 B |
|           StackReverse |    100 |     40,886.11 ns |     2,926.682 ns |    160.421 ns |     40,707.04 ns |     41,016.70 ns |   1.0376 |     89,600 B |
|             StringSpan |    100 |      2,647.72 ns |       418.922 ns |     22.963 ns |      2,625.42 ns |      2,671.30 ns |   0.1793 |     15,200 B |
| StringExtensionReverse |    100 |     38,911.72 ns |    13,989.790 ns |    766.828 ns |     38,171.05 ns |     39,702.27 ns |   0.7935 |     69,600 B |
|           **ArrayReverse** |   **1000** |     **45,338.06 ns** |     **6,071.699 ns** |    **332.810 ns** |     **45,052.72 ns** |     **45,703.66 ns** |   **3.6011** |    **304,000 B** |
|      EnumerableReverse |   1000 |    408,839.27 ns |    23,080.615 ns |  1,265.126 ns |    407,379.54 ns |    409,618.60 ns |   6.8359 |    600,000 B |
|       RecursiveReverse |   1000 |  1,565,553.76 ns |   358,015.848 ns | 19,624.057 ns |  1,545,320.32 ns |  1,584,505.61 ns |  85.9375 |  7,272,001 B |
|             ReverseXor |   1000 |    116,029.10 ns |     7,311.780 ns |    400.783 ns |    115,750.10 ns |    116,488.36 ns |   3.5400 |    304,000 B |
|           StackReverse |   1000 |    432,607.17 ns |    17,441.762 ns |    956.042 ns |    431,761.38 ns |    433,644.47 ns |  10.2539 |    896,000 B |
|             StringSpan |   1000 |     26,153.83 ns |     4,632.040 ns |    253.898 ns |     25,915.67 ns |     26,420.98 ns |   1.8005 |    152,000 B |
| StringExtensionReverse |   1000 |    384,824.18 ns |    12,935.492 ns |    709.038 ns |    384,277.96 ns |    385,625.46 ns |   8.3008 |    696,000 B |
|           **ArrayReverse** |  **10000** |    **446,373.50 ns** |   **116,870.206 ns** |  **6,406.050 ns** |    **440,298.02 ns** |    **453,065.54 ns** |  **36.1328** |  **3,040,000 B** |
|      EnumerableReverse |  10000 |  4,070,457.72 ns |   136,691.962 ns |  7,492.548 ns |  4,062,006.02 ns |  4,076,285.08 ns |  70.3125 |  6,000,005 B |
|       RecursiveReverse |  10000 | 15,659,204.92 ns | 1,762,646.666 ns | 96,616.612 ns | 15,550,423.16 ns | 15,735,035.61 ns | 859.3750 | 72,720,010 B |
|             ReverseXor |  10000 |  1,158,001.51 ns |   137,051.862 ns |  7,512.275 ns |  1,150,886.30 ns |  1,165,856.16 ns |  35.1563 |  3,040,001 B |
|           StackReverse |  10000 |  4,080,087.24 ns |   308,961.309 ns | 16,935.212 ns |  4,066,978.95 ns |  4,099,208.45 ns | 101.5625 |  8,960,102 B |
|             StringSpan |  10000 |    257,251.03 ns |    49,766.298 ns |  2,727.859 ns |    254,664.76 ns |    260,101.28 ns |  18.0664 |  1,520,000 B |
| StringExtensionReverse |  10000 |  3,897,530.43 ns |    33,420.524 ns |  1,831.892 ns |  3,895,514.98 ns |  3,899,094.31 ns |  82.0313 |  6,960,003 B |
# Logic.Benchmark.ExponentialBackoffBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **11.97 ms** |  **0.696 ms** | **0.038 ms** |  **11.93 ms** |  **12.01 ms** |     **519 B** |
| **ExponentialBackoff** |     **10** | **756.80 ms** | **43.051 ms** | **2.360 ms** | **754.08 ms** | **758.28 ms** |         **-** |
# Logic.Benchmark.StopwatchBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |      Error |   StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **61.81 ns** |   **1.979 ns** | **0.108 ns** |    **61.68 ns** |    **61.88 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.63 ns |   1.968 ns | 0.108 ns |    56.55 ns |    56.75 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.96 ns** |   **4.617 ns** | **0.253 ns** |   **318.71 ns** |   **319.21 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   309.94 ns |   4.851 ns | 0.266 ns |   309.65 ns |   310.18 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,890.93 ns** | **118.421 ns** | **6.491 ns** | **2,883.45 ns** | **2,895.09 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,845.77 ns |  27.216 ns | 1.492 ns | 2,844.40 ns | 2,847.36 ns |      - |         - |
# Logic.Benchmark.ValueTaskDelayBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **12.24 ms** |  **3.172 ms** | **0.174 ms** |  **12.12 ms** |  **12.44 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.15 ms |  0.009 ms | 0.000 ms |  10.15 ms |  10.15 ms |     191 B |
|      **TaskDelay** |     **10** | **124.26 ms** | **13.084 ms** | **0.717 ms** | **123.43 ms** | **124.71 ms** |   **2,088 B** |
| ValueTaskDelay |     10 | 101.13 ms |  1.508 ms | 0.083 ms | 101.03 ms | 101.19 ms |         - |
# Logic.Benchmark.Networks.SubnetMaskBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **18.28 ns** |     **5.870 ns** |  **0.322 ns** |     **18.02 ns** |     **18.64 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    118.10 ns |    13.418 ns |  0.736 ns |    117.62 ns |    118.94 ns | 0.0013 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    112.33 ns |     1.434 ns |  0.079 ns |    112.27 ns |    112.42 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     83.21 ns |     3.326 ns |  0.182 ns |     83.02 ns |     83.38 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     46.23 ns |     6.635 ns |  0.364 ns |     46.01 ns |     46.65 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    122.63 ns |    37.291 ns |  2.044 ns |    121.05 ns |    124.94 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **190.95 ns** |    **58.052 ns** |  **3.182 ns** |    **188.43 ns** |    **194.53 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,186.75 ns |    18.201 ns |  0.998 ns |  1,185.80 ns |  1,187.79 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,086.42 ns |    43.655 ns |  2.393 ns |  1,084.70 ns |  1,089.15 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    854.49 ns |     7.096 ns |  0.389 ns |    854.19 ns |    854.93 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    449.87 ns |   122.615 ns |  6.721 ns |    445.79 ns |    457.63 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,222.78 ns |   516.754 ns | 28.325 ns |  1,196.17 ns |  1,252.55 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,823.93 ns** |   **251.985 ns** | **13.812 ns** |  **1,813.89 ns** |  **1,839.68 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,896.80 ns |   279.387 ns | 15.314 ns | 11,879.74 ns | 11,909.36 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 11,060.95 ns |   125.209 ns |  6.863 ns | 11,055.57 ns | 11,068.68 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,289.80 ns |   242.572 ns | 13.296 ns |  8,276.06 ns |  8,302.61 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,336.56 ns |   231.070 ns | 12.666 ns |  4,326.34 ns |  4,350.73 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 12,136.74 ns | 1,481.648 ns | 81.214 ns | 12,087.25 ns | 12,230.47 ns | 0.1984 |  16,800 B |
# Logic.Benchmark.Networks.CidrBlockBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |       Error |     StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|------------:|-----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **60.1034 ns** |   **3.3380 ns** |  **0.1830 ns** |    **59.9590 ns** |    **60.3092 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3095 ns |   0.0107 ns |  0.0006 ns |     0.3091 ns |     0.3102 ns |         - |
| CidrBlockTryParseString |      1 |    62.7185 ns |   0.4697 ns |  0.0257 ns |    62.6968 ns |    62.7469 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.1656 ns |   0.0746 ns |  0.0041 ns |     3.1615 ns |     3.1696 ns |         - |
|      **CidrBlockNewString** |     **10** |   **599.6606 ns** |  **20.1537 ns** |  **1.1047 ns** |   **598.9819 ns** |   **600.9353 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.8965 ns |   0.0459 ns |  0.0025 ns |     2.8943 ns |     2.8992 ns |         - |
| CidrBlockTryParseString |     10 |   631.2552 ns |   3.7350 ns |  0.2047 ns |   631.0237 ns |   631.4125 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5829 ns |   0.7489 ns |  0.0410 ns |    28.5374 ns |    28.6170 ns |         - |
|      **CidrBlockNewString** |    **100** | **6,053.6820 ns** | **154.7982 ns** |  **8.4850 ns** | **6,046.8264 ns** | **6,063.1717 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.0441 ns |   0.3336 ns |  0.0183 ns |    69.0317 ns |    69.0651 ns |         - |
| CidrBlockTryParseString |    100 | 6,243.4413 ns | 222.3673 ns | 12.1887 ns | 6,232.6847 ns | 6,256.6800 ns |         - |
|  CidrBlockTryParseBytes |    100 |   290.6345 ns |  13.6880 ns |  0.7503 ns |   290.0254 ns |   291.4726 ns |         - |
