```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.37 μs** | **175.27 μs** |  **9.607 μs** |  **15.709 μs** |  **10.369 μs** |  **29.02 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  73.35 μs | 133.28 μs |  7.306 μs |  71.695 μs |  67.016 μs |  81.34 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  48.37 μs | 381.82 μs | 20.929 μs |  37.249 μs |  35.356 μs |  72.52 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.69 μs | 186.04 μs | 10.198 μs |  14.963 μs |  10.886 μs |  30.23 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  62.61 μs | 321.81 μs | 17.639 μs |  54.291 μs |  50.674 μs |  82.87 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.69 μs | 171.44 μs |  9.397 μs |   7.425 μs |   7.114 μs |  23.54 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.62 μs | 291.38 μs | 15.971 μs |  27.852 μs |  26.950 μs |  55.05 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.42 μs** | **266.47 μs** | **14.606 μs** |   **9.337 μs** |   **8.646 μs** |  **34.28 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.91 μs | 287.60 μs | 15.764 μs | 301.945 μs | 290.834 μs | 321.94 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 175.64 μs |  35.85 μs |  1.965 μs | 174.762 μs | 174.262 μs | 177.89 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  72.06 μs | 280.17 μs | 15.357 μs |  68.850 μs |  58.560 μs |  88.77 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 247.73 μs | 556.03 μs | 30.478 μs | 262.902 μs | 212.648 μs | 267.65 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.57 μs | 235.86 μs | 12.928 μs |   8.206 μs |   8.005 μs |  30.50 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  96.66 μs | 564.59 μs | 30.947 μs |  80.530 μs |  77.104 μs | 132.34 μs |  68.69 KB |
