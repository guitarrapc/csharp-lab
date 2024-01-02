```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **22.85 μs** | **383.27 μs** | **21.008 μs** |  **11.342 μs** |  **10.110 μs** |  **47.10 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.89 μs | 261.32 μs | 14.324 μs |  78.060 μs |  71.598 μs |  99.00 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.97 μs | 355.61 μs | 19.492 μs |  25.988 μs |  25.437 μs |  59.47 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.36 μs | 148.04 μs |  8.115 μs |  14.672 μs |  10.925 μs |  26.47 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.95 μs | 272.11 μs | 14.915 μs |  47.368 μs |  47.317 μs |  73.18 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.48 μs | 247.13 μs | 13.546 μs |   9.909 μs |   9.417 μs |  33.12 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.20 μs | 251.80 μs | 13.802 μs |  28.728 μs |  27.736 μs |  52.12 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.24 μs** | **270.25 μs** | **14.813 μs** |  **10.460 μs** |   **8.947 μs** |  **35.33 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 312.19 μs | 498.13 μs | 27.304 μs | 308.396 μs | 286.985 μs | 341.20 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 172.59 μs |  10.92 μs |  0.599 μs | 172.522 μs | 172.021 μs | 173.21 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.64 μs | 201.71 μs | 11.056 μs |  61.614 μs |  52.137 μs |  74.18 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 246.68 μs | 531.30 μs | 29.122 μs | 244.305 μs | 218.817 μs | 276.92 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.79 μs | 201.00 μs | 11.018 μs |   8.746 μs |   8.125 μs |  27.51 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.10 μs | 552.53 μs | 30.286 μs |  69.950 μs |  69.279 μs | 122.07 μs |  68.69 KB |
