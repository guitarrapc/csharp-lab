```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.79 μs** | **139.41 μs** |  **7.642 μs** |  **11.392 μs** |   **7.635 μs** |  **22.34 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  88.61 μs | 248.20 μs | 13.605 μs |  83.145 μs |  78.596 μs | 104.10 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  46.18 μs | 422.91 μs | 23.181 μs |  36.437 μs |  29.465 μs |  72.64 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.80 μs | 186.64 μs | 10.230 μs |  14.837 μs |  11.140 μs |  30.42 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  56.15 μs | 243.00 μs | 13.320 μs |  48.821 μs |  48.099 μs |  71.52 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.24 μs | 153.77 μs |  8.428 μs |   7.474 μs |   7.273 μs |  21.97 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.77 μs | 239.77 μs | 13.143 μs |  28.487 μs |  27.876 μs |  50.94 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.74 μs** | **289.56 μs** | **15.872 μs** |   **8.877 μs** |   **8.286 μs** |  **36.07 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 325.89 μs | 364.59 μs | 19.984 μs | 334.342 μs | 303.065 μs | 340.25 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 184.46 μs | 111.25 μs |  6.098 μs | 187.678 μs | 177.430 μs | 188.28 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.60 μs | 266.75 μs | 14.621 μs |  61.924 μs |  51.495 μs |  80.37 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.33 μs | 486.87 μs | 26.687 μs | 240.317 μs | 216.703 μs | 269.96 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.89 μs | 240.72 μs | 13.195 μs |   8.396 μs |   8.156 μs |  31.13 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.84 μs | 615.05 μs | 33.713 μs |  69.379 μs |  69.369 μs | 127.77 μs |  68.69 KB |
