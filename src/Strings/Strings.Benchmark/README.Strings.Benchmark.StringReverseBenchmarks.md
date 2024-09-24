```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.44 μs** |   **211.47 μs** | **11.592 μs** |   **7.804 μs** |   **7.684 μs** |  **27.82 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.35 μs |   141.95 μs |  7.781 μs |  74.799 μs |  71.172 μs |  86.09 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.99 μs |   233.18 μs | 12.782 μs |  27.491 μs |  23.874 μs |  47.60 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.78 μs |   202.76 μs | 11.114 μs |  15.704 μs |  15.033 μs |  34.61 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.39 μs |   211.59 μs | 11.598 μs |  49.212 μs |  48.189 μs |  68.77 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.27 μs |   232.04 μs | 12.719 μs |  12.093 μs |   7.955 μs |  31.76 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  39.45 μs |   260.73 μs | 14.291 μs |  31.324 μs |  31.073 μs |  55.95 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.33 μs** |   **317.12 μs** | **17.382 μs** |   **9.447 μs** |   **9.147 μs** |  **39.40 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 368.97 μs | 1,053.93 μs | 57.769 μs | 349.327 μs | 323.579 μs | 434.00 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 213.69 μs |   913.85 μs | 50.091 μs | 209.341 μs | 165.919 μs | 265.82 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.51 μs |   268.64 μs | 14.725 μs |  59.171 μs |  51.445 μs |  79.92 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 268.71 μs |   447.92 μs | 24.552 μs | 276.587 μs | 241.180 μs | 288.35 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.37 μs |   217.22 μs | 11.907 μs |   8.736 μs |   8.255 μs |  29.11 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 105.77 μs |   791.30 μs | 43.374 μs |  80.790 μs |  80.661 μs | 155.85 μs |  68.69 KB |
