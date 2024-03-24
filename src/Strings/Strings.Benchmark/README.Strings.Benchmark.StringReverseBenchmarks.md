```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.33 μs** |   **170.53 μs** |  **9.347 μs** |  **10.599 μs** |   **7.424 μs** |  **24.97 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.93 μs |   246.99 μs | 13.538 μs |  70.251 μs |  66.153 μs |  91.38 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  40.88 μs |   329.12 μs | 18.040 μs |  36.700 μs |  25.298 μs |  60.64 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.47 μs |   154.27 μs |  8.456 μs |  14.848 μs |  10.640 μs |  26.93 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.86 μs |   214.62 μs | 11.764 μs |  54.032 μs |  45.115 μs |  68.43 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.08 μs |   206.48 μs | 11.318 μs |   9.709 μs |   9.379 μs |  29.14 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  47.27 μs |   373.56 μs | 20.476 μs |  43.752 μs |  28.785 μs |  69.28 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.82 μs** |   **275.62 μs** | **15.108 μs** |   **9.317 μs** |   **8.886 μs** |  **35.27 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 303.66 μs |   280.92 μs | 15.398 μs | 302.036 μs | 289.132 μs | 319.80 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 214.33 μs | 1,311.75 μs | 71.901 μs | 173.415 μs | 172.232 μs | 297.36 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.87 μs |   238.23 μs | 13.058 μs |  60.673 μs |  51.045 μs |  76.88 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 249.21 μs |   785.25 μs | 43.042 μs | 238.387 μs | 212.619 μs | 296.64 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.57 μs |   235.21 μs | 12.893 μs |   8.135 μs |   8.115 μs |  30.46 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.07 μs |   578.69 μs | 31.720 μs |  68.599 μs |  66.935 μs | 122.69 μs |  68.69 KB |
