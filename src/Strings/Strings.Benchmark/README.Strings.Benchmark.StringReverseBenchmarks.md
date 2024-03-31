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
| **ArrayReverse**           | **10**     | **100**    |  **34.71 μs** | **769.49 μs** | **42.178 μs** |  **10.769 μs** |   **9.958 μs** |  **83.42 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.44 μs | 242.45 μs | 13.289 μs |  73.657 μs |  68.197 μs |  93.45 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.88 μs | 343.96 μs | 18.854 μs |  26.319 μs |  25.677 μs |  58.65 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  22.08 μs | 239.10 μs | 13.106 μs |  14.852 μs |  14.171 μs |  37.20 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  63.03 μs | 327.15 μs | 17.932 μs |  53.339 μs |  52.036 μs |  83.73 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.05 μs | 181.50 μs |  9.949 μs |   7.523 μs |   7.092 μs |  24.54 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.99 μs | 328.69 μs | 18.017 μs |  28.003 μs |  27.182 μs |  58.79 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.58 μs** | **335.21 μs** | **18.374 μs** |   **9.076 μs** |   **8.865 μs** |  **40.80 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.94 μs | 252.71 μs | 13.852 μs | 300.499 μs | 288.857 μs | 316.45 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 174.06 μs |  38.14 μs |  2.091 μs | 173.553 μs | 172.271 μs | 176.36 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  71.34 μs | 292.24 μs | 16.019 μs |  67.156 μs |  57.828 μs |  89.04 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 251.19 μs | 494.72 μs | 27.117 μs | 243.192 μs | 228.966 μs | 281.40 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.76 μs | 202.59 μs | 11.105 μs |   8.676 μs |   8.034 μs |  27.58 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.99 μs | 606.19 μs | 33.227 μs |  68.552 μs |  67.070 μs | 125.35 μs |  68.69 KB |
