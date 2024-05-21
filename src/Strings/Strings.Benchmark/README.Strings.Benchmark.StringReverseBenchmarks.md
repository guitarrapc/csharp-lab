```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.63 μs** | **210.60 μs** | **11.544 μs** |  **12.063 μs** |   **8.064 μs** |  **29.76 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  76.29 μs | 261.61 μs | 14.340 μs |  70.852 μs |  65.462 μs |  92.55 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.35 μs | 273.88 μs | 15.012 μs |  38.522 μs |  21.791 μs |  51.75 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.68 μs | 152.17 μs |  8.341 μs |  15.099 μs |  10.941 μs |  27.01 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.52 μs | 253.20 μs | 13.879 μs |  43.757 μs |  43.257 μs |  67.54 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.87 μs | 198.89 μs | 10.902 μs |   7.724 μs |   7.433 μs |  26.46 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  45.08 μs | 252.53 μs | 13.842 μs |  37.670 μs |  36.528 μs |  61.05 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.44 μs** | **323.65 μs** | **17.741 μs** |   **9.227 μs** |   **9.166 μs** |  **39.92 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 307.77 μs | 333.43 μs | 18.277 μs | 304.918 μs | 291.093 μs | 327.31 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.83 μs | 106.70 μs |  5.848 μs | 160.349 μs | 153.736 μs | 165.40 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.40 μs | 238.69 μs | 13.084 μs |  61.224 μs |  49.944 μs |  76.03 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 254.06 μs | 516.15 μs | 28.292 μs | 251.064 μs | 227.380 μs | 283.73 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  20.50 μs | 312.43 μs | 17.125 μs |  11.290 μs |   9.959 μs |  40.26 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  98.32 μs | 594.58 μs | 32.591 μs |  80.946 μs |  78.100 μs | 135.92 μs |  68.69 KB |
