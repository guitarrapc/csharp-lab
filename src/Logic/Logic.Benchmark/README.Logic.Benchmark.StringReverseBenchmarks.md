```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.52 μs** | **160.18 μs** |  **8.780 μs** |  **11.421 μs** |   **7.704 μs** |  **24.43 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  86.11 μs | 210.63 μs | 11.546 μs |  81.833 μs |  77.315 μs |  99.19 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  44.87 μs | 430.67 μs | 23.607 μs |  36.277 μs |  26.769 μs |  71.57 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.58 μs | 158.96 μs |  8.713 μs |  14.488 μs |  10.841 μs |  27.42 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  57.25 μs | 248.74 μs | 13.634 μs |  49.557 μs |  49.197 μs |  72.99 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.59 μs | 167.60 μs |  9.187 μs |   9.277 μs |   7.345 μs |  24.13 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  46.83 μs | 303.46 μs | 16.634 μs |  37.800 μs |  36.657 μs |  66.02 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.32 μs** | **355.50 μs** | **19.486 μs** |  **12.322 μs** |  **11.812 μs** |  **45.82 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 305.85 μs | 261.16 μs | 14.315 μs | 306.805 μs | 291.077 μs | 319.66 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 203.09 μs | 823.86 μs | 45.159 μs | 177.921 μs | 176.128 μs | 255.23 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  65.64 μs | 219.79 μs | 12.047 μs |  69.780 μs |  52.067 μs |  75.07 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 248.76 μs | 834.22 μs | 45.727 μs | 235.002 μs | 211.488 μs | 299.78 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.68 μs | 267.71 μs | 14.674 μs |  10.140 μs |   8.316 μs |  34.59 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.39 μs | 599.34 μs | 32.852 μs |  69.428 μs |  69.419 μs | 126.33 μs |  68.69 KB |
