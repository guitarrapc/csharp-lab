```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.38 μs** | **185.94 μs** | **10.192 μs** |  **10.564 μs** |  **10.424 μs** |  **28.15 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  73.98 μs | 136.81 μs |  7.499 μs |  73.662 μs |  66.650 μs |  81.64 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.78 μs | 358.12 μs | 19.630 μs |  25.817 μs |  25.076 μs |  59.44 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.10 μs | 178.86 μs |  9.804 μs |  14.337 μs |  10.730 μs |  29.23 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.64 μs | 277.26 μs | 15.198 μs |  45.715 μs |  44.042 μs |  71.16 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.75 μs | 174.17 μs |  9.547 μs |   7.243 μs |   7.233 μs |  23.77 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.87 μs | 256.53 μs | 14.061 μs |  28.012 μs |  27.500 μs |  52.11 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.23 μs** | **345.73 μs** | **18.951 μs** |  **12.715 μs** |  **11.863 μs** |  **45.10 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 335.55 μs | 813.90 μs | 44.613 μs | 318.043 μs | 302.343 μs | 386.26 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 187.59 μs |  47.67 μs |  2.613 μs | 188.411 μs | 184.665 μs | 189.69 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  71.85 μs | 327.39 μs | 17.945 μs |  62.696 μs |  60.322 μs |  92.52 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 250.17 μs | 531.58 μs | 29.138 μs | 239.847 μs | 227.604 μs | 283.07 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.41 μs | 206.55 μs | 11.322 μs |   8.196 μs |   7.564 μs |  27.48 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.96 μs | 549.03 μs | 30.094 μs |  69.889 μs |  67.305 μs | 120.67 μs |  68.69 KB |
