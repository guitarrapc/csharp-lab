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
| **ArrayReverse**           | **10**     | **100**    |  **17.08 μs** | **217.04 μs** | **11.897 μs** |  **10.399 μs** |  **10.028 μs** |  **30.82 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.79 μs | 337.74 μs | 18.513 μs |  71.099 μs |  65.368 μs |  99.91 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.41 μs | 347.67 μs | 19.057 μs |  26.891 μs |  25.939 μs |  59.41 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.94 μs | 150.99 μs |  8.276 μs |  15.339 μs |  11.271 μs |  27.20 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.15 μs | 242.30 μs | 13.282 μs |  43.056 μs |  41.914 μs |  65.47 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.24 μs | 207.29 μs | 11.362 μs |   9.883 μs |   9.483 μs |  29.36 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.70 μs | 296.68 μs | 16.262 μs |  39.575 μs |  39.053 μs |  67.48 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.45 μs** | **326.98 μs** | **17.923 μs** |   **9.468 μs** |   **8.746 μs** |  **40.14 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.78 μs | 278.83 μs | 15.284 μs | 301.794 μs | 286.486 μs | 317.05 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 175.98 μs |  22.86 μs |  1.253 μs | 175.424 μs | 175.104 μs | 177.42 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.20 μs | 243.49 μs | 13.347 μs |  60.805 μs |  51.206 μs |  77.58 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 246.89 μs | 565.58 μs | 31.001 μs | 239.299 μs | 220.383 μs | 280.98 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  19.37 μs | 263.44 μs | 14.440 μs |  11.270 μs |  10.790 μs |  36.04 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 105.69 μs | 594.55 μs | 32.589 μs |  94.347 μs |  80.291 μs | 142.44 μs |  68.69 KB |
