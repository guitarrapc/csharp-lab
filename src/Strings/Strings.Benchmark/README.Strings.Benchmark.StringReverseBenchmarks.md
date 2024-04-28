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
| **ArrayReverse**           | **10**     | **100**    |  **12.93 μs** | **168.07 μs** |  **9.212 μs** |   **7.715 μs** |   **7.505 μs** |  **23.57 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.63 μs | 215.86 μs | 11.832 μs |  77.230 μs |  72.632 μs |  95.03 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.37 μs | 364.74 μs | 19.993 μs |  26.659 μs |  25.007 μs |  60.43 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  25.79 μs | 403.73 μs | 22.130 μs |  15.108 μs |  11.030 μs |  51.24 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.11 μs | 278.41 μs | 15.261 μs |  45.776 μs |  44.834 μs |  71.72 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.22 μs | 177.26 μs |  9.716 μs |   7.795 μs |   7.425 μs |  24.44 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  40.05 μs | 220.27 μs | 12.074 μs |  39.854 μs |  28.082 μs |  52.23 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.45 μs** | **286.32 μs** | **15.694 μs** |   **9.743 μs** |   **9.031 μs** |  **36.56 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 309.81 μs | 205.28 μs | 11.252 μs | 305.773 μs | 301.135 μs | 322.52 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 178.81 μs |  80.03 μs |  4.387 μs | 180.589 μs | 173.816 μs | 182.03 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.72 μs | 220.91 μs | 12.109 μs |  61.996 μs |  50.995 μs |  75.18 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 243.31 μs | 593.34 μs | 32.523 μs | 237.565 μs | 214.041 μs | 278.32 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  20.12 μs | 283.47 μs | 15.538 μs |  11.492 μs |  10.820 μs |  38.06 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.29 μs | 551.07 μs | 30.206 μs |  71.454 μs |  70.252 μs | 123.16 μs |  68.69 KB |
