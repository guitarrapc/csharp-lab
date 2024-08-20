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
| **ArrayReverse**           | **10**     | **100**    |  **14.38 μs** | **162.67 μs** |  **8.917 μs** |  **11.252 μs** |   **7.444 μs** |  **24.44 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  85.61 μs | 212.45 μs | 11.645 μs |  81.462 μs |  76.613 μs |  98.77 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.19 μs | 281.73 μs | 15.443 μs |  26.735 μs |  22.017 μs |  50.81 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.64 μs | 161.94 μs |  8.876 μs |  14.647 μs |  10.640 μs |  27.62 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  63.29 μs | 250.11 μs | 13.709 μs |  69.870 μs |  47.529 μs |  72.47 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.50 μs | 167.96 μs |  9.206 μs |   7.525 μs |   6.853 μs |  23.12 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.55 μs | 258.51 μs | 14.170 μs |  27.532 μs |  27.201 μs |  51.91 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.49 μs** | **282.30 μs** | **15.474 μs** |   **8.706 μs** |   **8.405 μs** |  **35.36 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 318.95 μs | 356.93 μs | 19.565 μs | 326.401 μs | 296.755 μs | 333.69 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 155.66 μs | 167.72 μs |  9.193 μs | 150.862 μs | 149.859 μs | 166.26 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.17 μs | 215.51 μs | 11.813 μs |  60.222 μs |  51.456 μs |  74.84 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.61 μs | 550.37 μs | 30.168 μs | 232.735 μs | 210.173 μs | 269.92 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.87 μs | 206.68 μs | 11.329 μs |   8.431 μs |   8.220 μs |  27.95 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 104.27 μs | 768.85 μs | 42.143 μs |  81.712 μs |  78.216 μs | 152.90 μs |  68.69 KB |
