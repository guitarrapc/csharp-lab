```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.38 μs** |   **211.05 μs** | **11.568 μs** |  **10.750 μs** |  **10.650 μs** |  **30.74 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.73 μs |   216.38 μs | 11.860 μs |  79.507 μs |  74.568 μs |  97.13 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.51 μs |   269.74 μs | 14.785 μs |  26.300 μs |  21.851 μs |  49.39 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.14 μs |   140.78 μs |  7.717 μs |  14.918 μs |  10.771 μs |  25.72 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.32 μs |   258.48 μs | 14.168 μs |  44.392 μs |  43.891 μs |  68.68 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.26 μs |   185.01 μs | 10.141 μs |   7.543 μs |   7.263 μs |  24.97 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.14 μs |   257.65 μs | 14.123 μs |  28.012 μs |  27.962 μs |  52.45 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.52 μs** |   **275.36 μs** | **15.094 μs** |  **10.821 μs** |  **10.791 μs** |  **36.95 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 296.12 μs |   265.40 μs | 14.547 μs | 294.057 μs | 282.716 μs | 311.59 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.53 μs |    31.06 μs |  1.702 μs | 152.012 μs | 151.141 μs | 154.43 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.69 μs |   213.08 μs | 11.680 μs |  61.134 μs |  51.867 μs |  75.07 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 266.28 μs | 1,323.52 μs | 72.547 μs | 238.453 μs | 211.763 μs | 348.62 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.76 μs |   234.50 μs | 12.854 μs |   8.677 μs |   8.005 μs |  30.60 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 105.79 μs |   844.50 μs | 46.290 μs |  79.367 μs |  78.756 μs | 159.24 μs |  68.69 KB |
