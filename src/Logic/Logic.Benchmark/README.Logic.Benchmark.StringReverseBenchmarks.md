```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median    | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.79 μs** | **198.19 μs** | **10.863 μs** |  **10.63 μs** |  **10.409 μs** |  **29.33 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  85.19 μs | 148.30 μs |  8.129 μs |  83.58 μs |  77.975 μs |  94.00 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  51.33 μs | 621.20 μs | 34.050 μs |  36.27 μs |  27.400 μs |  90.31 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  21.26 μs | 201.99 μs | 11.072 μs |  15.24 μs |  14.497 μs |  34.03 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.93 μs | 224.48 μs | 12.304 μs |  56.09 μs |  48.291 μs |  72.41 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  18.99 μs | 275.24 μs | 15.087 μs |  10.67 μs |   9.898 μs |  36.41 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.82 μs | 285.55 μs | 15.652 μs |  29.39 μs |  28.202 μs |  55.88 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **26.41 μs** | **415.89 μs** | **22.797 μs** |  **13.82 μs** |  **12.680 μs** |  **52.72 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.63 μs | 253.56 μs | 13.899 μs | 299.04 μs | 287.592 μs | 315.25 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 185.02 μs | 219.06 μs | 12.008 μs | 184.62 μs | 173.222 μs | 197.23 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.63 μs | 206.34 μs | 11.310 μs |  61.30 μs |  52.051 μs |  74.55 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.37 μs | 517.07 μs | 28.343 μs | 240.30 μs | 212.066 μs | 268.75 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  19.58 μs | 279.06 μs | 15.296 μs |  10.77 μs |  10.720 μs |  37.24 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.05 μs | 533.78 μs | 29.258 μs |  69.80 μs |  68.517 μs | 119.82 μs |  68.69 KB |
