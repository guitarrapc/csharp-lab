```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.53 ns** |   **2.815 ns** | **0.154 ns** |  **17.35 ns** |  **17.62 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.92 ns |   7.266 ns | 0.398 ns | 122.67 ns | 123.38 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.34 ns |   0.675 ns | 0.037 ns | 117.32 ns | 117.38 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.60 ns |  14.441 ns | 0.792 ns |  91.92 ns |  93.47 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.83 ns |   2.986 ns | 0.164 ns |  44.65 ns |  44.95 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.30 ns |   3.536 ns | 0.194 ns |  44.15 ns |  44.52 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.37 ns |   7.914 ns | 0.434 ns | 117.97 ns | 118.83 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.98 ns** |   **6.888 ns** | **0.378 ns** |  **54.55 ns** |  **55.26 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 378.11 ns |  24.653 ns | 1.351 ns | 376.97 ns | 379.60 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.52 ns |   9.696 ns | 0.531 ns | 352.15 ns | 353.13 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.73 ns | 105.290 ns | 5.771 ns | 279.23 ns | 289.39 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.95 ns |   1.527 ns | 0.084 ns | 134.85 ns | 135.00 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.77 ns |  11.551 ns | 0.633 ns | 139.21 ns | 140.46 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 368.77 ns |  79.251 ns | 4.344 ns | 363.77 ns | 371.62 ns | 0.0057 |     504 B |
