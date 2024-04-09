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
| **ArrayReverse**           | **10**     | **100**    |  **17.45 μs** | **149.56 μs** |  **8.198 μs** |  **15.665 μs** |  **10.293 μs** |  **26.39 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 106.64 μs | 160.15 μs |  8.779 μs | 109.344 μs |  96.830 μs | 113.75 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.74 μs | 346.95 μs | 19.018 μs |  26.298 μs |  25.227 μs |  58.69 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  21.15 μs | 206.79 μs | 11.335 μs |  15.009 μs |  14.217 μs |  34.23 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.18 μs | 258.53 μs | 14.171 μs |  47.629 μs |  46.377 μs |  71.52 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.76 μs | 168.65 μs |  9.244 μs |   7.504 μs |   7.343 μs |  23.43 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.07 μs | 306.37 μs | 16.793 μs |  39.162 μs |  37.599 μs |  67.44 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.85 μs** | **380.67 μs** | **20.866 μs** |  **12.213 μs** |  **11.402 μs** |  **47.94 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 306.49 μs | 286.05 μs | 15.679 μs | 306.601 μs | 290.752 μs | 322.11 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 186.04 μs | 132.44 μs |  7.259 μs | 187.570 μs | 178.143 μs | 192.42 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  66.07 μs | 269.32 μs | 14.762 μs |  67.897 μs |  50.474 μs |  79.83 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 248.52 μs | 683.25 μs | 37.451 μs | 246.741 μs | 211.986 μs | 286.82 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.35 μs | 229.54 μs | 12.582 μs |   8.236 μs |   7.934 μs |  29.88 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.93 μs | 542.74 μs | 29.749 μs |  68.388 μs |  67.126 μs | 119.27 μs |  68.69 KB |
