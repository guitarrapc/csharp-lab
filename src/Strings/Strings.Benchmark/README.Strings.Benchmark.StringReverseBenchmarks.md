```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.76 μs** | **243.15 μs** | **13.328 μs** |  **10.168 μs** |   **8.014 μs** |  **32.10 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.63 μs | 280.47 μs | 15.373 μs |  76.333 μs |  69.609 μs |  98.95 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  42.31 μs | 339.44 μs | 18.606 μs |  37.020 μs |  26.922 μs |  62.99 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.40 μs | 178.88 μs |  9.805 μs |  14.959 μs |  10.771 μs |  29.46 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.05 μs | 231.73 μs | 12.702 μs |  43.761 μs |  43.682 μs |  65.72 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.51 μs | 160.03 μs |  8.772 μs |   7.454 μs |   7.443 μs |  22.64 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.75 μs | 250.23 μs | 13.716 μs |  28.043 μs |  27.622 μs |  51.59 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.43 μs** | **268.91 μs** | **14.740 μs** |   **9.097 μs** |   **8.737 μs** |  **34.45 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 306.23 μs | 297.32 μs | 16.297 μs | 304.720 μs | 290.734 μs | 323.22 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 201.73 μs | 782.80 μs | 42.908 μs | 177.654 μs | 176.269 μs | 251.27 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  61.71 μs | 214.37 μs | 11.751 μs |  60.093 μs |  50.855 μs |  74.19 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 267.77 μs | 407.28 μs | 22.324 μs | 269.695 μs | 244.548 μs | 289.07 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.83 μs | 251.95 μs | 13.810 μs |  11.266 μs |  10.454 μs |  34.77 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.10 μs | 563.47 μs | 30.886 μs |  68.539 μs |  68.007 μs | 121.77 μs |  68.69 KB |
