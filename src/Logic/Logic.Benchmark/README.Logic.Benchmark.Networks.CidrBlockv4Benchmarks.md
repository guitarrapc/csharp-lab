```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|-------------------------- |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **CidrBlockV4NewString**      | **1**      |  **64.8063 ns** |   **2.5420 ns** |  **0.1393 ns** |  **64.7065 ns** |  **64.9655 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |   0.0000 ns |  0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  74.5955 ns |   5.5368 ns |  0.3035 ns |  74.2567 ns |  74.8425 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0477 ns |   0.2243 ns |  0.0123 ns |   3.0347 ns |   3.0592 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **659.5453 ns** |  **15.6183 ns** |  **0.8561 ns** | **658.8239 ns** | **660.4913 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3545 ns |   1.3760 ns |  0.0754 ns |   3.2978 ns |   3.4401 ns |         - |
| CidrBlockV4TryParseString | 10     | 703.6125 ns | 194.4687 ns | 10.6595 ns | 695.8725 ns | 715.7706 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.5088 ns |   0.2417 ns |  0.0132 ns |  28.4947 ns |  28.5209 ns |         - |
