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
|             **ToBinaryArrayInt** |      **1** |     **18.81 ns** |     **2.344 ns** |   **0.128 ns** |     **18.66 ns** |     **18.89 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     70.69 ns |    37.448 ns |   2.053 ns |     69.43 ns |     73.06 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     21.01 ns |     2.981 ns |   0.163 ns |     20.82 ns |     21.13 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.74 ns |     0.907 ns |   0.050 ns |     11.70 ns |     11.80 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **187.16 ns** |    **22.819 ns** |   **1.251 ns** |    **186.12 ns** |    **188.55 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    682.12 ns |    94.099 ns |   5.158 ns |    678.68 ns |    688.05 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    210.12 ns |    25.693 ns |   1.408 ns |    208.49 ns |    210.95 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    158.45 ns |    23.274 ns |   1.276 ns |    156.98 ns |    159.28 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,789.30 ns** |    **98.909 ns** |   **5.422 ns** |  **1,784.01 ns** |  **1,794.84 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,365.89 ns |    89.185 ns |   4.889 ns |  7,361.28 ns |  7,371.02 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  1,982.83 ns |   232.088 ns |  12.722 ns |  1,974.19 ns |  1,997.44 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,856.81 ns | 1,037.276 ns |  56.857 ns |  1,813.56 ns |  1,921.21 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,485.63 ns** |   **459.675 ns** |  **25.196 ns** |  **4,457.43 ns** |  **4,505.94 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 17,062.40 ns | 3,183.594 ns | 174.504 ns | 16,917.15 ns | 17,255.97 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  4,966.98 ns |   199.446 ns |  10.932 ns |  4,954.44 ns |  4,974.55 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,030.02 ns | 1,245.233 ns |  68.255 ns |  4,958.01 ns |  5,093.77 ns | 0.0916 |   8,160 B |
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
|             Method | Number |           Mean |         Error |      StdDev |            Min |            Max |   Gen 0 |   Allocated |
|------------------- |------- |---------------:|--------------:|------------:|---------------:|---------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |       **804.0 ns** |      **19.74 ns** |     **1.08 ns** |       **803.4 ns** |       **805.2 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,486.2 ns |     135.13 ns |     7.41 ns |     1,479.4 ns |     1,494.1 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,020.5 ns** |     **102.33 ns** |     **5.61 ns** |     **8,014.1 ns** |     **8,024.5 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,162.8 ns |   2,396.21 ns |   131.34 ns |    15,028.4 ns |    15,290.9 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **79,796.2 ns** |   **1,861.41 ns** |   **102.03 ns** |    **79,704.8 ns** |    **79,906.2 ns** |       **-** |           **-** |
|        StringSplit |    100 |   145,904.4 ns |   8,767.11 ns |   480.55 ns |   145,451.8 ns |   146,408.7 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **808,279.4 ns** | **164,161.45 ns** | **8,998.24 ns** |   **802,602.0 ns** |   **818,654.3 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,450,252.4 ns |  63,685.83 ns | 3,490.84 ns | 1,446,346.3 ns | 1,453,067.1 ns | 37.1094 | 3,208,001 B |
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
|           **ArrayReverse** |      **1** |         **55.09 ns** |        **13.071 ns** |      **0.716 ns** |         **54.45 ns** |         **55.86 ns** |   **0.0036** |        **304 B** |
|      EnumerableReverse |      1 |        429.36 ns |        30.894 ns |      1.693 ns |        427.91 ns |        431.22 ns |   0.0072 |        600 B |
|       RecursiveReverse |      1 |      1,554.39 ns |       433.946 ns |     23.786 ns |      1,529.31 ns |      1,576.62 ns |   0.0858 |      7,272 B |
|             ReverseXor |      1 |        125.17 ns |        10.653 ns |      0.584 ns |        124.62 ns |        125.78 ns |   0.0036 |        304 B |
|           StackReverse |      1 |        417.76 ns |        29.856 ns |      1.637 ns |        416.17 ns |        419.44 ns |   0.0105 |        896 B |
|             StringSpan |      1 |         48.94 ns |         2.314 ns |      0.127 ns |         48.83 ns |         49.08 ns |   0.0018 |        152 B |
| StringExtensionReverse |      1 |        453.86 ns |         5.806 ns |      0.318 ns |        453.67 ns |        454.23 ns |   0.0081 |        696 B |
|           **ArrayReverse** |     **10** |        **458.92 ns** |        **64.458 ns** |      **3.533 ns** |        **456.41 ns** |        **462.96 ns** |   **0.0362** |      **3,040 B** |
|      EnumerableReverse |     10 |      4,061.15 ns |       350.333 ns |     19.203 ns |      4,043.54 ns |      4,081.63 ns |   0.0687 |      6,000 B |
|       RecursiveReverse |     10 |     15,357.96 ns |       867.950 ns |     47.575 ns |     15,303.50 ns |     15,391.47 ns |   0.8545 |     72,720 B |
|             ReverseXor |     10 |      1,170.53 ns |        45.732 ns |      2.507 ns |      1,167.93 ns |      1,172.93 ns |   0.0362 |      3,040 B |
|           StackReverse |     10 |      4,021.82 ns |       175.902 ns |      9.642 ns |      4,010.90 ns |      4,029.16 ns |   0.1068 |      8,960 B |
|             StringSpan |     10 |        387.58 ns |        49.236 ns |      2.699 ns |        385.59 ns |        390.65 ns |   0.0181 |      1,520 B |
| StringExtensionReverse |     10 |      3,951.82 ns |        84.898 ns |      4.654 ns |      3,946.60 ns |      3,955.54 ns |   0.0763 |      6,960 B |
|           **ArrayReverse** |    **100** |      **4,442.72 ns** |     **1,181.956 ns** |     **64.787 ns** |      **4,389.54 ns** |      **4,514.88 ns** |   **0.3586** |     **30,400 B** |
|      EnumerableReverse |    100 |     40,584.62 ns |     2,534.515 ns |    138.925 ns |     40,427.26 ns |     40,690.31 ns |   0.6714 |     60,000 B |
|       RecursiveReverse |    100 |    152,845.87 ns |    33,642.396 ns |  1,844.053 ns |    151,217.38 ns |    154,848.20 ns |   8.5449 |    727,200 B |
|             ReverseXor |    100 |     11,391.54 ns |       512.824 ns |     28.110 ns |     11,364.20 ns |     11,420.36 ns |   0.3510 |     30,400 B |
|           StackReverse |    100 |     40,693.44 ns |     2,325.756 ns |    127.483 ns |     40,594.52 ns |     40,837.31 ns |   1.0376 |     89,600 B |
|             StringSpan |    100 |      2,567.01 ns |        84.269 ns |      4.619 ns |      2,563.33 ns |      2,572.19 ns |   0.1793 |     15,200 B |
| StringExtensionReverse |    100 |     39,943.06 ns |     2,131.069 ns |    116.811 ns |     39,823.31 ns |     40,056.70 ns |   0.7935 |     69,600 B |
|           **ArrayReverse** |   **1000** |     **44,436.42 ns** |    **10,052.732 ns** |    **551.024 ns** |     **44,002.86 ns** |     **45,056.49 ns** |   **3.6011** |    **304,000 B** |
|      EnumerableReverse |   1000 |    406,523.93 ns |    42,517.491 ns |  2,330.527 ns |    403,977.78 ns |    408,551.45 ns |   6.8359 |    600,000 B |
|       RecursiveReverse |   1000 |  1,560,435.64 ns |    45,704.508 ns |  2,505.218 ns |  1,557,547.98 ns |  1,562,028.52 ns |  85.9375 |  7,272,001 B |
|             ReverseXor |   1000 |    114,584.73 ns |     4,262.158 ns |    233.623 ns |    114,327.48 ns |    114,783.69 ns |   3.5400 |    304,000 B |
|           StackReverse |   1000 |    407,036.96 ns |    13,585.617 ns |    744.674 ns |    406,388.58 ns |    407,850.28 ns |  10.2539 |    896,000 B |
|             StringSpan |   1000 |     25,589.76 ns |     4,271.387 ns |    234.129 ns |     25,330.87 ns |     25,786.66 ns |   1.8005 |    152,000 B |
| StringExtensionReverse |   1000 |    387,057.65 ns |    17,196.144 ns |    942.579 ns |    385,977.29 ns |    387,712.16 ns |   8.3008 |    696,000 B |
|           **ArrayReverse** |  **10000** |    **437,584.69 ns** |    **57,937.286 ns** |  **3,175.738 ns** |    **434,330.82 ns** |    **440,676.06 ns** |  **36.1328** |  **3,040,000 B** |
|      EnumerableReverse |  10000 |  4,139,911.85 ns |   115,350.895 ns |  6,322.772 ns |  4,135,463.38 ns |  4,147,149.64 ns |  70.3125 |  6,000,005 B |
|       RecursiveReverse |  10000 | 15,395,117.46 ns | 1,084,284.329 ns | 59,433.283 ns | 15,339,734.31 ns | 15,457,906.69 ns | 859.3750 | 72,720,010 B |
|             ReverseXor |  10000 |  1,155,223.71 ns |    14,952.092 ns |    819.575 ns |  1,154,498.48 ns |  1,156,112.85 ns |  35.1563 |  3,040,001 B |
|           StackReverse |  10000 |  4,129,019.25 ns | 1,245,929.988 ns | 68,293.627 ns |  4,052,275.31 ns |  4,183,100.95 ns | 101.5625 |  8,960,005 B |
|             StringSpan |  10000 |    257,593.18 ns |    12,491.616 ns |    684.708 ns |    256,852.50 ns |    258,203.05 ns |  18.0664 |  1,520,000 B |
| StringExtensionReverse |  10000 |  3,919,636.71 ns |   249,258.551 ns | 13,662.702 ns |  3,905,414.52 ns |  3,932,661.04 ns |  78.1250 |  6,960,005 B |
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
|             Method | Number |      Mean |    Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **11.99 ms** | **0.105 ms** | **0.006 ms** |  **11.98 ms** |  **11.99 ms** |     **519 B** |
| **ExponentialBackoff** |     **10** | **753.94 ms** | **2.530 ms** | **0.139 ms** | **753.83 ms** | **754.09 ms** |         **-** |
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
|         Method | Number |        Mean |     Error |   StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **61.67 ns** |  **2.002 ns** | **0.110 ns** |    **61.59 ns** |    **61.79 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.56 ns |  0.207 ns | 0.011 ns |    56.54 ns |    56.56 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.44 ns** | **10.321 ns** | **0.566 ns** |   **318.08 ns** |   **319.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   310.55 ns | 18.284 ns | 1.002 ns |   309.94 ns |   311.71 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,887.08 ns** | **67.642 ns** | **3.708 ns** | **2,884.91 ns** | **2,891.36 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,842.58 ns |  1.884 ns | 0.103 ns | 2,842.47 ns | 2,842.67 ns |      - |         - |
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
|      **TaskDelay** |      **1** |  **12.45 ms** |  **1.623 ms** | **0.089 ms** |  **12.36 ms** |  **12.54 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.15 ms |  0.107 ms | 0.006 ms |  10.14 ms |  10.15 ms |     191 B |
|      **TaskDelay** |     **10** | **122.90 ms** | **37.499 ms** | **2.055 ms** | **120.56 ms** | **124.38 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.11 ms |  0.742 ms | 0.041 ms | 101.08 ms | 101.16 ms |         - |
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
|                      Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **17.87 ns** |     **3.841 ns** |   **0.211 ns** |     **17.72 ns** |     **18.11 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    118.84 ns |     1.216 ns |   0.067 ns |    118.78 ns |    118.91 ns | 0.0013 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    111.63 ns |     2.386 ns |   0.131 ns |    111.50 ns |    111.77 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     85.29 ns |     3.055 ns |   0.167 ns |     85.10 ns |     85.40 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     44.36 ns |     2.123 ns |   0.116 ns |     44.29 ns |     44.50 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    122.19 ns |    73.765 ns |   4.043 ns |    119.79 ns |    126.86 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **188.99 ns** |    **82.662 ns** |   **4.531 ns** |    **185.81 ns** |    **194.18 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,190.30 ns |   444.917 ns |  24.387 ns |  1,176.16 ns |  1,218.46 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,124.41 ns |   329.730 ns |  18.074 ns |  1,113.30 ns |  1,145.26 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    839.98 ns |    23.420 ns |   1.284 ns |    838.73 ns |    841.30 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    450.14 ns |    12.486 ns |   0.684 ns |    449.74 ns |    450.93 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,220.76 ns |   199.198 ns |  10.919 ns |  1,214.23 ns |  1,233.37 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,838.23 ns** | **1,224.313 ns** |  **67.109 ns** |  **1,788.46 ns** |  **1,914.55 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 12,184.38 ns | 8,628.435 ns | 472.954 ns | 11,901.02 ns | 12,730.37 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,775.66 ns |   366.104 ns |  20.067 ns | 10,754.75 ns | 10,794.76 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,420.06 ns |   455.686 ns |  24.978 ns |  8,391.22 ns |  8,434.72 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,345.11 ns |   285.508 ns |  15.650 ns |  4,327.13 ns |  4,355.62 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,895.96 ns | 2,084.338 ns | 114.250 ns | 11,780.49 ns | 12,008.95 ns | 0.1984 |  16,800 B |
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
|                  Method | Number |          Mean |         Error |      StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|--------------:|------------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **60.7677 ns** |     **2.8325 ns** |   **0.1553 ns** |    **60.5898 ns** |    **60.8756 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3090 ns |     0.0053 ns |   0.0003 ns |     0.3087 ns |     0.3093 ns |         - |
| CidrBlockTryParseString |      1 |    65.5949 ns |     1.5555 ns |   0.0853 ns |    65.5281 ns |    65.6910 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.1704 ns |     0.1122 ns |   0.0062 ns |     3.1633 ns |     3.1744 ns |         - |
|      **CidrBlockNewString** |     **10** |   **630.1157 ns** |   **244.3368 ns** |  **13.3929 ns** |   **622.3332 ns** |   **645.5804 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.9325 ns |     0.9698 ns |   0.0532 ns |     2.9007 ns |     2.9939 ns |         - |
| CidrBlockTryParseString |     10 |   663.2369 ns |    15.3696 ns |   0.8425 ns |   662.2641 ns |   663.7270 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5402 ns |     0.5045 ns |   0.0277 ns |    28.5210 ns |    28.5719 ns |         - |
|      **CidrBlockNewString** |    **100** | **6,027.6063 ns** | **3,490.2762 ns** | **191.3138 ns** | **5,916.2236 ns** | **6,248.5138 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.2315 ns |     2.8769 ns |   0.1577 ns |    69.0520 ns |    69.3477 ns |         - |
| CidrBlockTryParseString |    100 | 6,422.7678 ns |    63.7554 ns |   3.4946 ns | 6,418.9002 ns | 6,425.6986 ns |         - |
|  CidrBlockTryParseBytes |    100 |   290.2817 ns |     4.5597 ns |   0.2499 ns |   290.0946 ns |   290.5655 ns |         - |
