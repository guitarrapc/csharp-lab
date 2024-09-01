```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.15 μs** | **157.99 μs** |  **8.660 μs** |  **16.020 μs** |  **10.760 μs** |  **27.68 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.47 μs | 155.45 μs |  8.521 μs |  69.491 μs |  65.844 μs |  82.08 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.95 μs | 212.80 μs | 11.665 μs |  34.847 μs |  26.480 μs |  49.52 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.54 μs | 233.85 μs | 12.818 μs |  15.869 μs |  14.437 μs |  37.32 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  60.10 μs | 243.98 μs | 13.373 μs |  53.059 μs |  51.717 μs |  75.52 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.43 μs | 249.70 μs | 13.687 μs |   9.578 μs |   7.524 μs |  32.19 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  45.62 μs | 439.05 μs | 24.066 μs |  36.690 μs |  27.300 μs |  72.88 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.42 μs** | **300.70 μs** | **16.482 μs** |   **8.906 μs** |   **8.898 μs** |  **37.45 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 308.56 μs | 357.83 μs | 19.614 μs | 313.580 μs | 286.929 μs | 325.18 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 150.06 μs |  20.57 μs |  1.127 μs | 150.022 μs | 148.950 μs | 151.20 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.81 μs | 245.27 μs | 13.444 μs |  60.840 μs |  52.102 μs |  78.49 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 248.36 μs | 790.02 μs | 43.304 μs | 235.683 μs | 212.810 μs | 296.59 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.70 μs | 198.82 μs | 10.898 μs |   8.516 μs |   8.296 μs |  27.28 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.73 μs | 602.05 μs | 33.001 μs |  66.956 μs |  66.395 μs | 123.83 μs |  68.69 KB |
