```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.53 μs** | **192.21 μs** | **10.536 μs** |  **10.471 μs** |  **10.420 μs** |  **28.69 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 103.72 μs | 183.52 μs | 10.059 μs | 103.613 μs |  93.714 μs | 113.83 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.14 μs | 258.08 μs | 14.146 μs |  26.099 μs |  22.011 μs |  48.30 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  24.00 μs | 208.42 μs | 11.424 μs |  21.581 μs |  13.977 μs |  36.44 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.37 μs | 230.96 μs | 12.660 μs |  43.375 μs |  42.754 μs |  64.98 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.70 μs | 164.84 μs |  9.036 μs |   7.614 μs |   7.353 μs |  23.13 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  41.34 μs | 212.43 μs | 11.644 μs |  39.239 μs |  30.883 μs |  53.89 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **20.15 μs** | **330.22 μs** | **18.100 μs** |  **10.228 μs** |   **9.187 μs** |  **41.05 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 302.87 μs | 297.25 μs | 16.293 μs | 300.469 μs | 287.906 μs | 320.23 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 172.39 μs | 354.31 μs | 19.421 μs | 163.184 μs | 159.288 μs | 194.70 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.80 μs | 258.69 μs | 14.180 μs |  60.002 μs |  50.234 μs |  78.18 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.72 μs | 427.99 μs | 23.460 μs | 233.575 μs | 225.219 μs | 269.38 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  19.23 μs | 258.36 μs | 14.162 μs |  11.596 μs |  10.524 μs |  35.57 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  97.64 μs | 580.34 μs | 31.810 μs |  79.699 μs |  78.858 μs | 134.37 μs |  68.69 KB |
