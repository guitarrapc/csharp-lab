```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median    | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **19.41 μs** | **189.29 μs** | **10.376 μs** |  **15.93 μs** |  **11.222 μs** |  **31.08 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  91.64 μs | 651.03 μs | 35.685 μs |  74.25 μs |  67.984 μs | 132.69 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  39.55 μs | 274.30 μs | 15.035 μs |  40.08 μs |  24.255 μs |  54.31 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.97 μs | 178.74 μs |  9.797 μs |  15.58 μs |  11.310 μs |  30.01 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  70.42 μs | 226.55 μs | 12.418 μs |  64.90 μs |  61.717 μs |  84.64 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.54 μs | 187.81 μs | 10.294 μs |  10.27 μs |   8.947 μs |  27.40 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  41.54 μs | 231.61 μs | 12.695 μs |  41.70 μs |  28.764 μs |  54.15 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.34 μs** | **279.67 μs** | **15.330 μs** |  **12.12 μs** |   **8.956 μs** |  **36.95 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.58 μs | 280.18 μs | 15.358 μs | 298.00 μs | 286.675 μs | 317.06 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 170.49 μs |  89.14 μs |  4.886 μs | 172.09 μs | 165.002 μs | 174.37 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  66.32 μs | 160.13 μs |  8.777 μs |  61.86 μs |  60.675 μs |  76.43 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 245.64 μs | 545.95 μs | 29.926 μs | 241.32 μs | 218.112 μs | 277.49 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.73 μs | 258.58 μs | 14.174 μs |  10.93 μs |  10.175 μs |  35.09 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  91.60 μs | 573.18 μs | 31.418 μs |  74.21 μs |  72.727 μs | 127.87 μs |  68.69 KB |
