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
| **ArrayReverse**           | **10**     | **100**    |  **14.07 μs** | **182.75 μs** | **10.017 μs** |   **8.445 μs** |   **8.135 μs** |  **25.64 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  90.45 μs | 160.20 μs |  8.781 μs |  88.043 μs |  83.115 μs | 100.18 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.73 μs | 301.18 μs | 16.509 μs |  30.938 μs |  25.708 μs |  56.56 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  20.89 μs | 239.33 μs | 13.119 μs |  15.599 μs |  11.242 μs |  35.83 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  69.32 μs | 489.03 μs | 26.805 μs |  54.010 μs |  53.669 μs | 100.27 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.08 μs | 214.86 μs | 11.777 μs |   8.365 μs |   8.205 μs |  28.68 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  46.79 μs | 298.67 μs | 16.371 μs |  37.720 μs |  36.969 μs |  65.69 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **20.84 μs** | **345.11 μs** | **18.916 μs** |  **10.349 μs** |   **9.497 μs** |  **42.68 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 354.38 μs | 371.76 μs | 20.377 μs | 349.377 μs | 336.964 μs | 376.79 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 173.08 μs |  93.67 μs |  5.134 μs | 174.906 μs | 167.282 μs | 177.05 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  80.91 μs | 398.03 μs | 21.817 μs |  72.966 μs |  64.179 μs | 105.59 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 288.88 μs | 735.29 μs | 40.304 μs | 291.054 μs | 247.533 μs | 328.05 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.52 μs | 236.35 μs | 12.955 μs |   9.242 μs |   8.832 μs |  31.47 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 110.85 μs | 755.63 μs | 41.419 μs |  90.829 μs |  83.245 μs | 158.47 μs |  68.69 KB |
