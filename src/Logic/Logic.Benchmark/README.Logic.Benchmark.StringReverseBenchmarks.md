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
| **ArrayReverse**           | **10**     | **100**    |  **17.31 μs** | **199.15 μs** | **10.916 μs** |  **11.541 μs** |  **10.480 μs** |  **29.89 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  89.61 μs | 244.19 μs | 13.385 μs |  86.492 μs |  78.056 μs | 104.28 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.76 μs | 374.42 μs | 20.523 μs |  27.301 μs |  26.529 μs |  62.46 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.56 μs | 168.80 μs |  9.253 μs |  15.248 μs |  11.421 μs |  29.01 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.39 μs | 245.33 μs | 13.447 μs |  45.461 μs |  43.828 μs |  67.89 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.85 μs | 170.91 μs |  9.368 μs |   7.524 μs |   7.353 μs |  23.66 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.35 μs | 253.93 μs | 13.919 μs |  27.541 μs |  27.080 μs |  51.41 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.79 μs** | **263.99 μs** | **14.470 μs** |   **9.618 μs** |   **9.247 μs** |  **34.49 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 309.81 μs | 268.77 μs | 14.732 μs | 307.653 μs | 296.282 μs | 325.51 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 179.64 μs |  69.46 μs |  3.807 μs | 181.069 μs | 175.327 μs | 182.53 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  72.78 μs | 291.43 μs | 15.974 μs |  69.404 μs |  58.764 μs |  90.17 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.53 μs | 529.54 μs | 29.026 μs | 232.083 μs | 209.992 μs | 267.53 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.28 μs | 203.89 μs | 11.176 μs |   9.217 μs |   8.455 μs |  28.18 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.28 μs | 529.60 μs | 29.029 μs |  69.439 μs |  67.615 μs | 118.78 μs |  68.69 KB |
